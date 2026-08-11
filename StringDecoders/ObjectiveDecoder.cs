using ArmadaBackend.Models;
using ArmadaBackend.Data;
using ArmadaBackend.Enums;
using ArmadaBackend.Controllers;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.StringDecoders
// F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=10;D=40;N=99; 
{
    public class ObjectiveDecoder
        //kell minden controller osztályba egy int Id lista alapján kigyűjtő endpoint ami visszaadj az összes elemet, vagy egyesével meghívom a GetById()-t
    {
        public List<int> DecodedObjectives(string CodedObjectives)
        { 
            List<int> result = new List<int>();

        }
    }
}
