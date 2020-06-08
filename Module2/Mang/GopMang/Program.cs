using System;

namespace GopMang
{
    class Program
    {

        public static int[] TaoMang(int size)
        {
            int[] array;
            array = new int[size];
            int i = 0;
            while (i < size)
            {
                Console.WriteLine("Enter element" + (i + 1) + ":");
                array[i] = int.Parse(Console.ReadLine());
                i++;
            }
            return array;
        }
        public static int[] GopMang(int[] arr1, int[] arr2)
        {
            int[] array;
            array = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                array[i] = arr1[i];
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                array[arr1.Length + j] = arr2[j];
            }
            return array;
        }
        public static string PrinMang(int[] arr)
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
        public static int MaxArray(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int[] InputValueInArr(int[] arr, int value, int index)
        {
            int[] array;
            array = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
            array[array.Length - 1] = value;
            if (index < arr.Length && index >= 0)
            {

                for (int i = array.Length - 1; i > index; i--)
                {
                    int bienThayThe = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = bienThayThe;
                }
            }
            return array;
        }
        public static int[] Del_Value(int[] arr, int value)
        {
            int[] array;
            array = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (value == arr[i])
                {
                    

                    for (int j = i; j < arr.Length-1; j++)
                    {
                        int bienThayThe = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = bienThayThe;
                    }
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        array[j] = arr[j];
                    }
                    break;
                }
            }
            
            return array;
        }


        static void Main(string[] args)
        {
            int sizeArray1;
            int sizeArray2;
            int[] array1;
            int[] array2;
            int[] newArray;
            Console.WriteLine("enter size1:");
            sizeArray1 = Int32.Parse(Console.ReadLine());
            array1 = TaoMang(sizeArray1);           //Tạo mảng 1
            Console.WriteLine("enter size2:");
            sizeArray2 = Int32.Parse(Console.ReadLine());
            array2 = TaoMang(sizeArray2);           //Tạo mảng 2
            newArray = GopMang(array1, array2);      //Gộp 2 mảng
            Console.WriteLine(PrinMang(newArray)); // in mảng
            Console.WriteLine(MaxArray(newArray)); // Max

            int value, index;
            Console.WriteLine("Enter value: ");
            value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter index: ");
            index = Int32.Parse(Console.ReadLine());
            int[] newArray2 = InputValueInArr(newArray, value, index); //Thêm phần tử vào mảng
            Console.WriteLine(newArray2.Length);
            Console.WriteLine("Mảng sau khi thêm Giá trị" + value + " vào vị trí" + index + " : " + PrinMang(newArray2));
            int value_del;
            Console.WriteLine("Enter value_del: ");
            value_del = Int32.Parse(Console.ReadLine());
            int[] newArray3 = Del_Value(newArray2, value_del);
            Console.WriteLine("Mảng sau khi xóa Giá trị" + value + " : " + PrinMang(newArray3));

        }
    }
}
