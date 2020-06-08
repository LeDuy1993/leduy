using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Time
    {

        public static void Main(string[] args)
        {
            Console.Clear();
            Time timewatch = new Time();
            Console.WriteLine(timewatch);
            Console.ReadKey();
            Console.Clear();
            DateTime time1 = timewatch.Star;
            Console.WriteLine($" Gio bat dau: {timewatch.Star}");
            Console.ReadKey();
            DateTime time2 = timewatch.Stop;
            Console.WriteLine($" Gio ket thuc: {timewatch.Stop}");
            Console.WriteLine($" Time: {timewatch.GetElapsedTime(time1, time2)} giay");


        }

        DateTime aDateTime = DateTime.Now;
        public Time()
        {
            
            int h = aDateTime.Hour;
            int m = aDateTime.Minute;
            int s = aDateTime.Second;
            Console.WriteLine($"Gio bat dau: {h}:{m}:{s}");

        }
        public DateTime Star
        {
            get
            {
                DateTime aDateTime = DateTime.Now;

                return aDateTime;

            }
        }

        public DateTime Stop
        {
            get
            {
                DateTime aDateTime = DateTime.Now;

                return aDateTime;
            }
        }

        public int GetElapsedTime(DateTime time1, DateTime time2)
        {
            int time;
            int h1 = time1.Hour;
            int m1 = time1.Minute;
            int s1 = time1.Second;
            int h2 = time2.Hour;
            int m2 = time2.Minute;
            int s2 = time2.Second;
            time = (h2 * 60 * 60 + m2 * 60 + s2) - (h1 * 60 * 60 + m1 * 60 + s1);
            return time;
        }
    }
}