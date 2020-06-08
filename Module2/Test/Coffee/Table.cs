using System.Collections.Generic;

namespace Coffee
{
    class Table : ITable

    {
        public string TableID { get; set; }
        public string Cashier { get; set; }
        public string StarTime { get; set; }
        public string EndTime { get; set; }

        public List<Order> OrderList = new List<Order>();
        public long SumTotal => Pay();
    
        public string ShowOrderList()
        {
            string list = "";
            foreach (Order item in OrderList)
            {
                list += item.ToString();
            }
            return list;
        }

        public long Pay()
        {
            long pay = 0;
            foreach (Order item in OrderList)
            {
                pay += item.Total;
            }
            return pay;
        }

        public string Show()
        {

            return $"Table ID: {TableID}\n" +
                    $"Star Time: {StarTime}\t" +
                    $"End Time: {EndTime}\n" +
                    $"{ShowOrderList()}\n";
            /* $"SumTotal: {SumTotal}\t"+
             $"Cashier: {Cashier}";*/
        }
        public string ShowPay()
        {
            return $"Table ID: {TableID}\n" +
                    $"Star Time: {StarTime}\t" +
                    $"End Time: {EndTime}\n\n" +
                    $"{ShowOrderList()}\n\n" +
                    $"SumTotal: {SumTotal}\t" +
                    $"Cashier: {Cashier}";
        }
        public string ShowBill()
        {
            return $"Table ID: {TableID}\n" +
                    $"Star Time: {StarTime}\t" +
                    $"End Time: {EndTime}\n" +
                    $"SumTotal: {SumTotal}\t" +
                    $"Cashier: {Cashier}";
        }
    }
}
