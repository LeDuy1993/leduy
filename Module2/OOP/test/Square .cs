using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Square : Rectangle
    {
        public Square()

        {

        }
        public Square(double side) : base(side, side)

        {
            Side = side;
        }
        public Square(double side, String color, bool filled) : base(side, side, color, filled)

        {
            Side = side;
        }
        public double Side { get; set; } = 1.0;
        public override double Width => Side;
        public override double Height => Side;
        public override String ToString()

        {

            return "A Square with side="

                    + Side

                    + ", which is a subclass of "

                    + base.ToString();

        }

    }
}