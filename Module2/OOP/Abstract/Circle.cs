using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public class Circle : Shape
    {
        public double Radius { get; set; } = 1.0;
        public Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            Radius = radius;
        }
        public double getArea() => Radius * Radius * Math.PI;

        public double getPerimeter() => 2 * Radius * Math.PI;

        public override string ToString()
        {
            return "A Circle with radius="
                    + Radius
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }
}
