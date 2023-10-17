using System;
namespace BTap
{
    class TH01
    {
        static void Main(string[] args)
        {
            float width, height;
            Console.WriteLine("Nhap chieu dai va chieu rong");
            width = float.Parse(Console.ReadLine());
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine(area);
        }
    }
}