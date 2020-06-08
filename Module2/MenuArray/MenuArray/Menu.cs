using System;
using System.Collections.Generic;
using System.Text;

namespace MenuArray
{
    class Menu
    {
        public static ArrayService arr = new ArrayService();
        public static int[] array;
        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT");
                Console.WriteLine("1. CreatArray");
                Console.WriteLine("2. IsSymmetryArray");
                Console.WriteLine("3. InsertionSort");
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
                            IsSymmetryArray();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            InsertionSort();
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
            array = arr.CreatArray(size);
            Console.WriteLine(arr.PrintArray(array));
        }
        public static void IsSymmetryArray()
        {
            Console.WriteLine(arr.PrintArray(array));
            Console.WriteLine(arr.IsSymmetryArray(array));
        }
        public static void InsertionSort()
        {
            Console.WriteLine(arr.PrintArray(array));
            arr.InsertionSort(array);
            Console.WriteLine(arr.PrintArray(array));
        }
        public static void Find()
        {
            Console.WriteLine("Enter number:");
            var number = int.Parse(Console.ReadLine());
            arr.InsertionSort(array);
            Console.WriteLine(arr.PrintArray(array));
            Console.WriteLine(arr.Find(array, number));
        }

    }

}
