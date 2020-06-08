using System;

namespace Mang2Chieu
{
    class Program
    {
        public static int[,] TaoMangHaiChieu(int col, int row)
        {
            int[,] matrix = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0,10);
                }
            }

            return matrix;
        }
        public static int[,] PrintMangHaiChieu(int[,] matrix)
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
            return matrix;
        }
        public static int SumCol(int[,] matrix, int col)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, col];
            }
            return sum;
        }
        public static int SumCheo(int[,] matrix, int number)
        {
            int sum = 0;
            if (number == 1)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, i];
                }
            }
            if (number == 2)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, matrix.GetLength(0) - 1 - i];

                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int col, row;
            int[,] maTran;
            int colIndex;
            int number;
            do

            {

                Console.WriteLine("Enter Col: ");
                col = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Row: ");
                row = Int32.Parse(Console.ReadLine());
                maTran = TaoMangHaiChieu(col, row);
                Console.WriteLine(PrintMangHaiChieu(maTran));

                Console.WriteLine("Enter Col_Index: ");
                colIndex = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Sum of Collum" + colIndex + " : " + SumCol(maTran, colIndex));

                Console.WriteLine("Enter number (1 la sum cheo chinh, 2 sum cheo phu): ");
                number = Int32.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Sum cheo chinh : " + SumCheo(maTran, number));
                        break;
                    case 2:
                        Console.WriteLine("Sum cheo phu : " + SumCheo(maTran, number));
                        break;
                }



            }
            while (col != 0 && row != 0);


        }
    }
}
