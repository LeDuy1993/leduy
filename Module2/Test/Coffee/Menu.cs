using System;
using System.Collections.Generic;


namespace Coffee
{
    class Menu
    {
        public static CoffeeManagement management = new CoffeeManagement();

        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Remove Drink In Table.");
                Console.WriteLine("4. Remove Table.");
                Console.WriteLine("5. Pay");
                Console.WriteLine("6. Search");
                Console.WriteLine("7. Sum bill of day");
                Console.WriteLine("8. Exit");

                Console.Write("Please select an option (1-7): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 8)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 8);

        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                CreateMenu(out selected);
                switch (selected)
                {
                    case 1:
                        {
                            Console.Clear();
                            Add();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Update();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            RemoveDrinkInTable();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            RemoveTable();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Pay();
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();
                            Search();
                            break;
                        }

                    case 7:
                        {
                            Console.Clear();
                            ShowBillOfDay();
                            break;
                        }
                    case 8:
                        {
                            Environment.Exit(0);
                            break;
                        }

                }
            }
            while (selected != 8);
        }
        public static void Add()
        {
            Table table = new Table();
            Console.WriteLine("Nhập Table ID: ");
            table.TableID = Console.ReadLine();
            List<Order> order = new List<Order>();
            string yn;
            if (management.CheckTableID(table.TableID) == null)
            {
                do
                {

                    Console.WriteLine("Nhập Name Drink: ");
                    var nameDrink = Console.ReadLine();
                    Console.WriteLine("Nhập Price: ");
                    var price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Count: ");
                    var count = long.Parse(Console.ReadLine());
                    bool istrue = false;
                    foreach (Order item in order)
                    {
                        if (nameDrink.ToLower().Equals(item.NameDrink.ToLower()))
                        {
                            item.Count += count;
                            istrue = true;
                            break;
                        }
                    }
                    if (!istrue)
                    {
                        order.Add(new Order()
                        {
                            NameDrink = nameDrink,
                            Price = price,
                            Count = count
                        });
                    }
                    Console.WriteLine("Enter Continue Y/N (Y: Yes , N: No) ?? ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
                management.NewOrder(new Table()
                {
                    TableID = table.TableID,
                    StarTime = DateTime.Now.ToString(),
                    OrderList = order
                });
            }
            else
            {
                Console.WriteLine("Table is using !");
            }

            management.Show();

        }
        public static void Update()
        {
            Table table = new Table();
            Console.WriteLine("Nhập Table ID: ");
            table.TableID = Console.ReadLine();
            if (management.CheckTableID(table.TableID) != null)
            {
                string yn;
                do
                {
                    Order order = new Order();
                    Console.WriteLine("Nhập Name Drink: ");
                    order.NameDrink = Console.ReadLine();
                    Console.WriteLine("Nhập Price: ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Count: ");
                    order.Count = long.Parse(Console.ReadLine());
                    management.Update(table.TableID, order);
                    management.Show();
                    Console.WriteLine("Enter Continue Update Y/N (Y: Yes , N: No) ?? ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
            }
            else
            {
                Console.WriteLine("Not found !!");
            }
        }

        public static void RemoveDrinkInTable()
        {
            Console.WriteLine("Nhập Table ID: ");
            var tableId = Console.ReadLine();
            if (management.CheckTableID(tableId) != null)
            {
                string yn;
                do
                {
                    Console.WriteLine("Nhập Name Drink: ");
                    var nameDrink = Console.ReadLine();
                    Console.WriteLine("Nhập Count: ");
                    var count = long.Parse(Console.ReadLine());
                    management.RemoveDrink(tableId, nameDrink, count);
                    management.Show();
                    Console.WriteLine("Enter Continue Update Y/N (Y: Yes , N: No) ?? ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
            }

        }
        public static void RemoveTable()
        {
            Console.WriteLine("Nhập Table ID: ");
            string tableId = Console.ReadLine();
            management.RemoveTable(tableId);
            management.Show();

        }
        public static void Show()
        {
            management.Show();
        }
        public static void Pay()
        {
            Console.WriteLine("Nhập Table ID: ");
            string tableId = Console.ReadLine();
            Table item = management.CheckTableID(tableId);
            if (item != null)
            {
                Console.WriteLine("Nhập Cashier: ");
                item.Cashier = Console.ReadLine();
                item.EndTime = DateTime.Now.ToString();
            }
            management.Pay(tableId);
            management.NewBill(item);

            management.RemoveTable(tableId);
        }
        public static void Search()
        {
            Console.WriteLine("Nhập Table ID: ");
            string tableId = Console.ReadLine();
            management.Search(tableId);

        }
        public static void ShowBillOfDay()
        {
            management.ShowBill();
        }
    }
}
