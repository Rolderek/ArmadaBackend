using ArmadaBackend.Data;
using ArmadaBackend.Models;
using Microsoft.EntityFrameworkCore;


//mi a rossz?
namespace ArmadaBackend.Services.GetServices
{
    public class UpgradeCardsGetFromDB
    {
        readonly AppDbContext _context;

        public UpgradeCardsGetFromDB(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Card>> GetAllCards()
        {
            return await _context.Cards.ToListAsync(); 
        }
    }
}
