using System;

namespace maxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] array = new int[1];
            do
            {
                Console.WriteLine("Enter number");
                number = int.Parse(Console.ReadLine());

            }
            while (number!=0);
        }
    }
}
