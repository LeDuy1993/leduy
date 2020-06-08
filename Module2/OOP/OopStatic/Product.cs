using System;
using System.Collections.Generic;
using System.Text;

namespace OopStatic
{
    class Product
    {
        public Product()
        {
            Ten = "Duy";
            ThongTin = "dsadasd";
            Gia = 3;
            AvgDanhGia = 3.33;
        }
        public string Ten { get; set; }
        public string ThongTin { get; set; }
        public double Gia { get; set; }
        public int[] DanhGia = new int[3];

        public double AvgDanhGia { get; private set; }
        public void TinhAvg()
        {
            double sum = 0;
            foreach (double item in DanhGia)
            {
                sum += item;
            }
            AvgDanhGia = sum / DanhGia.Length;
        }
        public string Show()
        {
            return $"Name: {Ten}\t" +
                    $"Desciption: {ThongTin}\t" +
                    $"Price: {Gia}\t" +
                    $"Average rate: {AvgDanhGia}";
        }
    }
}
