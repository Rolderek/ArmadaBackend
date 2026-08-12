using ArmadaBackend.Models;
using System.Text;


namespace ArmadaBackend.StringBotanBuilders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=10;D=40;N=99;
// F1#TesztNév#S:#Q:#O: - üres lista példa
{
    public class ObjectiveBuilder
    {
        public string Starter { get; } = "O:";

        public string ObjectivesString { get; set; } = string.Empty;

        public ObjectiveBuilder(List<int> oIds)
        {
            MakingObjectivesString(oIds);
        }

        public void MakingObjectivesString(List<int> oIds)
        {
            StringBuilder builder = new StringBuilder(Starter);
            //ez a lista elvileg fixen 3 elemű, ha változik,a akkor át kell írni
            int A = oIds[0];
            int D = oIds[1];
            int N = oIds[2];
            builder.Append($"A={A};D={D};N={N}");
            this.ObjectivesString = builder.ToString();
        }

        public bool IsThereAnyObjective()
        {
            return ObjectivesString is null ? false : true;
        }
    }
}
    
