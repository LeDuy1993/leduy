using System;
using System.Collections.Generic;
using System.Text;

namespace Cau2
{
    class Menu
    {
        public static ArrayService arrayService = new ArrayService();
        public static int[] array;
        public static int[] arr;
        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT");
                Console.WriteLine("1. CreatArray");
                Console.WriteLine("2. IsIncrement");
                Console.WriteLine("3. BubbleSort");
                Console.WriteLine("4. Find");
                Console.WriteLine("5. Exit");

                Console.Write("Please select an option (1-5): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 5)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 5);

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
                            CreatArray(out array);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine(arrayService.PrintArray(array));
                            IsIncrement();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(arrayService.PrintArray(array));
                            BubbleSort2();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Find();
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }

                }
            }
            while (selected != 5);
        }
        public static void CreatArray(out int[] array)
        {
            Console.WriteLine("Enter size:");
            var size = int.Parse(Console.ReadLine());
            array = arrayService.CreatArray(size);
            Console.WriteLine(arrayService.PrintArray(array));
        }
        public static void IsIncrement()
        {
            Console.WriteLine(arrayService.IsIncrement(array));
        }
        public static void BubbleSort2()
        {
            arrayService.BubbleSort(array);
            Console.WriteLine(arrayService.PrintArray(array));
        }
        public static void Find()
        {
            Console.WriteLine("Input number;");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(arrayService.Find(array, number));
        }
    }
}
