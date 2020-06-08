using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    public static class Menu
    {
        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(Const.TieuDe);
                Console.WriteLine(Const.Select);
                Console.WriteLine(Const.Add);
                Console.WriteLine(Const.Remove);
                Console.WriteLine(Const.Show);
                Console.WriteLine(Const.Search);
                Console.WriteLine(Const.Exit);
                Console.Write(Const.Option);
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 5 || option < 1);
            Process(option);

        }
        public static void Process(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                     
                        break;
                    }
                case 2:
                    {
                        
                        break;
                    }
                case 3:
                    {
                       


                        break;
                    }
                case 4:
                    {
                       
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

    }

}

