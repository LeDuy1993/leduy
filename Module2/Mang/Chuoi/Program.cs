using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            char kitu;
            int count = 0;

            Console.WriteLine("Enter chuoi:");
            str = Console.ReadLine();
         
            Console.WriteLine("Enter ki tu can kiem tra:");
            kitu =Convert.ToChar(Console.ReadLine()) ;
            for(int i = 0; i < str.Length; i++)
            {
                if (kitu==str[i])
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);

        }
    }
}
