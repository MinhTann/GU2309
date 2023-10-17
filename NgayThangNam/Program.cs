
using System;
using System.Text;
namespace Baitap05
{
    class Baitap5
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            Console.Write("Nhập tháng mà bạn muốn (1-12): ");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Có 31 ngày");
                    break;
                case 2:
                    Console.WriteLine("Có 28 ngày");
                    break;
                case 3:
                    Console.WriteLine("Có 31 ngày");
                    break;
                case 4:
                    Console.WriteLine("Có 30 ngày");
                    break;
                case 5:
                    Console.WriteLine("Có 31 ngày");
                    break;
                case 6:
                    Console.WriteLine("Có 30 ngày");
                    break;
                case 7:
                    Console.WriteLine("Có 31 ngày");
                    break;
                case 8:
                    Console.WriteLine("Có 30 ngày");
                    break;
                case 9:
                    Console.WriteLine("Có 31 ngày");
                    break;
                case 10:
                    Console.WriteLine("Có 30 ngày");
                    break;
                case 11:
                    Console.WriteLine("Có 31 ngày");
                    break;
                case 12:
                    Console.WriteLine("Có 30 ngày");
                    break;
                default: Console.WriteLine("Không hợp lệ"); break;
            }
        }

    }
}