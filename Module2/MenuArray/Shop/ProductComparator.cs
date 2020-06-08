using Shop.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shop
{
    class ProductComparator : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            if (x.orderId > y.orderId) return 1;
            else if (x.orderId > y.orderId) return -1;
            else return 0;
        }
    }
}
