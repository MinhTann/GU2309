using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    internal class Player
    {
        char sign; // ky hieu nguoi X va O

        public Player(char sign = 'X')
        {
            this.sign = sign;
        }

        public char Sign { get => sign; set => sign = value; }

        public int takeTurn() // nhap o vi tri nguoi choi
        {
            int fieldnumber = int.Parse(Console.ReadLine());
            return fieldnumber;
        }
        public bool checkSign(FIELD c1, FIELD c2, FIELD c3)
        {
            // 3 o cung 1 ky tu khac rong X hoac O (chac chan khac rong)
            return (c1 == c2) && (c1 == c3) && c1 != FIELD.FLD_EMPTY;
        }
        public bool checkRowsForWin(Board gameboard)
        {
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkSign(gameboard.board[0, i].Fieldstate, gameboard.board[1, i].Fieldstate, gameboard.board[2, i].Fieldstate))
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkColumnForWin(Board gameboard)
        {
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkSign(gameboard.board[i, 0].Fieldstate, gameboard.board[i, 1].Fieldstate, gameboard.board[i, 2].Fieldstate))
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkDiagonalForWin(Board gameboard)
        {
            bool flag = false;
            if (checkSign(gameboard.board[0, 0].Fieldstate, gameboard.board[1, 1].Fieldstate,gameboard.board[2, 2].Fieldstate))
                flag = true;
            if (checkSign(gameboard.board[2, 0].Fieldstate, gameboard.board[1, 1].Fieldstate, gameboard.board[0, 2].Fieldstate))
                flag = true;

            return flag;
        }
        public bool checkWin(Board gameboard)
        {
            return (checkColumnForWin(gameboard) || checkDiagonalForWin(gameboard)) || checkRowsForWin(gameboard);
        }
    }
}
