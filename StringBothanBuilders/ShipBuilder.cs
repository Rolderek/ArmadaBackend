using ArmadaBackend.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ArmadaBackend.StringBotanBuilders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=101;D=102;N=103;
{
    public class ShipBuilder
    {
        public string Starter { get; } = "S:";

        public string ShipString { get; set; } = string.Empty;

        public ShipBuilder(List<(int ShipId, List<int> CardIds)> ships)
        {
            MakingShipsToString(ships);
        }

        public string CardBuilderForOneShip(List<int> cards)
        {
            return string.Join(',', cards);
        }

        public void MakingShipsToString(List<(int ShipId, List<int> CardIds)> ships)
        {
            StringBuilder builder = new StringBuilder(Starter);

            for (int i = 0; i < ships.Count; i++)
            {
                builder.Append(ships[i].ShipId);
                builder.Append('[');

                string cardIds = CardBuilderForOneShip(ships[i].CardIds);
                builder.Append(cardIds);

                builder.Append(']');

                if (i < ships.Count - 1)
                {
                    builder.Append(';');
                }
            }

            this.ShipString = builder.ToString();
        }
    }

    
}
