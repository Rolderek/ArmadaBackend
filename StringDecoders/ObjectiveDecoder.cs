using ArmadaBackend.Models;
using ArmadaBackend.Enums;
using ArmadaBackend.StringDecoders;

namespace ArmadaBackend.StringDecoders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=10;D=40;N=99;
// F1#a#S:3[]#Q:#O: -- minimum hossz = 16 karakter
{
    public class ObjectiveDecoder
    //kell minden controller osztályba egy int Id lista alapján kigyűjtő endpoint ami visszaadj az összes elemet, vagy egyesével meghívom a GetById()-t
    {
        public List<int> Objectives { get; set; } = new List<int>();

        public ObjectiveDecoder(string codedObjectives) 
        {
            Objectives = DecodedObjectives(codedObjectives);
        }
 
        public List<int> DecodedObjectives(string codedObjectives)
        {
            List<int> result = new List<int>();
            if (codedObjectives.Length <= 2)
            {
                return result; //abban az esetben ha nincs még objektív elmentve, kérdés erre kell e készülni?
            }
            string trimmedObjectives = codedObjectives[2..];
            string[] parts1 = trimmedObjectives.Split(";");
            string[] firstTypeAndId = parts1[0].Split("=");
            string[] secondTypeAndId = parts1[0].Split("=");
            string[] thirdTypeAndId = parts1[0].Split("=");
            result.Add(int.Parse(firstTypeAndId[1]));
            result.Add(int.Parse(secondTypeAndId[1]));
            result.Add(int.Parse(thirdTypeAndId[1]));
            return result;
        }
    }
}
