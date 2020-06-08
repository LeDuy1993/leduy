using System;

namespace tamGiacCan
{
    class Program
    {
        public static void tamGiacCan(int number)
        {

            string str ="";
            for (int i = 0; i <= number; i+=2)
            {
                str ="";
                for (int j = 0; j <= i; j++)
                {
                    str += "*";
                }
                Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
                Console.WriteLine(str);
            }
        }
        public static string[,] mangTamGiacCan(int number)
        {
            if (number % 2 == 0)
            {
                number += 1;
            }
            string[,] matrixTamGiac = new string[(number / 2) + 1, number];

            for (int i = 0; i < matrixTamGiac.GetLength(0); i++)
            {
                for (int j = 0; j < matrixTamGiac.GetLength(0) - 1 - i; j++)
                {
                    matrixTamGiac[i, j] = " ";
                }
                for (int j = matrixTamGiac.GetLength(0) - 1 - i; j <= matrixTamGiac.GetLength(0) - 1 + i; j++)
                {
                    matrixTamGiac[i, j] = "*";
                }
                for (int j = matrixTamGiac.GetLength(0) + i; j < matrixTamGiac.GetLength(1); j++)
                {
                    matrixTamGiac[i, j] = " ";
                }
            }
            return matrixTamGiac;
        }
        public static string[,] printMatrix(string[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
            }
            Console.WriteLine();
            return matrix;
        }
        static void Main(string[] args)
        {
            int number;
            string[,] taoTamGiac;
            string[,] inTamGiac;
            do
            {
                Console.WriteLine("enter Number:");
                number = int.Parse(Console.ReadLine());
                tamGiacCan(number);
                taoTamGiac = mangTamGiacCan(number);
                inTamGiac = printMatrix(taoTamGiac);
                Console.WriteLine(inTamGiac);
            }
            while (number != 0);
        }
    }
}
