using ArmadaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using static ArmadaBackend.Services.DataTranferObjects.Cards;

namespace ArmadaBackend.Services.Interfaces
{
    public interface ICardService
    {
        Task<IReadOnlyList<CardDto>> GetAllAsync(CancellationToken ctn);
        Task<CardDto?> GetByIdAsync(int id, CancellationToken ctn);
        Task<bool> UpdateAsync(int id, UpdateCardRequest request, CancellationToken ctn);
        Task<bool> DeleteAsync(int id, CancellationToken ctn);
        Task<CardDto> CreateAsync(CreateCardRequest request, CancellationToken ctn);
        Task<IEnumerable<Card>> GetCardWithSimilarNameAsync(string name, CancellationToken ctn);
        Task<IEnumerable<Card>> GetRebelCardsAsync(CancellationToken ctn);
        Task<IEnumerable<Card>> GetImperialCardsAsync(CancellationToken ctn);
        Task<IEnumerable<Card>> GetGARCardsAsync(CancellationToken ctn);
        Task<IEnumerable<Card>> GetCISCardsAsync(CancellationToken ctn);
        Task<IEnumerable<Card>> GetAllCardFromThisCategoryAsync(int categoryId, CancellationToken ctn);
        Task<IEnumerable<Card>> GetForDecoder(List<int> c, CancellationToken ctn); //ezt lehet át kell majd írni, Andrissal megbeszélni

    }
}
