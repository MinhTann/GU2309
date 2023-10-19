using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03
{
    internal class TH3_W03
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1.Draw the triangle");
            Console.WriteLine("3.Draw the rectangle");
            Console.WriteLine("0.Exit");
            Console.WriteLine("Enter your choice:");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    for(int i = 1; i < 4;i++)
                    {
                        Console.WriteLine("");
                        for (int j = 1; j < 10; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 5; i++)
                    {
                        
                        for (int j = 1; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                        
                     break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
    }
}
