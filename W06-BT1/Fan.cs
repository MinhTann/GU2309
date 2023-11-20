using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_TH3
{
    internal class Fan
    {
        private bool on;
        private string color;
        private int speed;
        private double radius;

        public Fan(bool on, string color, int speed, double radius)
        {
            this.on = on;
            this.color = color;
            this.speed = speed;
            this.radius = radius;
        }

        public bool On { get => on; set => on = value; }
        public string Color { get => color; set => color = value; }
        public int Speed { get => speed; set => speed = value; }
        public double Radius { get => radius; set => radius = value; }

        public override string ToString()
        {
            if (this.on) return string.Format("Speed: {0} | color: {1}, radius: {2}, Fan is on",speed, color,radius);
            return string.Format(" color: {0}, radius: {1}, Fan is off", color , radius);
        }
    }
   
}
