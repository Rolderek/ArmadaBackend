using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using ArmadaBackend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using static ArmadaBackend.Services.DataTranferObjects.Cards;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _service;

        public CardsController(ICardService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetAllCard(CancellationToken ctn)
        {
            var cards = await _service.GetAllAsync(ctn);
            return Ok(cards);
        }

        [HttpGet("NameContains/{name}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetShipWithSimilarName([FromRoute] string name, CancellationToken ctn)
        {
            var cards = await _service.GetCardWithSimilarNameAsync(name, ctn);
            return Ok(cards);
        }

        [HttpGet("rebel")]
        public async Task<ActionResult<IEnumerable<Card>>> GetRebelCards(CancellationToken ctn)
        {
            var cards = await _service.GetRebelCardsAsync(ctn);
            return Ok(cards);
        }

        [HttpGet("imperial")]
        public async Task<ActionResult<IEnumerable<Card>>> GetImperialCards(CancellationToken ctn)
        {
            var cards = await _service.GetImperialCardsAsync(ctn);
            return Ok(cards);
        }

        [HttpGet("GAR")]
        public async Task<ActionResult<IEnumerable<Card>>> GetGARCards(CancellationToken ctn)
        {
            var cards = await _service.GetGARCardsAsync(ctn);
            return Ok(cards);
        }

        [HttpGet("CIS")]
        public async Task<ActionResult<IEnumerable<Card>>> GetCISCards(CancellationToken ctn)
        {
            var cards = await _service.GetCISCardsAsync(ctn);
            return Ok(cards);
        }

        [HttpGet("category/{id:int}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCardFromThisCategory([FromRoute] int id, CancellationToken ctn)
        {
            var cards = await _service.GetAllCardFromThisCategoryAsync(id, ctn);
            return Ok(cards);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CardDto>> GetCardById([FromRoute] int id, CancellationToken ctn)
        {
            var card = await _service.GetByIdAsync(id, ctn);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound($"A keresett kártya nem található! {id}");
        }

        [HttpGet("GetForDecoder")]
        public async Task<ActionResult<IEnumerable<Card>>> GetForDecoder([FromQuery] List<int> c, CancellationToken ctn)
        {
            if (c.Count == 0)
            {
                return BadRequest("Üres a lsita");
            }
            var cards = await _service.GetForDecoder(c, ctn);
            return Ok(cards);
        }

        [HttpPost]
        public async Task<ActionResult<CardDto>> AddCard([FromBody] CreateCardRequest request, CancellationToken ctn)
        {
            var card = await _service.CreateAsync(request, ctn);
            return card != null ? Ok(card) : BadRequest("Nem sikerült hozzáadni!");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<bool>> UpdateCard([FromRoute] int id, [FromBody] UpdateCardRequest request, CancellationToken ctn)
        {
            var result = await _service.UpdateAsync(id, request, ctn);
            return result ? Ok($"Sikeresen módosítuk a {id} azonosítójú kártyát.") : BadRequest("Nincs ilyen azonosítójú kártya!)");
        }
        /*
        {
            "name": "Imperial Star Destroyer II",
            "factinId": 1,
            "size": 2,
            "point": 120,
            "cardsType": [
              {
                "category": 1
              },
              {
                "category": 14
              },
              {
                "category": 30
              },
              {
                "category": 11
              },
              {
                "category": 31
              },
              {
                "category": 4
              },
              {
                "category": 10
              },
              {
                "category": 28
              },
              {
                "category": 25
              }
            ]
        }
        */


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCard([FromRoute] int id, CancellationToken ctn)
        {
            var  result = await _service.DeleteAsync(id, ctn);
            return result ? Ok($"A {id} sorszámú kártya törölve!") : NotFound($"A {id} sorszámú kártya nem található!");
        }
        /*
        {
        "id": 24,
        "size": 3,
        "factinId": 1,
        "name": "Imperial Star Destroyer II",
        "point": 120,
        "cardsType": [
          {
            "category": 0
          }
            ]
        }
        */

    }
}
