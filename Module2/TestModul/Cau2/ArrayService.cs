using System;
using System.Collections.Generic;
using System.Text;

namespace Cau2
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
                    array[i] = rd.Next(10, 50);
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
        public bool IsIncrement(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
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
        public int Find(int[] array, int number)
        {
            try
            {
                if(IsIncrement(array)){
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
                };
                return -1;
               
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public  void BubbleSort(int[] array)
        {
            try
            {
                int i, j, temp;
                int n = array.Length;
                bool swapped;
                for (i = 0; i < n - 1; i++)
                {
                    swapped = false;
                    for (j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            swapped = true;
                        }
                    }
                    if (swapped == false)
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Not found");
            }
           
        }
    }
}
