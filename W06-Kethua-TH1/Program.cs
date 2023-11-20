namespace W06_Kethua_TH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine(circle);

            circle = new Circle(3.5);

            Console.WriteLine(circle);

            circle = new Circle();

            Console.WriteLine(circle);
        }
    }
}