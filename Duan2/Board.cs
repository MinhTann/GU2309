using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    internal class Board
    {
        public const int BOARD_SIZE = 3;//kich thuoc ban co 3x3
        public Cell[,] board; // ban co 9 o
        public Board()
        {
            board = new Cell[BOARD_SIZE, BOARD_SIZE];
            for(int i = 0; i < BOARD_SIZE; i++)
            {
                for(int j = 0; j < BOARD_SIZE; j++)
                    board[i, j] = new Cell();// mac dinh tao ban co voi o rong
            }
        }
        public void printBoard()
        {
            int fieldnumber = 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******");
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                Console.Write("*");
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (board[i, j].isEmpty())
                    {
                        Console.Write(fieldnumber);
                        Console.ForegroundColor = ConsoleColor.Blue;
                    } else
                    {
                        char c = (char)board[i, j].Fieldstate;
                        if (c == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            
                        }
                        else

                            Console.ForegroundColor = ConsoleColor.Red;
                       
                        Console.Write(c);
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    fieldnumber++;// tang gia tri o o hien thi
                    if (j < BOARD_SIZE - 1) Console.Write("*");
                }
                Console.WriteLine("*");
                   
            }
            Console.WriteLine("*******");
        }
        public bool PutMark(char c, int fieldNumber)
        {
            int x = (fieldNumber - 1) / BOARD_SIZE;
            int y = (fieldNumber - 1) % BOARD_SIZE;
            if (board[x, y].isEmpty())
            {
                board[x, y].markField(c);//o rong moi dien duoc
                return true;
            }
            //o khac rong(dang co X va Y)
            Console.WriteLine("This place is taken. Select the another field");
            return false; 
        }
        public void clearBoard()
        {
            Console.Clear();
        }

    }
}
