using System;

namespace BaiTap2
{

    class Program
    {
        public static void TamGiacPasca(int number)
        {
            
            string str = "";
            for (int i = 0; i <= number; i++)
            {
                str = "";
                for (int j = 1; j <= i; j++)
                {
                    str += j + " ";
                }
                for (int j = i - 1; j > 0; j--)
                {
                    str += j + " ";
                }
                Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {


            int number;
            do
            {
                Console.Clear();
                Console.WriteLine("Input  number:");
                number = int.Parse(Console.ReadLine());
                TamGiacPasca(number);
                
            }
            while (number != 0);

        }
    }
}
