using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_kethua_BT1
{
    internal class Circle
    {
        private double radius;
        private string color;

        public Circle(double radius = 1.0, string color = "green")
        {
            this.radius = radius;
            this.color = color;
        }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public double GetArea() { return radius * radius * (Math.PI); }
        public override string ToString()
        {
            return string.Format("Radius: {0}\nColor: {1}\nArea: {2}", radius, color, GetArea());
        }
    }
}
