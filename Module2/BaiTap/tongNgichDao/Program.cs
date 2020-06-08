using System;

namespace tongNgichDao
{
   
    class Program
    {
        public static double sumNgichDao(int number)
        {
            double sum=0;
            for (int i = 1; i <= number; i++)
            {
                sum += (double)1 / (double)i;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            int number;
            double S;
            Console.WriteLine("Enter Number");
            number = int.Parse(Console.ReadLine());
            S = sumNgichDao(number);
            Console.WriteLine(S);



        }
    }
}
