using ArmadaBackend.Data;
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
    }
}
