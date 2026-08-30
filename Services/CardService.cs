using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using ArmadaBackend.Services.DataTranferObjects;
using ArmadaBackend.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using static ArmadaBackend.Services.DataTranferObjects.Cards;
using static ArmadaBackend.Services.DataTranferObjects.Ships;

namespace ArmadaBackend.Services
{
    public class CardService : ICardService
    {
        readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }
        private CardDto ToDto(Card card)
        {
            return new CardDto(
                card.Id,
                card.Category,
                card.Name,
                card.Description,
                card.Point
                );
        }

        public async Task<CardDto> CreateAsync(CreateCardRequest request, CancellationToken ctn)
        {
            var card = new Card { 
                Category = request.category,
                Name = request.Name,
                Description = request.Description,
                Point = request.Point,
                };
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();
            return ToDto(card);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ctn)
        {
            var card = await _context.Cards.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, ctn);
            if (card != null)
            {
                return false;
            }
            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IReadOnlyList<CardDto>> GetAllAsync(CancellationToken ctn)
        {
            return await _context.Cards.AsNoTracking().Select(c => new CardDto(
                c.Id,
                c.Category,
                c.Name,
                c.Description,
                c.Point)).ToListAsync(ctn);
        }

        public async Task<IEnumerable<Card>> GetAllCardFromThisCategoryAsync(int id, CancellationToken ctn)
        {
            return await _context.Cards.Where(c => c.Category == (CardCategory)id).ToListAsync(ctn);
        }

        public async Task<Card> GetByIdAsync(int id, CancellationToken ctn) //ezt lehet bool-osra kellene megcsinálni
        {
            var result = await _context.Cards.FirstOrDefaultAsync(c => c.Id == id, ctn);
            return result;
        }

        public async Task<IEnumerable<Card>> GetCardWithSimilarNameAsync(string name, CancellationToken ctn) //ezt is lehetne szebben...
        {
            return await _context.Cards.AsNoTracking().Where(c => c.Name != null && EF.Functions.Like(c.Name, $"%{name}%")).ToListAsync(ctn);
        }

        public async Task<IEnumerable<Card>> GetCISCardsAsync(CancellationToken ctn)
        {
            return await _context.Cards.AsNoTracking().Where(
                c => c.Category == (CardCategory)3 ||
                c.Category == (CardCategory)5 ||
                c.Category == (CardCategory)8 ||
                c.Category == (CardCategory)13 ||
                c.Category == (CardCategory)18 ||
                c.Category == (CardCategory)23 ||
                c.Category == (CardCategory)27 ||
                c.Category == (CardCategory)29)
                .ToListAsync(ctn);
        }

        public async Task<IEnumerable<Card>> GetGARCardsAsync(CancellationToken ctn)
        {
            return await _context.Cards.AsNoTracking().Where(
                c => c.Category == CardCategory.CommanderGAR ||
                c.Category == CardCategory.OfficerGAR ||
                c.Category == CardCategory.TitleGAR ||
                c.Category == (CardCategory)5 ||
                c.Category == (CardCategory)8 ||
                c.Category == (CardCategory)29)
                .ToListAsync(ctn);
        }

        public async Task<IEnumerable<Card>> GetImperialCardsAsync(CancellationToken ctn)
        {
            return await _context.Cards.AsNoTracking().Where(
                c => c.Category == CardCategory.CommanderImperial ||
                c.Category == CardCategory.OfficerImperial ||
                c.Category == CardCategory.TitleImperial ||
                c.Category == CardCategory.SuperweaponImperial)
                .ToListAsync(ctn);
        }

        public async Task<IEnumerable<Card>> GetRebelCardsAsync(CancellationToken ctn)
        {
            return await _context.Cards.AsNoTracking().Where(
                c => c.Category == CardCategory.CommanderRebel ||
                c.Category == CardCategory.OfficerRebel ||
                c.Category == CardCategory.TitleRebel)
                .ToListAsync(ctn);
        }

        public async Task<bool> UpdateAsync(int id, UpdateCardRequest request, CancellationToken ctn) //nem a leg elegánsabb, de működik
        {
            var card = await _context.Cards.FirstOrDefaultAsync(c => c.Id == id, ctn);
            if (card is null)
            {
                return false;
            }
            card.Category = request.category;
            card.Name = request.Name;
            card.Description = request.Description;
            card.Point = request.Point;
            await _context.SaveChangesAsync(ctn);
            return true;
        }

        public async Task<IEnumerable<Card>> GetForDecoder(List<int> c, CancellationToken ctn)
        {
            var cards = await _context.Cards.AsNoTracking().Where(
                card => c.Contains(card.Id))
                .ToListAsync(ctn);
            return cards;
        }

        async Task<CardDto?> ICardService.GetByIdAsync(int id, CancellationToken ctn) //lehet null, majd kezelni
        {
            return ToDto(await _context.Cards.FirstOrDefaultAsync(c => c.Id == id, ctn));
        }
    }
}
