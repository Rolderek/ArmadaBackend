using ArmadaBackend.Data;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ObjectivesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ObjectivesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objectives>>> GetAll()
        {
            var objectives = await _context.ObjectiveCards.ToListAsync();
            return objectives is null ? NotFound() : Ok(objectives);
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<ActionResult<Objectives>> GetById([FromQuery] int id)
        {
            var objective = await _context.ObjectiveCards.FirstOrDefaultAsync(o => o.Id == id);
            return objective is null ? NotFound() : Ok(objective);
        }

        [HttpGet("GetForDecoder")]
        public async Task<ActionResult<IEnumerable<Objectives>>> GetForDecoder([FromQuery] List<int> ids)
        {
            if (ids.Count == 0)
            {
                return BadRequest("Legalább egy objective ID szükséges.");
            }
            var objectives = await _context.ObjectiveCards
                .Where(objective => ids.Contains(objective.Id))
                .ToListAsync();
            //egyszer adja vissza mindet
            return Ok(objectives);
        }

        [HttpPost("CreateNewSquadron")]
        public async Task<ActionResult<Objectives>> CreateObjectiveCard([FromBody] Objectives newObj)
        {
            //ide lehet kell majd egy null ellenőrzés, de nem biztos
            _context.ObjectiveCards.Add(newObj);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = newObj.Id }, newObj);
        }

        [HttpPut("ModifyThis/{id:int}")]
        public async Task<ActionResult<Objectives>> ModifyObjective([FromBody] Objectives newObj, [FromQuery] int id)
        {
            var eO = await _context.ObjectiveCards.FirstOrDefaultAsync(o => o.Id == id);
            if (eO is null)
            {
                return NotFound();
            }
            else
            {
                if (newObj.Name != null && newObj.Name != eO.Name)
                {
                    eO.Name = newObj.Name;
                }
                if (newObj.Category != null && newObj.Category != eO.Category)
                {
                    eO.Category = newObj.Category;
                }
                if (newObj.Description != null && newObj.Description != eO.Description)
                {
                    eO.Description = newObj.Description;
                }
                if (newObj.Point != null && newObj.Point != eO.Point)
                {
                    eO.Point = newObj.Point;
                }
                await _context.SaveChangesAsync();
                return Ok(eO);
            }        
        }

        [HttpDelete("DeleteById/{id:int}")]
        public async Task<ActionResult<IEnumerable<Objectives>>> DeleteById([FromQuery] int id)
        {
            var objToDel = await _context.ObjectiveCards.FirstOrDefaultAsync(o => o.Id == id);
            if ( objToDel is null )
            {
                return NotFound();
            }
            _context.ObjectiveCards.Remove(objToDel);
            await _context.SaveChangesAsync();
            return Ok($"A(z) {id} küldetés törölve.");
        }
    }
}
