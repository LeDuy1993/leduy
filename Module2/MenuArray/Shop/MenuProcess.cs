using Shop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
  
    public static class MenuProcess
    {
        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("PROCESS");
                Console.WriteLine("1. Update");
                Console.WriteLine("2. Pay");
                Console.WriteLine("3. Cancel");
                Console.WriteLine("4. Exit.");
                Console.Write("Please select an option (1-4): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 4)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 4);

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
                            Menu.Update();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Menu.Pay();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Menu.Process();
                            break;
                        }
                }
            }
            while (selected != 4);
        }
       
    }
}
