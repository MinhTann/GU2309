using System;
namespace BT
{
   class TH01
    {
        static void Main(string[] args)
        {
            float width, height;
            Console.Write("Nhap chieu dai va chieu rong:");
            width = float.Parse(Console.ReadLine());
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine(area);
        }
    }
}