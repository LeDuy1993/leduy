using Shop.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shop
{
    class ProductNameComparator : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return x.custumer.name.CompareTo(y.custumer.name);
        }
    }
}
