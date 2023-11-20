using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_kethua_BT1
{
    internal class Cylingder : Circle
    {
        private double height;

        public Cylingder(double height, double radius, string color) : base(radius, color)
        {
            this.height = height;
        }
        public double Height { get => height; set => this.height = value; }
        public double GetVolume() { return height * GetArea(); }
        public override string ToString()
        {
            return base.ToString() + string.Format("\nVolume: {0}", GetVolume());
        }
    }
}
