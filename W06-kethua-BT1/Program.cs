namespace W06_kethua_BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylingder c = new Cylingder(1.3, 2.2, "Red");
            Console.WriteLine(c.GetVolume());
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}