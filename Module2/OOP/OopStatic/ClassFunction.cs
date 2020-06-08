using System;
using System.Collections.Generic;
using System.Text;

namespace OopStatic
{
    class ClassFunction
    {
        public Product[] List = new Product[0];

        public void Add(Product sanPham)
        {
            Array.Resize(ref List, List.Length + 1);
            List[List.Length - 1] = sanPham;
        }
        public void Del(string sanPham)
        {
            int number = KiemTra(sanPham);
            if (number != -1)
            {
                for (int i = number; i < List.Length-1; i++)
                {
                    List[i] = List[i + 1];
                }
                Array.Resize(ref List, List.Length - 1);
            }
            else
            {
                Console.WriteLine("Not Found");
            }


        }
        private int KiemTra(String ten)
        {
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].Ten.Equals(ten))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Search(string ten)
        {
            bool isExist = false;
            foreach(Product item in List)
            {
                if (item.Ten.Equals(ten))
                {
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found");
            }
        }
        public void ShowProductList()
        {
            foreach (Product item in List)
            {
                Console.WriteLine(item.Show());
            }
        }
    }
}
