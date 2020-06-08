using System;

namespace laiXuat
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;
            Console.WriteLine("Nhập số tiền: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gữi: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lãi xuất % năm: ");
            intersetRate = Double.Parse(Console.ReadLine());
            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * month;
            }
            Console.WriteLine("Total of interset: " + totalInterset);
        }
    }
}
