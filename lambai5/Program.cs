
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
            int a, b, c;
            Console.WriteLine("Nhập 2 số: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy chọn phép tính: \n1: + \n2: -\n3: x\n4: :");
            c = int.Parse(Console.ReadLine());
            if(c == 1)
            {
                Console.WriteLine("Kết quả: {0}", a+b);
            }
            else if (c == 2)
            {
                Console.WriteLine("Kết quả: {0}", a-b);
            }
            else if (c == 3)
            {
                Console.WriteLine("Kết quả: {0}", a*b);
            }
            else
            {
                Console.WriteLine("Kết quả: {0}", a%b);
            }



        }
    }

}