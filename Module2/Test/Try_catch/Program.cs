using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int a = 39;
                    int b = 0;
                    Console.WriteLine("Thuc hien phep chia");
                    int c = a / b;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Xử lý ngoại lệ FormatException");
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Xử lý ngoại lệ ArithmeticException");
            }

            Console.WriteLine("tiep tuc chuong trinh..");
        }
    }
}
