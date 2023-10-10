using System;
namespace Thuchanh3
{
    class baitap
    {



        static void Main(string[] args)
        {
            Random rd = new Random();
            int Num = rd.Next(0, 9);
            int a;
            Console.WriteLine("Nhap 1 so tu 0 den 9: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("So ngau nhien: " + Num);
            Console.WriteLine("So ban da nhap: " + a);
            if (a == Num)
            {
                Console.WriteLine("Chuc mung ban da trung thuong");

            }
            else
            {
                Console.WriteLine("Chuc ban may man lan sau");
            }
        }


    }
}
