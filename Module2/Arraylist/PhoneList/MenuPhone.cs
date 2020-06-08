using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneList
{
     class MenuPhone
    {

        public static PhoneBook phoneBook = new PhoneBook();
        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine(HeoMe.Title);
                Console.WriteLine(HeoMe.Insert);
                Console.WriteLine(HeoMe.Remove);
                Console.WriteLine(HeoMe.Update);
                Console.WriteLine(HeoMe.Search);
                Console.WriteLine(HeoMe.Sort);
                Console.WriteLine(HeoMe.Exit);
                Console.WriteLine(HeoMe.Select);
                Console.Write(HeoMe.Option);

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 6 || option < 1);

            Process(option);
        }
        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        Insert();
                        break;
                    }
                case 2:
                    {
                        Remove();
                        break;
                    }
                case 3:
                    {
                        Update();
                        break;
                    }
                case 4:
                    {
                        Search();
                        break;
                    }
                case 5:
                    {
                        Sort();
                        break;
                    }
                case 6:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }
        public static void Remove()
        {
            Console.WriteLine(HeoMe.InputName);
            var ten = Console.ReadLine();
            phoneBook.RemovePhone(ten);
        }
        public static void Insert()
        {
           
            Console.WriteLine(HeoMe.InputName);
            var ten = Console.ReadLine();
            Console.WriteLine(HeoMe.InputNumber);
            var number = Console.ReadLine();
            phoneBook.InserPhone(ten, number);
        }
        public static void Search()
        {
            Console.WriteLine(HeoMe.InputName);
            var ten = Console.ReadLine();
            phoneBook.SearchPhone(ten);
        }
        public static void Update()
        {
            Console.WriteLine(HeoMe.InputName);
            var ten = Console.ReadLine();
            Console.WriteLine(HeoMe.InputNumber);
            var number = Console.ReadLine();
            phoneBook.UpdatePhone(ten, number);
        }
        public static void Sort()
        {
            phoneBook.Sort();
           
        }
       
    }
}
