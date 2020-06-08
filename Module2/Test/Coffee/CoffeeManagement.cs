using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Coffee
{
    class CoffeeManagement
    {
        public Dictionary<string, Table> tables = new Dictionary<string, Table>();
        public Dictionary<string, Table> billS = new Dictionary<string, Table>();
        public void NewOrder(Table table)
        {
            tables.Add(table.TableID, table);
        }
        public void Show()
        {
            foreach (Table item in tables.Values)
            {
                Console.WriteLine(item.Show());
            }
        }
        public Table CheckTableID(string tableId)
        {
            foreach (Table item in tables.Values)
            {
                if (item.TableID.ToUpper().Equals(tableId.ToUpper()))
                {
                    return item;
                }
            }
            return null;
        }
        public void Update(string tableId, Order order)
        {
            bool istrue = false;
            foreach (Order item in tables[tableId].OrderList)
            {
                if (item.NameDrink.ToLower().Contains(order.NameDrink.ToLower()))
                {
                    item.Count += order.Count;
                    istrue = true;
                    break;
                }
            }
            if (!istrue)
            {
                tables[tableId].OrderList.Add(order);
            }
        }
        public void RemoveTable(string tableId)
        {
            Table item = CheckTableID(tableId);
            if (item != null)
            {
                tables.Remove(item.TableID);
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }
        }
        public void RemoveDrink(string tableId, string name, long count)
        {
            foreach (Order item in tables[tableId].OrderList)
            {
                if (item.NameDrink.ToLower().Equals(name.ToLower()))
                {
                    if (item.Count > count)
                    {
                        item.Count -= count;
                    }
                }
            }
        }
        public void Pay(string tableId)
        {
            Console.WriteLine(tables[tableId].ShowPay());
            /* Phần in bill ra */
            string path = @"E:\codegym\Module2\Test\Coffee";
            string fileName = "Bill.txt";
            using (StreamWriter sw = File.CreateText(($@"{path}\{fileName}")))
            {
                sw.WriteLine(tables[tableId].ShowPay());
            }
            fileName = $"Bill_{tableId}.json";
            string pathjson = @$"E:\codegym\Module2\Test\Coffee\Bill_Json\{fileName}";
            JsonCoffee.StreamWriterTable(pathjson, tables[tableId]);
        }
        public void Search(string tableId)
        {
            Table item = CheckTableID(tableId);
            if (item != null)
            {
                Console.WriteLine(item.Show());
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }

        }
        public void NewBill(Table table)
        {
            billS.Add(table.TableID, table);
        }
        public void ShowBill()
        {
            foreach (Table item in billS.Values)
            {
                Console.WriteLine(item.ShowBill());
                string pathjson = @$"E:\codegym\Module2\Test\Coffee\Bill_Json\AllBill.json";
                JsonCoffee.StreamWriteAllBill(pathjson, item);
            }

        }
    }
}
