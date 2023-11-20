using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_Kethua_TH1
{
    internal class Shape
    {
        private string color;
        private bool filled;

        public Shape(string color = "green", bool filled = true)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }
        public override string ToString()
        {
            if (this.filled) return string.Format("A Shape with color of {0} and filled", color);
            return string.Format("A Shape with color of {0} and not filled", color);
        }
    }
}
