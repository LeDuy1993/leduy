using System;

namespace TinhTongCanBac3
{
    class Program
    {
        public static double sum(ushort number)
        {
            double sum=0;
            for (int i = 1; i <= number; i++)
            {
                sum += Math.Pow(i, 1.0 / 3);
            }
            return sum;

        }
        static void Main(string[] args)
        {
            ushort number;
            double tong;
            Console.WriteLine("Enter Number:");
            number = ushort.Parse(Console.ReadLine());
            tong = sum(number);
            Console.WriteLine("Tong can bac 3 cua N so nguyen dau tien:" + tong);

        }
    }
}
