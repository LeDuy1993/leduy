using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStatic
{
    class StudentFunction
    {
        public StudentProduct[] DanhSach = new StudentProduct[0];
        
        public void Add(StudentProduct sinhVien)
        {
            Array.Resize(ref DanhSach, DanhSach.Length + 1);
            DanhSach[DanhSach.Length - 1] = sinhVien;
        }
        public void ShowSinhVien()
        {
            foreach(StudentProduct item in DanhSach)
            {
                Console.WriteLine(item.Show());
            }
        }
        private int CheckSinhVien(string ten)
        {
            for(int i = 0; i < DanhSach.Length; i++)
            {
                if (DanhSach[i].Ten.Equals(ten))
                {
                    return i;
                }
            }
            return -1;
        }
        public void RemoveSinhVien(string ten)
        {
            int number = CheckSinhVien(ten);
            if (number != -1)
            {
                for(int i = number; i < DanhSach.Length-1; i++)
                {
                    DanhSach[i] = DanhSach[i + 1];
                }
                Array.Resize(ref DanhSach, DanhSach.Length - 1);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nay!");
            }
        }
        public void SearchSinhVien(string ten)
        {
            bool isExist = false;
            foreach(StudentProduct item in DanhSach)
            {
                if (item.Ten.Equals(ten))
                {
                    isExist = true;
                    Console.WriteLine(item.Show());
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found");
            }
        }

    }
}
