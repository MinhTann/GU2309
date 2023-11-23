using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    internal class Robot : Player
    {
        public Robot(char sign = 'O') : base(sign) 
        {

        }
        public int takeTurn()
        {
            Random rd = new Random();
            return rd.Next(1,9);
        }
    }
}
