using System;

namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            Console.WriteLine($"Giá trị tuyeteh đối của a: {a}");
            Console.WriteLine($"Giá trị tuyeteh đối của b: {b}");
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine($"UCLN: {a}");
        }
    }
}
