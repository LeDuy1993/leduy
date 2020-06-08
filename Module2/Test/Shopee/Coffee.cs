using System;
using System.Collections.Generic;
using System.Text;

namespace Shopee
{
    class Coffee
    {
        public Dictionary<string, Table> Tables = new Dictionary<string, Table>();

        public void NewOrder(Table table)
        {
            Tables.Add(table.TableId, table);
        }
        public void Show()
        {
            foreach (var item in Tables.Values)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }
        public void UpdateOrder(string tableId, OrderDetail orderDetail)
        {
            orderDetail.Name = orderDetail.Name.ToLower();
            bool istrue = false;
            foreach (OrderDetail item in Tables[tableId].OrderDetails)
            {
                if (item.Name.ToLower().Contains(orderDetail.Name))
                {
                    item.Count += orderDetail.Count;
                    istrue = true;
                    break;
                }
            }
            if (!istrue)
            {
                Tables[tableId].AddOrder(orderDetail);
            }
        }
        public bool CheckOrder(string tableId)
        {
            foreach (Table item in Tables.Values)
            {
                if (item.TableId.ToLower().Equals(tableId.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public void CencelOrder(string tableId)
        {
            if (CheckOrder(tableId))
            {
                Tables.Remove(tableId);
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }
        }
        public void PayOrder(string tableId)
        {
            if (CheckOrder(tableId))
            {
                Tables[tableId].EndTime = DateTime.Now.ToString();
                Console.WriteLine(Tables[tableId].ShowInfo() + $"SumTotal: {Tables[tableId].SumTotal}");
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }
        }
        public void Search(string tableId)
        {
            if (CheckOrder(tableId))
            {
                Console.WriteLine(Tables[tableId].ShowInfo());
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }
        }
    }
}
