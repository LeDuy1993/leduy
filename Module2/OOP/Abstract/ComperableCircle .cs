using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public class ComperableCircle : Circle, IComparable<ComperableCircle>
    {

        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComperableCircle o)
        {
            if (Radius > o.Radius) return 1;
            else if (Radius < o.Radius) return -1;
            else return 1;
        }
    }
}
