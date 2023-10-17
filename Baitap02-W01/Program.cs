using System;
using System.Text;
namespace Baitap01
{
    class Baitap
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            float a, b, c;
            Console.WriteLine("Nhập 3 số để so sánh: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if(a > b && a > c)
            {
                Console.WriteLine("{0} là số lớn nhất", a);
            } else if (b > c)
            {
                Console.WriteLine("{0} là số lớn nhất", b);
            }
            else
            {
                Console.WriteLine("{0} là số lớn nhất");
            } 
            Console.WriteLine(a);   

        }
    }
    
}