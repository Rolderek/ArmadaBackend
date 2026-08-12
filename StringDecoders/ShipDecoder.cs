using ArmadaBackend.Models;
using Microsoft.IdentityModel.Tokens;

namespace ArmadaBackend.StringDecoders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10;10;10;35;42#O:A=10;D=40;N=99;
// F1#a#S:3[]#Q:#O: -- minimum hossz = 16 karakter
{
    public class ShipDecoder
    {
        public List<int> Ships { get; set; } = new List<int>();
        public List<List<int>> Cards { get; set; } = new List<List<int>>();

        public ShipDecoder(string code) 
        {
            ShipDecode(code);
        }

        //egy hajónak az upgrade kártyáit szedi össze:
        public List<int> CardDecode(string code)
        {
            List<int> result = new List<int>();
            string preCode = code[1..^1]; 
            string[] ids = preCode.Split(",");
            foreach (string i in ids)
            {
                result.Add(Int32.Parse(i)); //lehet szebben kellene?
            }
            return result; 
        }

        public void ShipDecode(string code)
        {
            if (code.IsNullOrEmpty())
            {
                throw new Exception("Nem lehet üres a hajó lista, valami félre ment!");
            }
            else if (code == "S:") // a hajók nem lehetnek üresek alapértelmezetten!
            {
                throw new Exception("Üresen került mentésre a hajó lista!");
            }
            string littleCode = code[2..]; // - "S:" az elejéről
            //S:3[1,30,17,20];5[35,2,7]
            string[] shipsWithCards = littleCode.Split(";");
            //3[1,30,17,20] mint lista elemek
            foreach (string e in shipsWithCards)
            {
                //mehet a feltöltés a propertibe egyből
                this.Ships.Add(Int32.Parse(e[..1]));
                this.Cards.Add(CardDecode(e[1..]));
            }

        }


        /*
         e[..1] // első karakter
         e[1..] // minden az első karakter után
         e[..^1] // minden az utolsó karakter nélkül
         e[1..^1] // első és utolsó karakter nélkül
        */
    }
}
