using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Circle : Shape
    {
     

        public Circle()
        {
        }
        public Circle(double radius)

        {
            Radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)

        {
            Radius = radius;
        }
        public double Radius { get; set; } = 1.0;
        public double Area() => Radius * Radius * Math.PI;
        public double Perimeter() => 2 * Radius * Math.PI;
        public override string ToString() =>
                    "A Circle with radius="
                    + Radius
                    + ", which is a subclass of "
                    + base.ToString();
    }
}
