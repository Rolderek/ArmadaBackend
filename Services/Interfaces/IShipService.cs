using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using static ArmadaBackend.Services.DataTranferObjects.Ships;

namespace ArmadaBackend.Services.Interfaces
{
    public interface IShipService
    {
        Task<IReadOnlyList<ShipDto>> GetAllAsync(CancellationToken ctn);
        Task<ShipDto?> GetByIdAsync(int id, CancellationToken ctn);
        Task<bool> UpdateAsync(int id, UpdateShipRequest request, CancellationToken ctn);
        Task<bool> DeleteAsyn(int id, CancellationToken ctn);
        Task<ShipDto> CreateAsync(CreateShipRequest request, CancellationToken ctn);
        Task<IEnumerable<string>> GetShipNames(CancellationToken ctn);
        Task<IEnumerable<Ship>> GetShipWithSimilarName(string name, CancellationToken ctn);
        Task<ActionResult<IEnumerable<Ship>>> GetAllShipInOneFaction(int cat, CancellationToken ctn);
        Task<ActionResult<IEnumerable<Ship>>> GetShipsBySize(int size, CancellationToken ctn);
    }
}
