using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
 
    class Triangle : Shape
    {
        static void Main(string[] args)

        {
            Shape shape = new Shape();
            Console.WriteLine(shape);
            Triangle Tamgiac = new Triangle();
            Console.WriteLine(Tamgiac);
            Triangle Tamgiac1 = new Triangle(4.0f,4.0f,4.0f,"Green",true);
            Console.WriteLine(Tamgiac1);
        }
        Triangle()
        {

        }
        Triangle(float size1, float size2, float size3, string color, bool filled) : base (color, filled)
        {
            Size1 = size1;
            Size2 = size2;
            Size3 = size3;

        }
        public float Size1 { get; set; } = 2.0f;
        public float Size2 { get; set; } = 2.0f;
        public float Size3 { get; set; } = 2.0f;

        public float P => Size1 + Size2 + Size3;

        public override string ToString()
        {
            return base.ToString() +
                $". Cac canh cua tam giac size1= {Size1}, size2 = {Size2}, size3 = {Size3}" +
                $", Chu vi cua tam giac: {P}";
        }
    }
}
