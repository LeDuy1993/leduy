using Cau1;
using System;

namespace TestModul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            var number = int.Parse(Console.ReadLine());
         

            int[,] matrix = MatrixService.CreatMatrix(number);
            int min = MatrixService.FindMin(matrix);
            int diagonal = MatrixService.DiagonalDifference(matrix);
            string str = MatrixService.ShowArray(matrix);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("DiagonalDifference:" + diagonal);
            Console.WriteLine("Show matrix");
            Console.WriteLine(str);

        }

    }
}
