using System;
using System.Collections.Generic;
using System.Text;

namespace Shopee
{
    class Table : ITable
    {
        public List<OrderDetail> OrderDetails = new List<OrderDetail>();
        public string TableId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long SumTotal => Pay();

        public void AddOrder(OrderDetail item)
        {
            OrderDetails.Add(item);
        }
        public long Pay()
        {
            long sumTotal = 0;
            foreach (OrderDetail item in OrderDetails)
            {

                sumTotal += item.Total;
            }
            return sumTotal;
        }
        public string ShowOder()
        {
            string show = "";
            foreach (OrderDetail item in OrderDetails)
            {
                show += item.Show();
            }
            return show;

        }

        public string ShowInfo()
        {
            return $"TableId: {TableId}\t" +
                   $"StartTime: {StartTime}\t" +
                   $"EndTime: {EndTime}\n" +
                    $"{ShowOder()}" ;
        }
    }
}
