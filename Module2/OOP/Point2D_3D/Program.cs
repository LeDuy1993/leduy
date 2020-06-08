using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Point2D_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D[] array = new Point2D[2];
            Point2D lop2d = new Point2D();
            array[0] = lop2d;
            Console.WriteLine(array[0]);
            lop2d = new Point2D(1.2f, 2.6f);
            array[0] = lop2d;
            Console.WriteLine(array[0]);
            Point3D lop3d = new Point3D();
            Console.WriteLine(lop3d);
            lop3d = new Point3D(2.6f,3.4f,5.6f);
            Console.WriteLine(lop3d);
        }
        class Point2D
        {
            
            public Point2D()
            {

            }
            public Point2D(float x, float y)
            {

                XY[0] = x;
                XY[1] = y;

            }
            public float[] XY { get; set; } = { 1.0f, 1.0f };
            
            public override string ToString() => $"Toa do : {XY[0]}-{XY[1]}";

        }
        class Point3D : Point2D
        {
            public float Z { get; set; } = 0.0f;
            public float[] XYZ { get; set; } = { 1.0f, 1.0f, 0.0f };
            public Point3D()
            {

            }
            public Point3D(float x, float y, float z) : base(x, y)
            {
                XYZ[0] = x;
                XYZ[1] = y;
                XYZ[2] = z;
            }
       
            public override string ToString() => base.ToString() + $"-{XYZ[2]}"  ;
        }
    }

}
