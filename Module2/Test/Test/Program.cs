using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = CreateMatrix(5, 5);
            PrintMatrix(matrix);
            Console.WriteLine(SumRow(matrix, 2));
            Console.WriteLine(ShowMaxRow(matrix));
        }
        public static int[,] CreateMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];
            Random numberRamdom = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = numberRamdom.Next(10, 50);
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public static int SumRow(int[,] matrix, int n)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum += matrix[n, i];
            }
            return sum;
        }
        public static int SumCol(int[,] matrix, int m)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, m];
            }
            return sum;
        }
        public static string ShowMaxRow(int[,] matrix)
        {
            int maxSum = SumRow(matrix, 0);
            string arr = " ";
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                arr += matrix[0, j] + " ";
            }
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (maxSum < SumRow(matrix, i))
                {
                    arr = "";
                    maxSum = SumRow(matrix, i);
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        arr += matrix[i, j] + " ";
                    }
                }
            }
            return arr;
        }
    }

}
