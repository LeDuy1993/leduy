using System;
using System.Collections.Generic;
using System.Text;

namespace Cau1
{
    class MatrixService
    {
        public static int[,] CreatMatrix(int number)
        {
            try
            {
                int[,] matrix = new int[number, number];
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rand.Next(40, 80);
                    }
                }

                return matrix;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string ShowArray(int[,] matrix)
        {
            try
            {
                string str;
                str = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        str += matrix[i, j] + " ";

                    }
                    str += "\n";
                }

                return str;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int FindMin(int[,] matrix)
        {
            try
            {
                int min = matrix[0,0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (min >= matrix[i, j])
                        {
                            min = matrix[i, j];
                        }
                    }
                }
                return min;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static int DiagonalDifference(int[,] matrix)
        {
            try
            {
                int sumCheoChinh = 0;
                int sumCheoPhu = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sumCheoChinh = +matrix[i, i];
                    sumCheoPhu += matrix[i, matrix.GetLength(0) - 1 - i];
                }
                
                return Math.Abs( sumCheoChinh - sumCheoPhu);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
