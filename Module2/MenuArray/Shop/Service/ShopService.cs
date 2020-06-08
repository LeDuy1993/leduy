using Microsoft.VisualBasic;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Service
{
    class ShopService
    {
        public Data data;
        private string path;
        private string dataCartName;
        private string fullPath => @$"{path}\{dataCartName}";

        public ShopService(string _path, string _dataCartName)
        {
            data = new Data()
            {
                orders = new List<Order>()
            };
            path = _path;
            dataCartName = _dataCartName;
            ReadWriteData<Data>.ReadData(fullPath, out data);
        }
        public void Sort(ProductNameComparator nameComparator)
        {

        }
        public string Show()
        {
            try
            {
                string str = "";
                foreach (var order in data.orders)
                {
                    if (order.status == "received")
                    {
                        str = $"{str}\n{order.ToString()}";
                    }
                }
                return str;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool NewOrder(Order newOrder)
        {
            try
            {
                newOrder.status = "received";
                data.orders.Add(newOrder);
                ReadWriteData<Data>.WriteData(fullPath, data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Order CheckId(int orderId)
        {
            try
            {
                foreach (var order in data.orders)
                {
                    if (orderId.Equals(order.orderId) && order.status == "received")
                    {
                        return order;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Order Check(string keyword)
        {
            keyword = keyword.ToLower();
            try
            {
                foreach (var order in data.orders)
                {
                    if (keyword.Contains(order.custumer.name.ToLower()) && order.status == "received" || keyword.Contains(order.custumer.address.ToLower()) && order.status == "received")
                    {
                        return order;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void Pay(Order order)
        {    
            string billName = $"bill_{order.orderId}_{DateTime.Now.ToString("ddMMyyyyhhmmtt")}.json";
            string fullBill = @$"{path}\{billName}";
            ReadWriteData<Order>.WriteData(fullBill, order);
        }
        public bool Update()
        {
            try
            {
                ReadWriteData<Data>.WriteData(fullPath, data);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
