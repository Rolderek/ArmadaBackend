using ArmadaBackend.Data;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FleetElementController : ControllerBase
{
    private readonly AppDbContext _context;

    public FleetElementController(AppDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<FleetElement>>> GetAll()
    {
        var elements = await _context.FleetElements
            .AsNoTracking()
            .ToListAsync();

        return Ok(elements);
    }

  
    [HttpGet("{id:int}")]
    public async Task<ActionResult<FleetElement>> GetThis(int id)
    {
        var element = await _context.FleetElements
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id == id);

        return element is null ? NotFound() : Ok(element);
    }

    [HttpPost]
    public async Task<ActionResult<FleetElement>> Create([FromBody] FleetElement element)
    {
        var fleetExists = await _context.Fleets.AnyAsync(f => f.Id == element.FleetId);

        if (!fleetExists)
        {
            return BadRequest($"Nem létezik flotta ezzel az ID-val: {element.FleetId}");
        }

        var shipExists = await _context.Ships.AnyAsync(s => s.Id == element.ShipId);

        if (!shipExists)
        {
            return BadRequest($"Nem létezik hajó ezzel az ID-val: {element.ShipId}");
        }

        _context.FleetElements.Add(element);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetThis),
            new { id = element.Id },
            element);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Change(int id, [FromBody] FleetElement element)
    {
        var existingElement =
            await _context.FleetElements.FindAsync(id);

        if (existingElement is null)
        {
            return NotFound();
        }

        existingElement.FleetId = element.FleetId;
        existingElement.ShipId = element.ShipId;
        existingElement.EquippedUpgrades = element.EquippedUpgrades;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var element = await _context.FleetElements.FindAsync(id);

        if (element is null)
        {
            return NotFound();
        }

        _context.FleetElements.Remove(element);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}