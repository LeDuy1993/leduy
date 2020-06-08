using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Model
{
    class Order
    {
        public int orderId { get; set; }
        public string status { get; set; }
        public string time { get; set; }

        public Custumer custumer { get; set; }
        public List<Product> products { get; set; }
        private double CalculatorTotal()
        {
            var total = 0.0;
            foreach(var item in products)
            {
                total += item.total;
            }
            return total;
        }
        public double total => CalculatorTotal();


        public override string ToString()
        {
            string str = "";
            str = $"\n{str}OrderID:{orderId}\tStatus:{status}\t{time}\n{custumer.name}\t{custumer.address}\tTotal: {total}";
            foreach (var order in products)
            {
                str = $"{str}\n{order.ToString()}";
            }
         
            return str;
        }
    }
}
