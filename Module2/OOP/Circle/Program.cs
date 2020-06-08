using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle tron = new Circle();
            Console.WriteLine(tron);
            Cylinder tru = new Cylinder();
            Console.WriteLine(tru);
            tru.Color = "Green";
            tru.Radius = 5.0;
            tru.CylinderHeight = 10;
            Console.WriteLine(tru);
        }

        public class Circle
        {

            public Circle() { }
            public string Color { get; set; } = "Red";
            public double Radius { get; set; } = 2.3;

            public double S() => Radius * Radius * Math.PI;
            public double P() => Math.PI * Radius * 2;
            public override string ToString() => 
                       $"Ban kinh: {Radius}" +
                       $"Mau: {Color}" +
                       $"Dien tich {S()}";
        }
        public class Cylinder : Circle
        {
            public Cylinder() { }
            public double CylinderHeight { get; set; } = 5.0;
            public double V() => Radius * Radius * Math.PI * CylinderHeight;

            public override string ToString() =>
                       $"Ban kinh: {Radius}" +
                       $"Mau: {Color}" +
                       $"The tich {V()}";
        }

    }
}
