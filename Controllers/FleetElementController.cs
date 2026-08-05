using ArmadaBackend.Data;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FleetElementController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FleetElementController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<FleetElement>>> GetAll()
        {
            var elemetns = await _context.FleetElements.ToListAsync();
            return elemetns is null ? NotFound() : Ok(elemetns);
        }

    }
}
