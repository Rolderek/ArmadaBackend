using ArmadaBackend.Data;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquadronCardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SquadronCardController(AppDbContext context)
        {
            _context = context;
        }

        /*
        { //példa vadász:
            "id": 12,
            "factionId": 0,
            "squadronName": "Moldy Crow",
            "aceName": "Jan Ors",
            "isUnique": true,
            "point": 19
        },
        */

        [HttpGet("GetAllSquadron")]
        public async Task<ActionResult<IEnumerable<SquadronCard>>> GetAllSquadron()
        {
            return await _context.SquadronCards.ToListAsync();
        }


        [HttpGet("GetByFaction")]
        public async Task<ActionResult<IEnumerable<SquadronCard>>> GetByFaction([FromQuery] int id)
        {
            var squadrons = await _context.SquadronCards.Where(c => c.FactionId == id).ToListAsync();
            return squadrons is null ? NotFound() : Ok(squadrons);
        }

        [HttpGet("GetByThisId")]
        public async Task<ActionResult<SquadronCard>> GetByThisId([FromQuery] int id)
        {
            var squadron = await _context.SquadronCards.FirstOrDefaultAsync(c => c.Id == id);
            return squadron is null ? NotFound() : Ok(squadron);
        }

        [HttpGet("GetSimilarPilotName")]
        public async Task<ActionResult<IEnumerable<SquadronCard>>> GetSimilarName([FromQuery] string name)
        {
            var squad = await _context.SquadronCards.Where(c => c.AceName != null && c.AceName != "na") //ezt a feltételt lehet át kell majd dolgozni
                .Where(c => c.AceName.ToLower().Contains(name.ToLower())).ToListAsync();
            return squad is null ? NotFound() : Ok(squad);
        }

        [HttpGet("GetSimilarSquadronName")]
        public async Task<ActionResult<IEnumerable<SquadronCard>>> GetSimilarSquadronName([FromQuery] string name)
        {
            var squad = await _context.SquadronCards.Where(c => c.SquadronName.ToLower().Contains(name.ToLower())).ToListAsync();
            return squad is null ? NotFound() : Ok(squad);
        }

        [HttpGet("GetAces")]
        public async Task<ActionResult<IEnumerable<SquadronCard>>> GetAces()
        {
            var squad = await _context.SquadronCards.Where(c => c.AceName != "na" && c.IsUnique == true).ToListAsync();
            return squad is null ? NotFound() : Ok(squad);
        }

        [HttpGet("GetRegulars")]
        public async Task<ActionResult<IEnumerable<SquadronCard>>> GetRegulars()
        {
            var s = await _context.SquadronCards.Where(c => c.AceName == "na" && c.IsUnique == false).ToListAsync();
            return s == null ? NotFound() : Ok(s);
        }

        [HttpPost("CreateNewSquadron")]
        public async Task<ActionResult<SquadronCard>> CreateSquadron([FromBody] SquadronCard newSquadron)
        {
            _context.SquadronCards.Add(newSquadron);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetByThisId), new { id = newSquadron.Id }, newSquadron);
        }

        [HttpPut("UpdateSquadron")]
        public async Task<ActionResult<SquadronCard>> UpdateSquadron([FromBody] SquadronCard newSquadron, [FromQuery] int id)
        {
            var eS = await _context.SquadronCards.FirstOrDefaultAsync(c => c.Id == id);
            if (eS == null)
            {
                return NotFound();
            }
            else
            {
                eS.FactionId = newSquadron.FactionId;
                eS.SquadronName = newSquadron.SquadronName;
                eS.AceName = newSquadron.AceName;
                eS.IsUnique = newSquadron.IsUnique;
                eS.Point = newSquadron.Point;
                await _context.SaveChangesAsync();
                return Ok(eS);
            }
        }

        [HttpDelete("DeleteSquadron")]
        public async Task<ActionResult> DeleteSquadron([FromQuery] int id)
        {
            var squadTodel = await _context.SquadronCards.FirstOrDefaultAsync(c => c.Id == id);
            if (squadTodel == null)
            {
                return NotFound();
            }
            _context.SquadronCards.Remove(squadTodel);
            await _context.SaveChangesAsync();
            return Ok($"Törölve {id}");

        }
    }
}
