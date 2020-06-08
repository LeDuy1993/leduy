using System;
using System.Text;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string str1 = "Cộng Hòa Xã Hội Chủ Ngĩa Việt Nam";
            string str2 = "Độc Lập - Tự Do - Hạnh Phúc";
            Console.ReadKey();
            Console.SetCursorPosition((Console.WindowWidth - str1.Length) / 2, Console.CursorTop);
            Console.WriteLine(str1);
            Console.ReadKey();
            Console.SetCursorPosition((Console.WindowWidth - str2.Length) / 2, Console.CursorTop);
            Console.WriteLine(str2);

        }
    }
}
