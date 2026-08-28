using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using ArmadaBackend.Services.GetServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UpgradeCardsGetFromDB _upgradeCardsGetFromDB;

        public CardsController(AppDbContext context, UpgradeCardsGetFromDB upgradeCardsGetFromDB)
        {
            _context = context;
            _upgradeCardsGetFromDB = upgradeCardsGetFromDB;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCard()
        {
            //return await _upgradeCardsGetFromDB.GetAllCards(); //??????
            return await _context.Cards.ToListAsync();
        }

        [HttpGet("NameContains/{name}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCard([FromRoute] string name)
        {
            return await _context.Cards
                .Where(c => c.Name != null && EF.Functions.Like(c.Name, $"%{name}%"))
                .ToListAsync();
        }

        [HttpGet("rebel")]
        public async Task<ActionResult<IEnumerable<Card>>> GetRebelCards()
        {
            return await _context.Cards.Where(
                c => c.Category == CardCategory.CommanderRebel ||
                c.Category == CardCategory.OfficerRebel ||
                c.Category == CardCategory.TitleRebel)
                .ToListAsync();
        }

        [HttpGet("imperial")]
        public async Task<ActionResult<IEnumerable<Card>>> GetImperialCards()
        {
            return await _context.Cards.Where(
                c => c.Category == CardCategory.CommanderImperial ||
                c.Category == CardCategory.OfficerImperial ||
                c.Category == CardCategory.TitleImperial ||
                c.Category == CardCategory.SuperweaponImperial)
                .ToListAsync();
        }

        [HttpGet("GAR")]
        public async Task<ActionResult<IEnumerable<Card>>> GetGARCards()
        {
            return await _context.Cards.Where(
                c => c.Category == CardCategory.CommanderGAR ||
                c.Category == CardCategory.OfficerGAR ||
                c.Category == CardCategory.TitleGAR ||
                c.Category == (CardCategory)5 ||
                c.Category == (CardCategory)8 ||
                c.Category == (CardCategory)29
                )
                .ToListAsync();
        }

        [HttpGet("CIS")]
        public async Task<ActionResult<IEnumerable<Card>>> GetCISCards()
        {
            return await _context.Cards.Where(
                c => c.Category == (CardCategory)3 ||
                    c.Category == (CardCategory)5 ||
                    c.Category == (CardCategory)8 ||
                    c.Category == (CardCategory)13 ||
                    c.Category == (CardCategory)18 ||
                    c.Category == (CardCategory)23 ||
                    c.Category == (CardCategory)27 ||
                    c.Category == (CardCategory)29
                )
                .ToListAsync();
        }

        [HttpGet("category/{id:int}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCardFromThisCategory([FromRoute] int id)
        {
            return await _context.Cards.Where(c => c.Category == (CardCategory)id).ToListAsync();
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetCardById([FromRoute] int id)
        {
            return await _context.Cards.Where(c => c.Id == id).ToListAsync();
        }

        [HttpGet("GetForDecoder")]
        public async Task<ActionResult<IEnumerable<Card>>> GetForDecoder([FromQuery] List<int> c)
        {
            if (c.Count == 0)
            {
                return BadRequest("Üres a lsita");
            }
            var cards = await _context.Cards
                .Where(cards => c.Contains(cards.Id))
                .ToListAsync();
            //egyszer adja vissza mindet
            return Ok(cards);
        }

        [HttpPost]
        public async Task<ActionResult<Card>> AddCard([FromBody] Card newCard)
        {
            _context.Cards.Add(newCard);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCardById), new { id = newCard.Id }, newCard);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Card>> UpdateCard([FromRoute] int id, [FromBody] Card newCard)
        {
            var eC = _context.Cards.FirstOrDefault(c => c.Id == id);
            if (eC == null)
            {
                return NotFound();
            }
            else 
            {
                eC.Category = newCard.Category;
                eC.Name = newCard.Name;
                eC.Description = newCard.Description;
                eC.Point = newCard.Point;
                await _context.SaveChangesAsync();
                return Ok(eC);
            }
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
        public async Task<ActionResult> DeleteCard([FromRoute] int id)
        {
            var cardToDel = await _context.Cards.FirstOrDefaultAsync(c => c.Id == id);
            if (cardToDel == null)
            {
                return NotFound();
            }
            _context.Cards.Remove(cardToDel);
            await _context.SaveChangesAsync();
            return Ok($"törölve {id}");
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
