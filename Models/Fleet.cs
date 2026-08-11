namespace ArmadaBackend.Models
{
    public class Fleet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Ships { get; set; } 
        public string Squadrons { get; set; }
        public string Objectives { get; set; }
    }

    /*
     * Id | FleetName |
     * one ship 000 + cards, one card 000 char - sum(6 ship with 6 cards) 108 char |
     * one squadron 000 - 60 char |
     * objectives sum(4*2), 8 char
     * total 108+57+6 = 171 char
    */

    //ai tanácsa:
    /*
     F1#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=101;D=102;N=103
     Jelentése:
     F1: formátumverzió;
     S: hajók;
     3[...]: a 3 hajókártya-verzió, a zárójelben az upgrade-verziók;
     ;: következő hajó;
     Q: squadronok;
     10*3: a 10-es squadronból három darab;
     35 és 42: egy-egy squadron;
     O: objective-ek;
     A, D, N, B: Assault, Defense, Navigation és BaseDefense - Ez opcionális

    F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10*3;35;42#O:A=101;D=102;N=103;

     
    Összefoglalva:
    400 pontos flotta: 5000 karakter
    4000 pontos flotta: 50 000 karakter
    */
}
