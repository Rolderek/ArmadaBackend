using ArmadaBackend.Models;

namespace ArmadaBackend.StringBotanBuilders
//Ez fogja a végleges szöveget összerakni, az elválasztókkal és itt lehet majd verziót állítani, írni.
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=10;D=40;N=99;
// F1#a#S:3[]#Q:#O: -- minimum hossz = 16 karakter
{
    public class BuilderOfBuilders
    {
        public string Starter { get; } = "F1";
        public string FleetString { get; set; } = string.Empty;

        public void MakingFleetStringV1(string fleetName, string shipString, string squadronString, string objectiveString)
        {
            FleetString = $"{Starter}#{fleetName}#{shipString}#{squadronString}#{objectiveString}";
        }




        public bool IsThereAnyStringValue()
        {
            return FleetString is null ? false : true;
        }
    }

    // F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=101;D=102;N=103;
}
