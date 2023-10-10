using System;
using System.Text;
namespace MinhTan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Good Evening");
            Console.WriteLine("Huỳnh Minh Tân");
            Console.WriteLine(a++ + ++b);
        }
    }
}
