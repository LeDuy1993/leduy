using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Model
{
    class Product
    {
        public string nameProduct { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public double total => price * amount;
        public override string ToString()
        {
            return $"{nameProduct}\t{price}\t{amount}\t{total}";
        }
    }
}
