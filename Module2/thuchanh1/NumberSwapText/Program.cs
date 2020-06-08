using System;

namespace NumberSwapText
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            string reading = "";
            Console.WriteLine("Input number:");
            number = Convert.ToInt32(Console.ReadLine());
            string numberText = number.ToString();
            if (number <= 20)
            {
                switch (number)
                {
                    case 0:
                        reading = "zero"; break;
                    case 1:
                        reading = "one"; break;
                    case 2:
                        reading = "two"; break;
                    case 3:
                        reading = "three"; break;
                    case 4:
                        reading = "four"; break;
                    case 5:
                        reading = "fire"; break;
                    case 6:
                        reading = "six"; break;
                    case 7:
                        reading = "seven"; break;
                    case 8:
                        reading = "eight"; break;
                    case 9:
                        reading = "nine"; break;
                    case 10:
                        reading = "ten"; break;
                    case 11:
                        reading = "eleven"; break;
                    case 12:
                        reading = "twelve"; break;
                    case 13:
                        reading = "thirteen"; break;
                    case 14:
                        reading = "fourteen"; break;
                    case 15:
                        reading = "fifteen"; break;
                    case 16:
                        reading = "sixteen"; break;
                    case 17:
                        reading = "seventeen"; break;
                    case 18:
                        reading = "eighteen"; break;
                    case 19:
                        reading = "nineteen"; break;
                }
            }
            else if (number < 100)
            {
                switch (numberText[0])
                {
                  
                    case '2':
                        reading += "twenty"; break;
                    case '3':
                        reading += "thirty"; break;
                    case '4':
                        reading += "forty"; break;
                    case '5':
                        reading += "fifty"; break;
                    case '6':
                        reading += "sixty"; break;
                    case '7':
                        reading += "seventy"; break;
                    case '8':
                        reading += "eighty"; break;
                    case '9':
                        reading += "ninety"; break;
                }
                switch (numberText[1])
                {
                    case '0':
                        reading += " "; break;
                    case '1':
                        reading += "_one"; break;
                    case '2':
                        reading += "_two"; break;
                    case '3':
                        reading += "_three"; break;
                    case '4':
                        reading += "_four"; break;
                    case '5':
                        reading += "_fire"; break;
                    case '6':
                        reading += "_six"; break;
                    case '7':
                        reading += "_seven"; break;
                    case '8':
                        reading += "_eight"; break;
                    case '9':
                        reading += "_nice"; break;
                }
            }
            else if (number < 1000)
            {
                switch (numberText[0])
                {
                    case '1':
                        reading += "one hundred"; break;
                    case '2':
                        reading += "two hundred"; break;
                    case '3':
                        reading += "three hundred"; break;
                    case '4':
                        reading += "four hundred"; break;
                    case '5':
                        reading += "fire hundred"; break;
                    case '6':
                        reading += "six hundred"; break;
                    case '7':
                        reading += "seven hundred"; break;
                    case '8':
                        reading += "eight hundred"; break;
                    case '9':
                        reading += "nine hundred"; break;
                }
                switch (numberText[1])
                {
                    case '1':
                        reading += " "; break;
                    case '2':
                        reading += " twenty"; break;
                    case '3':
                        reading += " thirty"; break;
                    case '4':
                        reading += " forty"; break;
                    case '5':
                        reading += " fifty"; break;
                    case '6':
                        reading += " sixty"; break;
                    case '7':
                        reading += " seventy"; break;
                    case '8':
                        reading += " eighty"; break;
                    case '9':
                        reading += "ninety"; break;
                }
                switch (numberText[2])
                {
                    case '0':
                        reading += " "; break;
                    case '1':
                        reading += "_one"; break;
                    case '2':
                        reading += "_two"; break;
                    case '3':
                        reading += "_three"; break;
                    case '4':
                        reading += "_four"; break;
                    case '5':
                        reading += "_fire"; break;
                    case '6':
                        reading += "_six"; break;
                    case '7':
                        reading += "_seven"; break;
                    case '8':
                        reading += "_eight"; break;
                    case '9':
                        reading += "_nice"; break;
                }
            }
                Console.WriteLine($"Reading: {reading}");
        }
    }
}
