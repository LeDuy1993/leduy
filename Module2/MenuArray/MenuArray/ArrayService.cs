using System;
using System.Collections.Generic;
using System.Text;

namespace MenuArray
{
    class ArrayService
    {
        public int[] CreatArray(int size)
        {
            try
            {
                Random rd = new Random();
                int[] array;
                array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = rd.Next(30, 60);
                }
                return array;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string PrintArray(int[] arr)
        {
            try
            {
                string matrix;
                matrix = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        matrix += arr[i];
                    }
                    else
                    {
                        matrix += arr[i] + ",";
                    }
                }
                return matrix;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool IsSymmetryArray(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    if (array[i] != array[array.Length - i - 1])
                    {
                        return false;
                    }
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public void InsertionSort(int[] array)
        {
            try
            {
                int n = array.Length;
                for (int i = 1; i < n; ++i)
                {
                    int key = array[i];
                    int j = i - 1;
                    while (j >= 0 && array[j] > key)
                    {
                        array[j + 1] = array[j];
                        j = j - 1;
                    }
                    array[j + 1] = key;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("false");
            }
        }
        public int Find(int[] array, int number)
        {
            try
            {

                int low = 0;
                int high = array.Length - 1;
                while (high >= low)
                {
                    int mid = (low + high) / 2;
                    if (number < array[mid])
                    {
                        high = mid - 1;
                    }

                    else if (number == array[mid])
                    {
                        return mid;
                    }

                    else
                    {
                        low = mid + 1;
                    }

                }
                return -1; 
            }
            catch (Exception)
            {
                return -1;
            }


        }
    }
}
