using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class hinhChuNhat
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            double height = double.Parse(Console.ReadLine());
            hinhChuNhat rectangle = new hinhChuNhat();
            rectangle.Width = width; 
            rectangle.Height=height;
            Console.WriteLine("Your Rectangle \n" + rectangle.Show());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.P());
            Console.WriteLine("Area of the Rectangle: " + rectangle.S());
        }
        private double width;
        private double height;
        public double Width
        {
            get => width;
            set => width = value;
          
        }
        public double Height
        {
            get => height;
            set => height = value;
        }
        public double P() => (width + height) * 2;

        public double S() => height * width;
 
        public string Show() => "HCN{" + "width=" + width + ", height=" + height + "}";
       
    }
}
