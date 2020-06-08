using Shop.Model;
using Shop.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{

    class Menu
    {
        public static Shop shop = new Shop();
        public static int orderId = 2;
        public static Order order;
        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("SHOP MANAGEMENT");
                Console.WriteLine("1. New Order");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Process");
                Console.WriteLine("8. Exit.");
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
                            NewOrder();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Show();
                            break;
                        }
                    case 3:
                        {

                            Console.Clear();
                            Search(out order);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();

                            break;
                        }

                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }

                }
            }
            while (selected != 8);
        }
        public static void NewOrder()
        {
            Order newOrder = new Order();
            orderId += 1;
            newOrder.orderId = orderId;
            newOrder.products = new List<Product>();

            string yn;
            do
            {
                Product product = new Product();
                Console.WriteLine("Input Name");
                product.nameProduct = Console.ReadLine();
                Console.WriteLine("Input Price");
                product.price = double.Parse(Console.ReadLine());
                Console.WriteLine("Input Amount");
                product.amount = int.Parse(Console.ReadLine());
                newOrder.products.Add(product);
                Console.WriteLine("Enter Continue Y/N (Y: Yes , N: No) ?? ");
                yn = Console.ReadLine();
            }
            while (yn.ToLower().Equals("Y".ToLower()));
            newOrder.custumer = new Custumer();
            Console.WriteLine("Input Your Name");
            newOrder.custumer.name = Console.ReadLine();
            Console.WriteLine("Input Your address");
            newOrder.custumer.address = Console.ReadLine();
            shop.shopService.NewOrder(newOrder);
        }
        public static void Sort()
        {
            ProductNameComparator od = new ProductNameComparator();
            shop.shopService.data.orders.Sort(od.Compare);
            /*            ProductComparator od2 = new ProductComparator();
                        shop.shopService.data.orders.Sort(od2.Compare);*/
            /* shop.shopService.data.orders.Sort(
                                  (order1, order2) =>
                                  {
                                      return order1.custumer.name.CompareTo(order2.custumer.name);
                                  });*/
        }
        public static void Show()
        {
            Sort();
            Console.WriteLine(shop.shopService.Show());
        }
        public static void Search(out Order order)
        {
            Console.WriteLine("Input KeyWord (Name or ID):");
            var keyword = Console.ReadLine();
            order = shop.shopService.Check(keyword);
            if (order != null)
            {
                Console.WriteLine(order);
            }
            else
            {
                var id = int.Parse(keyword);
                order = shop.shopService.CheckId(id);
                Console.WriteLine(order);
            }
            MenuProcess.Process();
        }
        public static void Pay()
        {
            order.time = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            order.status = "paid";
            shop.shopService.Pay(order);
        }
        public static void Update()
        {

            Console.WriteLine("Update Status (Y: Yes , N: No) ?? ");
            var yn = Console.ReadLine();
            if (yn.ToLower().Equals("Y".ToLower()))
            {
                Console.WriteLine("New Status:");
                order.status = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Update Product (Y: Yes , N: No) ?? ");
                yn = Console.ReadLine();
                if (yn.ToLower().Equals("Y".ToLower()))
                {
                    Console.WriteLine("Name Product:");
                    var nameproduct = Console.ReadLine();
                    foreach (var pt in order.products)
                    {
                        if (nameproduct.ToLower().Contains(pt.nameProduct.ToLower()))
                        {
                            Console.WriteLine("New Amout: ");
                            pt.amount = int.Parse(Console.ReadLine());
                            shop.shopService.Update();
                        }
                    }
                }
            }

        }
    }
}
