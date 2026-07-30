

using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ArmadaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CardsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCard()
        {
            return await _context.Cards.ToListAsync();
        }

        [HttpGet("NameContains{name}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCard(string name)
        {
            return await _context.Cards.Where(
                c => c.Name.ToLower().Contains(name.ToLower())
                ).ToListAsync();
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
                c => c.Category == CardCategory.CommanderImperial ||
                c.Category == CardCategory.OfficerImperial ||
                c.Category == CardCategory.TitleImperial ||
                c.Category == CardCategory.SuperweaponImperial)
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

        [HttpPost]
        public async Task<ActionResult<Card>> AddCard([FromBody] Card newCard)
        {
            _context.Cards.Add(newCard);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCardById), new { id = newCard.Id }, newCard);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Card>> UpdateCard( Card newCard, int id)
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

        [HttpPut("CardCategoryOnly")]
        public async Task<ActionResult<Card>> ChangeOnlyCardCategory(int id, int newCategoryId)
        {
            var eC = _context.Cards.FirstOrDefault(c => c.Id == id);
            if (eC == null)
            {
                return NotFound();
            }
            else
            {
                eC.Category = (CardCategory)newCategoryId;
                await _context.SaveChangesAsync();
                return Ok(eC);
            }
        }

        [HttpPut("ChangeNameOnly")]
        public async Task<ActionResult<Card>> ChangeNameOnly(int id, string newName)
        {
            var eC = _context.Cards.FirstOrDefault(c => c.Id == id);
            if (eC == null)
            {
                return NotFound();
            }
            else
            {
                eC.Name = newName;
                await _context.SaveChangesAsync();
                return Ok(eC);
            }
        }

        [HttpPut("ChangeDescOnly")]
        public async Task<ActionResult<Card>> ChangeDescOnly(int id, string desc)
        {
            var eC = _context.Cards.FirstOrDefault(c => c.Id == id);
            if (eC == null)
            {
                return NotFound();
            }
            else
            {
                eC.Description = desc;
                await _context.SaveChangesAsync();
                return Ok(eC);
            }
        }

        [HttpPut("ChangePointsOnly")]
        public async Task<ActionResult<Card>> ChangePointOnly(int id, int point)
        {
            var eC = _context.Cards.FirstOrDefault(c => c.Id == id);
            if (eC == null)
            {
                return NotFound();
            }
            else
            {
                eC.Point = point;
                await _context.SaveChangesAsync();
                return Ok(eC);
            }
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> DeleteCard(int id)
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

    }
}
