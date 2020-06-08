using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OOP
{
    class PhuongTrinhBac2
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());
            PhuongTrinhBac2 pt2 = new PhuongTrinhBac2(a, b, c);
            Console.WriteLine("delta:" + pt2.getDelta());
            Console.WriteLine("X1:" + pt2.getNghiem1(pt2.getDelta()));
            Console.WriteLine("X2:" + pt2.getNghiem2(pt2.getDelta()));
        }
        double a, b, c;
        public PhuongTrinhBac2(double a, double b, double c)
        {
            this.a = a;

            this.b = b;
            this.c = c;

        }
        public double getDelta()
        {
            return (this.b * this.b) - (4 * this.a * this.c);
        }
        public double getNghiem1(double del)
        {
            double x1 = 0;

            if (del < 0)
            {
                x1= 0;
            }
            if (del > 0)
            {
                x1=(-b + Math.Pow(del,0.5)) / (2 * a);        
            }
            if (del == 0)
            {
                x1=(-b) / (2 * a);
            }
            return x1;
        }
        public double getNghiem2(double del)
        {
            double x2 = 0;

            if (del < 0)
            {
                x2 = 0;
            }
            if (del > 0)
            {
                x2 = (-b - Math.Pow(del, 0.5)) / (2 * a);
            }
            if (del == 0)
            {
                x2 = (-b) / (2 * a);
            }
            return x2;
        }

    }
}
