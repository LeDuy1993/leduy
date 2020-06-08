using System;
using System.Collections.Generic;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);
            Console.WriteLine("After-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            ComperableCircle[] circles1 = new ComperableCircle[3];
            circles1[0] = new ComperableCircle(3.6);
            circles1[1] = new ComperableCircle();
            circles1[2] = new ComperableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles1)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles1);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles1)
            {
                Console.WriteLine(circle);
            }
        }
        public class CircleComparator : IComparer<Circle>
        {

            public int Compare(Circle c1, Circle c2)
            {
                if (c1.Radius > c2.Radius) return 1;
                else if (c1.Radius < c2.Radius) return -1;
                else return 0;
            }
        }

    }
}
