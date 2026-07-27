namespace ArmadaBackend.Models
{
    //egy felszerelt hajót reprezentál a listában
    public class FleetElement
    {
        public int Id { get; set; }
        public Ship Ship { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
        public int Point => (Ship?.Point ?? 0) + Cards.Sum(c => c.Point); //összérték számítással

        //kapcsolatok:
        public int FleetId { get; set; }
        public Fleet? Fleet { get; set; }

    }
}
