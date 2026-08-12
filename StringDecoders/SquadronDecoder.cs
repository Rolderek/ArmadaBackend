using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ArmadaBackend.StringDecoders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10;10;10;35;42#O:A=10;D=40;N=99;
// F1#a#S:3[]#Q:#O: -- minimum hossz = 16 karakter
{
    public class SquadronDecoder
    {
        public List<int> Squadrons { get; set; } = new List<int>();

        public SquadronDecoder(string codedSquadrons) 
        {
            DecodedSquadrons(codedSquadrons); //lehet így nem túl elegáns, de amint létrehozzuk már kell neki a string és fel is tölti a listát ha van
        }

        public void DecodedSquadrons(string codedSquadrons)
        {
            if (codedSquadrons.IsNullOrEmpty())
            {
                throw new Exception("Üres, vagy null squadron érték!");
            }
            else if (codedSquadrons == "Q:")
            {
                this.Squadrons = new List<int>(); //ha üres akkor ez a lsita is üres lesz
            }
            string actualSquadrons = codedSquadrons[2..];
            string[] parts = actualSquadrons.Split(";");
            foreach (string p in parts)
            {
                this.Squadrons.Add(int.Parse(p));
            }
        }
    }
}
