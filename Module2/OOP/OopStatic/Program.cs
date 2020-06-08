using System;

namespace OopStatic
{
    class Program
    {
        public static ClassFunction GetFunction = new ClassFunction();
        static void Main(string[] args)
        {
            Product product = new Product();
            GetFunction.Add(product);
            GetFunction.ShowProductList();

            CreateMenu();
          

        }

        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                
                Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an option from 1 to 5:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Show Product");
                Console.WriteLine("4. Search Product");
                Console.WriteLine("5. Exit");
                Console.Write("option: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 5 || option < 1);

            Process(option);
        }

        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        AddProduct();
                        break;
                    }
                case 2:
                    {
                        DelProduct();
                        break;
                    }
                case 3:
                    {
                        ShowProduct();
                        break;
                    }
                case 4:
                    {
                        SearchProct();
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }

        public static void AddProduct()
        {
            Product product = new Product();
            Console.Write("Ten: ");
            product.Ten = Console.ReadLine();
            Console.Write("Thong tin: ");
            product.ThongTin = Console.ReadLine();
            Console.Write("Gia: ");
            product.Gia = double.Parse(Console.ReadLine());
            Console.WriteLine("Danh Gia");
            for (int i = 0; i < product.DanhGia.Length; i++)
            {
                Console.Write($"Rate {i + 1} = ");
                product.DanhGia[i] = int.Parse(Console.ReadLine());
            }
            product.TinhAvg();
            GetFunction.Add(product);
        }
        public static void DelProduct()
        {
            Console.WriteLine("Enter ten san pham:");
            var ten = Console.ReadLine();
            GetFunction.Del(ten);
        }
        public static void SearchProct()
        {
            Console.WriteLine("Enter ten search:");
            var ten = Console.ReadLine();
            GetFunction.Search(ten);
        }

        public static void ShowProduct()
        {
           
            GetFunction.ShowProductList();
        }

     
    }
}
