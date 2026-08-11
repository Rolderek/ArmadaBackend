using System.Text;  

namespace ArmadaBackend.StringDecoders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=10;D=40;N=99;
//szét szedi a nagy stringet typusonkénti darabokra:

{
    public class SeparateForTypes
    {
        public string Version { get; set; }
        public string Name { get; set; }
        public string Ships { get; set; }
        public string Squadrons { get; set; }
        public string Objectives { get; set; }

        //itt a Version határozza meg a szeparátort.
        public SeparateForTypes(string holeCode) 
        {
             
        }

        public List<string> GetSeparator(string bigCode)
        {

            string separator = bigCode[..2];
            string remainingCode = bigCode[2..];
        }
    }
}
