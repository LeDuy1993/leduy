using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileDemo
{
    class Program
    {
        public static int[,] Matrans { get; private set; }

        static void Main(string[] args)
        {
            string path = @"E:\codegym\Module2\FileDemo\FileDemo";
            string fileName = "InputData.txt";
            int[,] matrix;
            int[,] matrix1 = new int[0, 0];
            Random rd = new Random();

            int r = 4, c = 4;
            using (StreamWriter sw = File.CreateText($@"{path}\{fileName}"))
            {
                sw.WriteLine($"{r} {c}");
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        sw.Write($"{ rd.Next(10, 70)} ");
                    }
                    sw.WriteLine();
                }
            }

            matrix = ReadFile($@"{path}\InputData.txt");
            WriteFile($@"{path}\OutputData.txt", matrix);
            string pathResult = @"E:\codegym\Module2\FileDemo\FileDemo\matrix.json";
            WriteFileJson(pathResult, matrix);
        }

        public static int[,] ReadFile(string fileName)
        {
            int[,] matrix;
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string line = sr.ReadLine();
                    string[] rowcol = line.Split(" ");
                    int row = int.Parse(rowcol[0]);
                    int col = int.Parse(rowcol[1]);
                    matrix = new int[row, col];
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] rows = line.Split(" ");

                        for (int j = 0; j < rows.Length - 1; j++)
                        {
                            matrix[i, j] = int.Parse(rows[j]);
                        }
                        i++;

                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                matrix = new int[0, 0];
                Console.WriteLine(ex);
            }

            return matrix;
        }

       
        public static void WriteFileJson(string fileName, int[,] matrix)
        {

            Matrix Matrans = new Matrix();
            
            using (StreamWriter sw = File.CreateText(fileName))
            {
                Matrans.Matran = matrix;
                var data = JsonConvert.SerializeObject(Matrans);
                sw.WriteLine(data);
            }

        }
        public static void WriteFile(string fileName, int[,] matrix)
        {
           
            
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine($"Sum of matrix: {Sum(matrix)}");
                sw.WriteLine($"Count of Odd: {CountOfOdd(matrix)}");
                sw.WriteLine($"Count of Prime: {CountOfPrime(matrix)}");
                sw.WriteLine($"Print Matrix:\n{PrintMatrix(matrix)}");
                sw.WriteLine($"Print Matrix X3:\n{PrintMatrixX3(matrix)}");
                
            }
        }
        public static string PrintMatrix(int[,] matrix)
        {
            string str = "";
            try
            {

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        str += matrix[i, j] + " ";
                    }
                    str += "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return str;
        }
        public static string PrintMatrixX3(int[,] matrix)
        {
            string str = "";
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        str += matrix[i, j] * 3 + " ";
                    }
                    str += "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return str;
        }
        public static long Sum(int[,] matrix)
        {
            long sum = 0;
            try
            {
                foreach (var item in matrix)
                {
                    sum += item;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sum;
        }
        public static byte CountOfOdd(int[,] matrix)
        {
            byte count = 0;
            try
            {
                foreach (var item in matrix)
                {
                    if (item % 2 != 0)
                    {
                        count += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count;
        }
        public static byte CountOfPrime(int[,] matrix)
        {
            byte count = 0;
            try
            {
                foreach (var item in matrix)
                {
                    bool istrue = true;
                    for (int i = 2; i <= Math.Sqrt(item); i++)
                    {
                        if (item % i == 0 || item < 2)
                        {
                            istrue = false;
                            break;
                        }
                    }
                    if (istrue == true)
                    {
                        count += 1;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count;
        }

    }
    class Matrix
    {
        public int[,] Matran { get; set; }
    }
  
}
