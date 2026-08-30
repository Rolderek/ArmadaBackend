using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using ArmadaBackend.Services.DataTranferObjects;
using ArmadaBackend.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static ArmadaBackend.Services.DataTranferObjects.Ships;

namespace ArmadaBackend.Services
{
    public class ShipService : IShipService
    {
        readonly AppDbContext _context;

        public ShipService(AppDbContext context)
        {   
            _context = context;
        }

        public async Task<ShipDto> CreateAsync(CreateShipRequest request, CancellationToken ctn)
        {
            var ship = new Ship
            {
                Name = request.Name,
                FactinId = request.FactionId,
                Size = request.Size,
                Point = request.Point,
            };
            _context.Ships.Add(ship);
            await _context.SaveChangesAsync(ctn);
            return ToDto(ship);
        }

        public async Task<bool> DeleteAsyn(int id, CancellationToken ctn)
        {
            var ship = await _context.Ships.FirstOrDefaultAsync(
                s => s.Id == id, ctn);
            if (ship == null)
            {
                return false;
            }
            _context.Ships.Remove(ship);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IReadOnlyList<ShipDto>> GetAllAsync(CancellationToken ctn)
        {
            return await _context.Ships.AsNoTracking().Select(ship => new ShipDto(
                ship.Id,
                ship.Name,
                ship.FactinId,
                ship.Size,
                ship.Point))
                .ToListAsync(ctn);
        }

        public async Task<ShipDto?> GetByIdAsync(int id, CancellationToken ctn)
        {
            return await _context.Ships.AsNoTracking()
                .Where(s => s.Id == id)
                .Select(s => new ShipDto(
                    s.Id,
                    s.Name,
                    s.FactinId,
                    s.Size,
                    s.Point)).FirstOrDefaultAsync(ctn);
        }

        public async Task<bool> UpdateAsync(int id, UpdateShipRequest request, CancellationToken ctn)
        {
            var ship = await _context.Ships
                .FirstOrDefaultAsync(ship => ship.Id == id, ctn);
            if (ship is null)
            {
                return false;
            }
            ship.Name = request.Name;
            ship.FactinId = request.FactionId;
            ship.Size = request.Size;
            ship.Point = request.Point;
            await _context.SaveChangesAsync(ctn);
            return true; //itt a visszatérési érték lehetne más, d emindegy így egyszerű
        }

        public async Task<IEnumerable<string>> GetShipNames(CancellationToken ctn)
        {
            return await  _context.Ships
                .Where(c => c.Name != null)
                .Select(c => c.Name!)
                .ToListAsync(ctn);
        }

        public async Task<IEnumerable<Ship>> GetShipWithSimilarName(string name, CancellationToken ctn)
        {
            return await _context.Ships
                .Where(c => c.Name != null && EF.Functions.Like(c.Name, $"%{name}%"))
                .ToListAsync(ctn);
        }

        public async Task<ActionResult<IEnumerable<Ship>>> GetAllShipInOneFaction(int cat, CancellationToken ctn)
        {
            return await _context.Ships.Where(c => c.FactinId == cat).ToListAsync();
        }

        public async Task<ActionResult<IEnumerable<Ship>>> GetShipsBySize(int size, CancellationToken ctn)
        {
            return await _context.Ships.Where(c => c.Size == (ShipSize)size).ToListAsync();
        }




        static ShipDto ToDto(Ship ship) //nem biztos hogy kell..?
        {
            return new ShipDto(
                ship.Id,
                ship.Name,
                ship.FactinId,
                ship.Size,
                ship.Point);
        }
    }
}
