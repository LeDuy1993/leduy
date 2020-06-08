using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Model
{
    class Custumer
    {
        public string name { get; set; }
        public string address { get; set; }
        public override string ToString()
        {
            return $"{name}\t{address}";
        }
    }
}
