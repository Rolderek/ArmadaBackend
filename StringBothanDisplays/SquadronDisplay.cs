//ez az osztály segít megjeleníteni a UI-on a vadászokat amit egy BotanBuilder készít.

namespace ArmadaBackend.StringBotanDisplays
{
    public class SquadronDisplay
    {
        public int SquadronCardId { get; set; }
        public int Quantity { get; set; }
    }

    //ebből lehet majd ez a blazor felületen: "private List<SquadronSelectionDto> SelectedSquadrons = [];"
}
