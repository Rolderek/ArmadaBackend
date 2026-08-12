using ArmadaBackend.Models;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ArmadaBackend.StringBotanBuilders
//a szent string: F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10;10;10;35;42#O:A=101;D=102;N=103;
{
    public class SquadronBuilder
    {
        public string Starter { get; } = "Q:";

        public string SquadronString { get; set; } = string.Empty;

        public SquadronBuilder(List<int> list)
        {
            MakingSquadronString(list);
        }

        public void MakingSquadronString(List<int> sIds)
        {
            StringBuilder builder = new StringBuilder(Starter); 
            for (int i = 0; i < sIds.Count; i++)
            {
                builder.Append(sIds[i]);
                if (i < sIds.Count - 1)
                {
                    builder.Append(';'); 
                }
            }
            this.SquadronString = builder.ToString();
        }
     


        /*
        LINQ parancs a squadron card-ok id-jének kinyerésére:
        List<int> squadronIds = selectedSquadrons.Select(squadron => squadron.Id).ToList();
        */

        /*
        //2 a-wing, 2 defender és egy Vader defender ász:
        List<int> squadrons = new List<int>() { 1, 1, 61, 61, 62 };
        SquadronBuilder squadBuilder = new SquadronBuilder();
        squadBuilder.MakingSquadronString(squadrons);
        Console.WriteLine($"{squadBuilder.SquadronString}
        */
    }


}
