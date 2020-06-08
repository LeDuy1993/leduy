using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace OOP
{
    class Quat
    {
        public static void Main(string[] args)
        {
            Quat Fan0 = new Quat();
            Console.WriteLine($"Doi tuong Fan 2: {Fan0.Getshow}");

            Quat Fan1 = new Quat();
            Fan1.On();
            Console.WriteLine("Enter color: ");
            string c = Console.ReadLine();
            Fan1.Color = c;
            Console.WriteLine("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            Fan1.Radius = r;
            Console.WriteLine("Enter speed: ");
            int s = int.Parse(Console.ReadLine());
            Fan1.Speed = s;
            Console.WriteLine($"Doi tuong Fan 1: {Fan1.Getshow}");

            Quat Fan2 = new Quat();
            Fan2.Off();
            Fan2.Color = "red";
            Fan2.Radius = 5;
            Fan2.Speed = 1;
            Console.WriteLine($"Doi tuong Fan 2: {Fan2.Getshow}");
        }
        private bool trangThai;
        private int speed;
        private int radius;
        private string color;
        Quat()
        {
            trangThai = false;
            speed = 1;
            radius = 5;
            color = "blue";
        }

        public void On() => trangThai = true;
        public void Off() => trangThai = false;
        public string Color
        {
            get => color;
            set => color = value;
        }
        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public int Radius 
        { 
            get => radius; 
            set => radius = value; 
        }

        public string Getshow => $"Speed {speed}, radius la {radius}, color la {color} va quat o trang thai {trangThai}.";
    }
}
