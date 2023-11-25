using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    internal class TicTacToe
    {
        int moveCounter = 0;
        Board gameboard = new Board();
        public TicTacToe()
        {

        }
        public void play()
        {
           
            Player playerx = new Player('X');
            //Player playero = new Player('O');
            Robot playero = new Robot('O'); //#

            Player currentPlayer = playerx; //xac dinh luot choi dau tien
            bool play = true;//thiet menu so 1-9 choi, va 10 chiu thua
            while(play)
            {
                gameboard.printBoard();
                Console.WriteLine("Player {0} enter the field in which you want to pur the number:", currentPlayer);
                try
                {
                    // xac dinh luat choi va so number
                    //int turn = currentPlayer.takeTurn(); //nhap du lieu
                    int turn = (moveCounter % 2 == 0) ? playerx.takeTurn() : playero.takeTurn(); //#
                    char c = (moveCounter % 2 == 0) ? playerx.Sign : playero.Sign; //#
                    //if (!gameboard.PutMark(currentPlayer.Sign, turn))
                    if(!gameboard.PutMark(c, turn)) //#
                        xulySai();
                    gameboard.clearBoard();
                    moveCounter++;

                    if(currentPlayer.checkWin(gameboard))
                    {
                        Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                        gameboard.printBoard();
                        play = false;
                    }
                    //kiem tra co hoa chua
                    else if(moveCounter == 9)
                    {
                       Console.WriteLine("Draw!");
                        gameboard.printBoard();
                        play = false;
                    }
                    // khong thang khong hoa ->
                    currentPlayer = (moveCounter % 2 == 0) ? playerx : playero;
                } catch (Exception e) 
                {
                    xulySai();
                   
                }
            }
        }
        public void play1()
        {
            Player playerx = new Player('X');
            Player playero = new Player('O');
            Player currentPlayer = playerx; //xac dinh luot choi dau tien
            bool play = true;//thiet menu so 1-9 choi, va 10 chiu thua
            while (play)
            {
                gameboard.printBoard();
                Console.WriteLine("Player {0} enter the field in which you want to pur the number:", currentPlayer);
                try
                {
                    // xac dinh luat choi va so number
                    //int turn = currentPlayer.takeTurn(); //nhap du lieu
                    int turn = (moveCounter % 2 == 0) ? playerx.takeTurn() : playero.takeTurn(); //#
                    char c = (moveCounter % 2 == 0) ? playerx.Sign : playero.Sign; //#
                    //if (!gameboard.PutMark(currentPlayer.Sign, turn))
                    if (!gameboard.PutMark(c, turn)) //#
                        xulySai();
                    gameboard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameboard))
                    {
                        Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                        gameboard.printBoard();
                        play = false;
                    }
                    //kiem tra co hoa chua
                    else if (moveCounter == 9)
                    {
                        Console.WriteLine("Draw!");
                        gameboard.printBoard();
                        play = false;
                    }
                    // khong thang khong hoa ->
                    currentPlayer = (moveCounter % 2 == 0) ? playerx : playero;
                }
                catch (Exception e)
                {
                    xulySai();

                }
            }
        }
        public void play2()
        {
            Robot playerx = new Robot('X');
            //Player playero = new Player('O');
            Robot playero = new Robot('O'); //#

            Player currentPlayer = playerx; //xac dinh luot choi dau tien
            bool play = true;//thiet menu so 1-9 choi, va 10 chiu thua
            while (play)
            {
                gameboard.printBoard();
                Console.WriteLine("Player {0} enter the field in which you want to pur the number:", currentPlayer);
                try
                {
                    // xac dinh luat choi va so number
                    //int turn = currentPlayer.takeTurn(); //nhap du lieu
                    int turn = (moveCounter % 2 == 0) ? playerx.takeTurn() : playero.takeTurn(); //#
                    char c = (moveCounter % 2 == 0) ? playerx.Sign : playero.Sign; //#
                    //if (!gameboard.PutMark(currentPlayer.Sign, turn))
                    if (!gameboard.PutMark(c, turn)) //#
                        xulySai();
                    gameboard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameboard))
                    {
                        Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                        gameboard.printBoard();
                        play = false;
                    }
                    //kiem tra co hoa chua
                    else if (moveCounter == 9)
                    {
                        Console.WriteLine("Draw!");
                        gameboard.printBoard();
                        play = false;
                    }
                    // khong thang khong hoa ->
                    currentPlayer = (moveCounter % 2 == 0) ? playerx : playero;
                }
                catch (Exception e)
                {
                    xulySai();

                }
            }
        }
        private void xulySai()
        {
            Console.WriteLine("Invalid input. Please enter number between 1-9!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
