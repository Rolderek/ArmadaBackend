using ArmadaBackend.Data;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FleetController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FleetController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fleet>>> GetAll()
        {
            var fleets = await _context.Fleets.ToListAsync();
            return Ok(fleets);
        }

        [HttpGet("ThisId/{id:int}")]
        public async Task<ActionResult<Fleet>> GetThisId(int id)
        {
            var fleet = await _context.Fleets.FirstOrDefaultAsync(c => c.Id == id);

            if (fleet is null)
            {
                return NotFound($"Nem található flotta ezzel az ID-val: {id}");
            }

            return Ok(fleet);
        }

        [HttpPost]
        public async Task<ActionResult<Fleet>> CreateFeet([FromBody] Fleet fleet)
        {
            fleet.Id = 0; 
            _context.Fleets.Add(fleet);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetThisId), new { id = fleet.Id }, fleet);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Fleet>> UpdateFleet(int id, [FromBody] Fleet updatedFleet)
        {
            if (id != updatedFleet.Id)
            {
                return BadRequest("Az ID nem egyezik a frissített flotta ID-jával.");
            }
            var existingFleet = await _context.Fleets.FindAsync(id);
            if (existingFleet is null)
            {
                return NotFound($"Nem található flotta ezzel az ID-val: {id}");
            }
            existingFleet.Name = updatedFleet.Name;
            existingFleet.Ships = updatedFleet.Ships;
            existingFleet.Squadrons = updatedFleet.Squadrons;
            existingFleet.Objectives = updatedFleet.Objectives;

            await _context.SaveChangesAsync();
            return Ok(existingFleet);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteFleet(int id)
        {
            var fleetToDelete = await _context.Fleets.FindAsync(id);
            if (fleetToDelete is null)
            {
                return NotFound($"Nem található flotta ezzel az ID-val: {id}");
            }
            _context.Fleets.Remove(fleetToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
