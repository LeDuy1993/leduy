using System;

namespace StudentStatic
{
    class Program
    {
        public static StudentFunction GetFunction = new StudentFunction();
        static void Main(string[] args)
        {
          CreateMenu();
        }

        public static void CreateMenu()
        {
            int option = 0;
            do
            {

                Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an option from 1 to 5:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Show Student");
                Console.WriteLine("4. Search Student");
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
                        Add();
                        break;
                    }
                case 2:
                    {
                        Remove();
                        break;
                    }
                case 3:
                    {
                        Show();


                        break;
                    }
                case 4:
                    {
                        Search();
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
        public static void Add()
        {
            StudentProduct sinhVien = new StudentProduct();
            Console.WriteLine("Enter Ten sinh vien:");
            sinhVien.Ten = Console.ReadLine();
            Console.WriteLine("Enter DOB sinh vien:");
            sinhVien.Dob = Console.ReadLine();
            Console.WriteLine("Enter Phone sinh vien:");
            sinhVien.Phone = Console.ReadLine();
            Console.WriteLine("Enter diem Toan:");
            sinhVien.Toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter diem Van:");
            sinhVien.Van = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter diem Anh:");
            sinhVien.Anh = double.Parse(Console.ReadLine());
            sinhVien.TinhAvg();
            GetFunction.Add(sinhVien);
        }
        public static void Remove()
        {
            Console.WriteLine("Enter ten sinh vien:");
            var ten = Console.ReadLine();
            GetFunction.RemoveSinhVien(ten);
        }
        public static void Search()
        {
            Console.WriteLine("Enter ten sinh vien:");
            var ten = Console.ReadLine();
            GetFunction.SearchSinhVien(ten);
        }
        public static void Show()
        {
            GetFunction.ShowSinhVien();
        }
    }
}
