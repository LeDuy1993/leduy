using System;

namespace BaiTap3
{

    class Program
    {
        public static string HeNhiPhan(char kitu)
        {
            string str = "", str1 = "";
            byte keycode = (byte)(kitu);
            int number = (int)(keycode);
            do
            {
                str += number % 2;
                number = number / 2;
            }
            while (number != 0);
            if (str.Length == 6)
            {
                str += "00";
            }
            if (str.Length == 7)
            {
                str += "0";
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str1 += str[i];
            }
            return str1;
        }
        public static string HeThapLucPhan(char kitu)
        {
            string heNhiPhan, heThapLucPhan="";
            heNhiPhan = HeNhiPhan(kitu);
            string str="";
            for(int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    str = heNhiPhan.Substring(0, 4);
                }
                if (i == 1)
                {
                    str = heNhiPhan.Substring(heNhiPhan.Length-4, 4);
                }
                switch (str)
                {
                    case "0000": heThapLucPhan += "0";  break;
                    case "0001": heThapLucPhan += "1"; break;
                    case "0010": heThapLucPhan += "2"; break; 
                    case "0011": heThapLucPhan += "3" ; break;
                    case "0100": heThapLucPhan += "4"; break;
                    case "0101": heThapLucPhan += "5"; break;
                    case "0110": heThapLucPhan += "6"; break;
                    case "0111": heThapLucPhan += "7"; break;
                    case "1000": heThapLucPhan += "8"; break;
                    case "1001": heThapLucPhan += "9"; break;
                    case "1010": heThapLucPhan += "A"; break;
                    case "1011": heThapLucPhan += "B"; break;
                    case "1100": heThapLucPhan += "C"; break;
                    case "1101": heThapLucPhan += "D"; break;
                    case "1110": heThapLucPhan += "E"; break;
                    case "1111": heThapLucPhan += "F"; break;
                }
            }
            return heThapLucPhan;
        }
        static void Main(string[] args)
        {
            char ch;
            string heNhiPhan, heThapLucPhan;
        
            do
            {  
                Console.WriteLine();
                ch = char.Parse(Console.ReadLine());
                byte keycode = (byte)(ch);
                int number = (int)(keycode);
                heNhiPhan = HeNhiPhan(ch);
                heThapLucPhan = HeThapLucPhan(ch);
                Console.Write("He Thap Phan: "+number+ "        "+"He Nhi Phan: "+ heNhiPhan+ "        "+ "He Thap Luc Phan: "+ heThapLucPhan);
            }
            while (ch!='0');

        }
    }
}
