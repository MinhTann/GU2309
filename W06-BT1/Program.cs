using W06_TH3;

namespace W06_BT1
{
    internal class Program
    {
        const int SLOW = 1, MEDIUM = 2, FAST = 3;
        static void Main(string[] args)
        {
            Fan f1 = new Fan(true, "blue", SLOW, 5);
            Fan f2 = new Fan(false, "red", FAST, 8);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
        }
    }
    
}