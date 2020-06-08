using System;

namespace namNhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool checkyear = false;
            Console.WriteLine("Input year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        checkyear = true;
                    }
                }
                else
                {
                    checkyear = true;
                }
            }

            if (checkyear)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT a leap year", year);
            }
        }
    }
}
