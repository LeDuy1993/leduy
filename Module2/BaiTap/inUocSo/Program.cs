using System;

namespace inUocSo
{
    class Program
    {
        public static string prinUocSo(int number)
        {
            string str = "";
            for(int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    str += i + " ,";
                }
            }
            str += number;
            return str;
        }
        static void Main(string[] args)
        {
            int number;
            string uocSo;
            do
            {
                Console.WriteLine("Enter Number:");
                number = int.Parse(Console.ReadLine());
                uocSo = prinUocSo(number);
                Console.WriteLine("Tap hop cac uoc so cua " + number + " : " + uocSo);
            }
            while (number != 0);
        }
    }
}
