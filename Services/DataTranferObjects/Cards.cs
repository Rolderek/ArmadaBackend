using ArmadaBackend.Enums;

namespace ArmadaBackend.Services.DataTranferObjects
{
    public class Cards
    {
        public sealed record CardDto(
            int Id,
            CardCategory Category,
            string Name,
            string Description,
            int Point);

        public sealed record CreateCardRequest(
            CardCategory category,
            string Name,
            string Description,
            int Point);
            
        public sealed record UpdateCardRequest(
            CardCategory category,
            string Name,
            string Description,
            int Point);
    }
}
