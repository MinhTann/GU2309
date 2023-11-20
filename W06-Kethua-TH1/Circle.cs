using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_Kethua_TH1
{
    internal class Circle : Shape
    {

        private double radius = 1.0;

        public Circle()

        {

        }

        public Circle(double radius)

        {

            this.radius = radius;

        }

        public Circle(double radius, String color, bool filled) : base(color, filled)

        {

            this.radius = radius;

        }

        public double GetRadius()

        {

            return radius;

        }

        public void SetRadius(double radius)

        {

            this.radius = radius;

        }

        public double GetArea()

        {

            return radius * radius * Math.PI;

        }

        public double GetPerimeter()

        {

            return 2 * radius * Math.PI;

        }

        public override String ToString()

        {

            return string.Format("A Circle with radius = {0}", radius);

        }

    }
}

