using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Rectangle : Shape
    {
        public Rectangle() { }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(double width, double height, string color, bool filled) : base(color, filled)
        {
            Width = width;
            Height = height;
        }
        public virtual double Width { get; set; } = 1.0;
        public virtual double Height { get; set; } = 1.0;

        public double P() => (Width + Height) * 2;
        public double S() => Width * Height;
  
        public override string ToString() =>
                     "A Rectangle with width="
                    + Width
                    + " and length="
                    + Height
                    + ", which is a subclass of "
                    + base.ToString();
    }
}
