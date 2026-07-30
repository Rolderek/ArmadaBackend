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


    }
}
