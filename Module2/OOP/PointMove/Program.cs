using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace PointMove
{
    class Program
    {
        static void Main(string[] args)
        {
            Point lop2d = new Point();
            Console.WriteLine(lop2d);
            lop2d = new Point(1.2f, 2.6f);
            Console.WriteLine(lop2d);
            Console.WriteLine("Hello World!");
            PointMove pointmove = new PointMove();
            Console.WriteLine(pointmove);
        }
        class Point
        {
            public Point()
            {

            }
            public Point(float x, float y)
            {
                X = x;
                Y = y;
                XY[0] = x;
                XY[1] = y;
            }
            public float X { get; set; } = 1.0f;
            public float Y { get; set; } = 1.0f;
            public float[] XY { get; set; } = { 1.0f, 1.0f };

            public override string ToString() => $"Vi tri cua Point: x={XY[0]};y={XY[1]}";

        }
        class PointMove : Point
        {
            private float[] array2 = new float[2];
            public PointMove()
            {

            }
            public PointMove(float x, float y, float xmove, float ymove) : base(x, y)
            {
                XYSpeed[0] = xmove;
                XYSpeed[1] = ymove;
            }
            public float XSpeed { get; set; } = 1.0f;
            public float YSpeed { get; set; } = 1.0f;
            public float[] XYSpeed { get; set; } = { 2.0f, 2.0f };

            public float MoveX => X + XYSpeed[0];
            public float MoveY => Y + XYSpeed[1];

            public override string ToString() => base.ToString()+"\t" +
                $"Point move x=x+{XYSpeed[0]}" + 
                $" Point move y=y+{XYSpeed[1]}\t" +
                $"Vi tri cua Point sau dich chuyen: x={MoveX};y={MoveY}";



        }
    }
}
