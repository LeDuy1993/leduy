using System;

namespace sumBinhPhuong
{
    class Program
    {
        public static int sum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i * i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int number;
            int S;
            do
            {
                Console.WriteLine("Enter number");
                number = int.Parse(Console.ReadLine());
                S = sum(number);
                Console.WriteLine(S);
            }
            while (number != 0);


        }
    }
}
