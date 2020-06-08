using System;
using System.Collections.Generic;
using System.Text;

namespace MyNews
{
    public static class MenuList
    {
        public static  NewsFunction newsList = new NewsFunction();
        public static void CreateMenu()
        {

            int option = 0;
            do
            {
                Console.WriteLine(ConstList.Title);
                Console.WriteLine(ConstList.Insert);
                Console.WriteLine(ConstList.Remove);
                Console.WriteLine(ConstList.View);
                Console.WriteLine(ConstList.Avg);
                Console.WriteLine(ConstList.Exit);
                Console.WriteLine(ConstList.Select);
                Console.Write(ConstList.Option);

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
                        
                        break;
                    }
                case 3:
                    {
                        View();
                        break;
                    }
                case 4:
                    {
                        Sort();
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

        public static void Insert()
        {
            Console.WriteLine(ConstList.InputId);
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine(ConstList.InputName);
            var name = Console.ReadLine();
            Console.WriteLine(ConstList.InputTitle);
            var title = Console.ReadLine();
            Console.WriteLine(ConstList.InputContent);
            var content = Console.ReadLine();
            Console.WriteLine(ConstList.InputRate);
            var rate1 = int.Parse(Console.ReadLine());
            Console.WriteLine(ConstList.InputRate);
            var rate2 = int.Parse(Console.ReadLine());
            Console.WriteLine(ConstList.InputRate);
            var rate3 = int.Parse(Console.ReadLine());
            newsList.InsertList(id, title, name, content, rate1, rate2, rate3);
        }
        public static void View()
        {
            newsList.ViewList();
        }
        public static void Sort()
        {
            newsList.SortList();
            View();
        }



    }
}
