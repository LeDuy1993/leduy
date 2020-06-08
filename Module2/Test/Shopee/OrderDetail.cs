using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Shopee
{
    class OrderDetail
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public long Count { get; set; }
        public long Total => CalculatorTotal();
        public long CalculatorTotal() {
            return Count * Price;
        }
        public  string Show()
        {
            return $"Name: {Name}\t" +
                   $"Price: {Price}\t" +
                    $"Count: {Count}\t" +
                    $"Total: {Total}\n";
        }

    }
}
