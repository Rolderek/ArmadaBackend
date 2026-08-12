using System.Text;
using ArmadaBackend.Enums;
using ArmadaBackend.Models;

namespace ArmadaBackend.StringDecoders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=10;D=40;N=99;
// F1#a#S:3[]#Q:#O: -- minimum hossz = 16 karakter
//szét szedi a nagy stringet typusonkénti darabokra:

{
    public class SeparateForTypes
    {
        public string Version { get; set; }
        public string Name { get; set; }
        public string Ships { get; set; }
        public string Squadrons { get; set; }
        public string Objectives { get; set; }

        public SeparateForTypes(string fleetCode)
        {
            List<string> values = GetPartsForConstructor(fleetCode);
            Version = values[0];
            Name = values[1];
            Ships = values[2];
            Squadrons = values[3];
            Objectives = values[4];
        }

        // A verzió határozza meg a szeparátort.
        public List<string> GetPartsForConstructor(string? fleetCode)
        {
            if (IsNull(fleetCode) || !NotTooShort(fleetCode!))
            {
                throw new ArgumentException(
                    "A flotta nem lehet null vagy túl rövid!",
                    nameof(fleetCode));
            }
            List<string> result = new List<string>();
            string actualSeparator = IsVersion(fleetCode[..2]);
            string[] parts = fleetCode.Split(actualSeparator);
            foreach(string p in parts)
            {
                result.Add(p);
            }
            return result;
        }

        public bool IsNull(string? fleet)
        {
            return fleet is null;
        }

        public bool NotTooShort(string fleet)
        {
            return fleet.Length >= 16;
        }

        public string IsVersion(string s)
        {
            string result = "";
            char r = '0';
            if (!Enum.TryParse<CodeVersion>(s, ignoreCase: true, out CodeVersion version))
            {
                throw new ArgumentException($"Ismeretlen kódverzió: {s}");
            }
            r = (char)version;
            result = r.ToString();
            return result;
        }
        

        


    }
}
