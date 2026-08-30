using ArmadaBackend.Models;
using ArmadaBackend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static ArmadaBackend.Services.DataTranferObjects.Ships;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipContoroller : ControllerBase
    {
        private readonly IShipService _service;

        public ShipContoroller(IShipService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ShipDto>>> GetAllShip(CancellationToken ctn)
        {
            var ship = await _service.GetAllAsync(ctn);
            return Ok(ship);
        }

        [HttpGet("ShipNames")]
        public async Task<ActionResult<IReadOnlyList<string>>> GetShipNames(CancellationToken ctn)
        {
            var names = await _service.GetShipNames(ctn);
            return Ok(names);

        }

        [HttpGet("ShipWithSimilarName/{name}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShipWithSimilarName([FromRoute] string name, CancellationToken ctn)
        {
            var ships = await _service.GetShipWithSimilarName(name, ctn);
            return Ok(ships);
        }

        //ennek megadjuk melyik frakciót akarjuk és azokat adja vissza, nincs duplikált metódus
        [HttpGet("ShipINOneFaction/{cat:int}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetAllShipInOneFaction([FromRoute] int cat, CancellationToken ctn)
        {
            var ships = await _service.GetAllShipInOneFaction(cat, ctn);
            return Ok(ships);
        }

        [HttpGet("ShipsBySize/{size:int}")]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShipsBySize([FromRoute] int size, CancellationToken ctn)
        {
            var ships = await _service.GetShipsBySize(size, ctn);
            return Ok(ships);
        }

        [HttpGet("byId/{id:int}")]
        public async Task<ActionResult<Ship>> GetById([FromRoute] int id, CancellationToken ctn)
        {
            var ship = await _service.GetByIdAsync(id, ctn);

            return ship is null ? NotFound() : Ok(ship);
        }   

        [HttpPost("CreateNewShip")]
        public async Task<ActionResult<Ship>> AddShip([FromBody] CreateShipRequest newShip, CancellationToken ctn)
        {
            await _service.CreateAsync(newShip, ctn);
            return CreatedAtAction(nameof(GetById), newShip);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Ship>> UpdateShip([FromRoute] int id, [FromBody] UpdateShipRequest newShip, CancellationToken ctn)
        {
            bool result = await _service.UpdateAsync(id, newShip, ctn);
            if (result == true)
            {
                return Ok(newShip);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:int}")] 
        public async Task<ActionResult> DeleteShip([FromRoute] int id, CancellationToken ctn)
        {
            bool result = await _service.DeleteAsyn(id, ctn);
            return result == true ? NotFound() : Ok(result);
        }
    }
}

