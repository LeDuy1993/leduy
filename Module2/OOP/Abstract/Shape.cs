using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
   public class Shape
    {
        public string Color { set; get; } = "green";
        public bool Filled { set; get; } = true;
        public Shape()
        {
        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public override string ToString()
        {
            return "A Shape with color of "
                    + Color
                    + " and "
                    + (Filled ? "filled" : "not filled");
        }
    }
}
