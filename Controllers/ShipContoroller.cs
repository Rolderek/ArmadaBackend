using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipContoroller : ControllerBase
    {
        private readonly AppDbContext _context;

        public ShipContoroller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ship>>> GetAllShip()
        {
            return await _context.Ships.ToListAsync();
        }

        [HttpGet("ShipNames")]
        public async Task<ActionResult<IEnumerable<string>>> GetShipNames()
        {
            var names = await _context.Ships.Select(c => c.Name).ToListAsync();
            return names is null ? NotFound() : Ok(names);
        }

        [HttpGet("ShipWithSimilarName{name}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShipWithSimilarName(string name)
        {
            var ships = await _context.Ships.Where(
                c => c.Name.ToLower().Contains(name.ToLower())).ToListAsync();
            if (ships != null)
            {
                return Ok(ships);
            }
            return NotFound();
        }

        //ennek megadjuk melyik frakciót akarjuk és azokat adja vissza, nincs duplikált metódus
        [HttpGet("ShipINOneFaction/{cat:int}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetAllShipInOneFaction([FromRoute] int cat)
        {
            var ships = await _context.Ships.Where(c => c.FactinId == cat).ToListAsync();
            return ships.IsNullOrEmpty() ? NotFound() : Ok(ships);
        }

        [HttpGet("ShipsBySize/{size:int}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShipsBySize([FromRoute] int size)
        {
            var ships = await _context.Ships.Where(c => c.Size == (ShipSize)size).ToListAsync();
            return ships.IsNullOrEmpty() ? NotFound() : Ok(ships);
        }

        [HttpGet("byId/{id:int}")]
        public async Task<ActionResult<Ship>> GetById([FromRoute] int id)
        {
            var ship = await _context.Ships
                .Include(s => s.CardsType)
                .FirstOrDefaultAsync(s => s.Id == id);

            return ship is null ? NotFound() : Ok(ship);
        }   

        [HttpPost("CreateNewShip")]
        public async Task<ActionResult<Ship>> AddShip([FromBody] Ship newShip)
        {
            newShip.Id = 0; //biztosnági nullázás, hogy az EF core adjon neki élrtéket
            _context.Ships.Add(newShip);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = newShip.Id }, newShip);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Ship>> UpdateShip([FromRoute] int id, [FromBody] Ship newShip)
        {
            if (id != newShip.Id)
            {
                return BadRequest("Az URL-ben lévő ID nem egyezik a módosítandó hajó ID-jával.");
            }
            var eS = await _context.Ships
                .Include(s => s.CardsType)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (eS == null)
            {
                return NotFound();
            }
            eS.FactinId = newShip.FactinId;
            eS.Name = newShip.Name;
            eS.Point = newShip.Point;
            eS.Size = newShip.Size;
            _context.ShipCards.RemoveRange(eS.CardsType);
            eS.CardsType = newShip.CardsType;
            await _context.SaveChangesAsync();
            return Ok(eS);
        }

        [HttpDelete("{id:int}")] 
        public async Task<ActionResult> DeleteShip([FromRoute] int id)
        {
            var shipToDel = await _context.Ships.FindAsync(id); 
            if (shipToDel == null)
            {
                return NotFound();
            }
            _context.Ships.Remove(shipToDel);
            await _context.SaveChangesAsync();
            return NoContent(); 
        }
    }
}

