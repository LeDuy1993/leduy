using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace test
{

    public class Shape

    {
        static void Main(string[] args)

        {
            Shape shape = new Shape();
            Console.WriteLine(shape);
           
            shape = new Shape("red", false);
            Console.WriteLine(shape);
            Console.WriteLine("Hello World!");

            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3.5);
            Console.WriteLine(circle);
            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);
            Console.WriteLine("Hello World!");

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);
            Console.WriteLine("Hello World!");

            Square square = new Square();
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);
            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);


        }
        public Shape()
        {
        }
        public Shape(string color, bool filled)

        {

            this.Color = color;

            this.IsFilled = filled;

        }
        public string Color { get; set; } = "green";
        public bool IsFilled { get; set; } = true;
        public override string ToString() => "A Shape with color of "

                                                + Color

                                                + " and "

                                                + (IsFilled ? "filled" : "not filled");

    }

}
