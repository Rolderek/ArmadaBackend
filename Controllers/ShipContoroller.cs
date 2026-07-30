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
            return await _context.Ships.Select(c => c.Name).ToListAsync();
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


    }
}
