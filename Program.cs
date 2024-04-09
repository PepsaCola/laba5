namespace laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carrier carrier = new Carrier("USS Gerald R. Ford (CVN-78)", 100000, 5, 5000);
            CruiseLiner cruiseLiner = new CruiseLiner("Harmony of the Seas", 226963, 6000);
            Ferry ferry = new Ferry("Stena Germanica", 2000, 900);
            Frigate frigate = new Frigate("FREMM-класу \"Aquitaine\"", 6000, 2, 150);

            carrier.Write();
            cruiseLiner.Write();
            ferry.Write();
            frigate.Write();
            
        }
    }
}
