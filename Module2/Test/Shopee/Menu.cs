using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Shopee
{
    class Menu
    {
        public static Coffee coffee = new Coffee();
      

        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT");
                Console.WriteLine("1. AddOrder");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Cancel");
                Console.WriteLine("4. Pay");
                Console.WriteLine("5. Show");
                Console.WriteLine("6. Search");
                Console.WriteLine("7. Exit");

                Console.Write("Please select an option (1-7): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 7)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 7);

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
                            Cancel();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Pay();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            Show();
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
                            Environment.Exit(0);
                            break;
                        }

                }
            }
            while (selected != 7);
        }
        public static void Add()
        {
            
            Table tables = new Table();
            tables.StartTime = DateTime.Now.ToString();
            Console.WriteLine("Enter TableID:");
            tables.TableId = Console.ReadLine();
            if (!coffee.CheckOrder(tables.TableId))
            {
                    string yesno;
                do
                {
                    OrderDetail order = new OrderDetail();
                    Console.WriteLine("Enter name:");
                    order.Name = Console.ReadLine();
                    Console.WriteLine("Enter price:");
                    order.Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter count:");
                    order.Count = int.Parse(Console.ReadLine());
                    Console.Write("Continue (Y/N) ???: ");
                    yesno = Console.ReadLine();
                    tables.AddOrder(order);
                   
                }
                while (yesno.ToLower()=="Y".ToLower());
                coffee.NewOrder(tables);
            }
            else
            {
                Console.WriteLine("TableId Using !!");
            }
            coffee.Show();
          
        }
        public static void Update()
        {
            Table tables = new Table();
            Console.WriteLine("Enter TableID:");
            tables.TableId = Console.ReadLine();
            if (coffee.CheckOrder(tables.TableId))
            {
                OrderDetail order = new OrderDetail();
                Console.WriteLine("Enter name:");
                order.Name = Console.ReadLine();
                Console.WriteLine("Enter price:");
                order.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter count:");
                order.Count = int.Parse(Console.ReadLine());
                coffee.UpdateOrder(tables.TableId, order);
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }
           
            coffee.Show();
        }
        public static void Cancel()
        {
            Console.WriteLine("Enter TableID:");
            var tableId = Console.ReadLine();
            coffee.CencelOrder(tableId);
            coffee.Show();
        }
        public static void Pay()
        {

            Console.WriteLine("Enter TableID:");
            var tableId = Console.ReadLine();
            coffee.PayOrder(tableId);
            coffee.CencelOrder(tableId);
        }
        public static void Search()
        {

            Console.WriteLine("Enter TableID:");
            var tableId = Console.ReadLine();
            coffee.Search(tableId);

        }    
        public static void Show()
        {
            coffee.Show();
        }
    }
}
