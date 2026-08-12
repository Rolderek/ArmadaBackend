using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var names = await _context.Ships
                .Where(c => c.Name != null)
                .Select(c => c.Name!)
                .ToListAsync();
            return Ok(names);
        }

        [HttpGet("ShipWithSimilarName/{name}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShipWithSimilarName([FromRoute] string name)
        {
            var ships = await _context.Ships
                .Where(c => c.Name != null && EF.Functions.Like(c.Name, $"%{name}%"))
                .ToListAsync();
            return Ok(ships);
        }

        //ennek megadjuk melyik frakciót akarjuk és azokat adja vissza, nincs duplikált metódus
        [HttpGet("ShipINOneFaction/{cat:int}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetAllShipInOneFaction([FromRoute] int cat)
        {
            var ships = await _context.Ships.Where(c => c.FactinId == cat).ToListAsync();
            return Ok(ships);
        }

        [HttpGet("ShipsBySize/{size:int}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShipsBySize([FromRoute] int size)
        {
            var ships = await _context.Ships.Where(c => c.Size == (ShipSize)size).ToListAsync();
            return Ok(ships);
        }

        [HttpGet("byId/{id:int}")]
        public async Task<ActionResult<Ship>> GetById([FromRoute] int id)
        {
            var ship = await _context.Ships
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
                .FirstOrDefaultAsync(c => c.Id == id);

            if (eS == null)
            {
                return NotFound();
            }
            eS.FactinId = newShip.FactinId;
            eS.Name = newShip.Name;
            eS.Point = newShip.Point;
            eS.Size = newShip.Size;
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

