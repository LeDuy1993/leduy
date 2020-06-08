using System;
using System.Text;

namespace PhoneList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Red;
            MenuPhone.CreateMenu();
        }
    }
}
