using System;

namespace DoiNhietDo
{
    class Program
    {
        public static double FsangC(double doF)
        {
            double doC = (5.0 / 9) * (doF - 32);
            return doC;
        }
        public static double CsangF(double doC)
        {
            double doF = (9.0 / 5) * doC + 32;
            return doF;
        }
        static void Main(string[] args)
        {

            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        double a = FsangC(fahrenheit);
                        Console.WriteLine("Fahrenheit to Celsius: " + a);
                        break;
                    case 2:
                        Console.WriteLine("Enter Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CsangF(celsius));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

        }
    }
}
