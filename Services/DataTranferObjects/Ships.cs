using ArmadaBackend.Enums;

//DTO és Request modell:
namespace ArmadaBackend.Services.DataTranferObjects
{
    public class Ships
    {
        public sealed record ShipDto(
            int Id,
            string? Name,
            int FactionId,
            ShipSize Size,
            int Point);

        public sealed record CreateShipRequest(
            string? Name,
            int FactionId,
            ShipSize Size,
            int Point);
        public sealed record UpdateShipRequest(
            string? Name,
            int FactionId,
            ShipSize Size,
            int Point);
    }
}
