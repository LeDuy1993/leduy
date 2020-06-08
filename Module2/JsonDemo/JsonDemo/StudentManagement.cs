using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JsonDemo
{
    class Student
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public bool gender { get; set; }
        public int age => DateTime.Now.Year - dob.Year;
        public List<Course> courses = new List<Course>();
        public DateTime dob { get; set; }
        private double CalculatorAverage()
        {
            double total = 0.0;
            foreach (var item in courses)
            {
                if (item.name.ToLower().Equals("Toan".ToLower()))
                {
                    total += item.score * 2;
                }
                else
                {
                    total += item.score;
                }
                
            }
            return total / (courses.Count+1);
        }
        public double average => CalculatorAverage();

        public override string ToString()
        {
            string str = $"{id}\t{fullName}\t\t\t" +
                        $"{(gender ? "Nam" : "Nu")}\t\t" +
                        $"{dob:dd MMM yyyy}\t" +
                        $"{age}\t";
            str = $"{str}\n\t\tName\tScore";
            foreach (var item in courses)
            {
                str = $"{str}\n\t{item.ToString()}";
            }
            str = $"{str}\n\t\tAverage {average}\t" +
                  $"Xếp Loại: {(average >= 9.0 ? "Xuất sắc" : average >= 8.0 ? "Giỏi" : average >= 7 ? "Khá" : average >= 6.5 ? "TBK" : "Yếu")}";
            return str;
        }
    }
    class Course
    {
        public string name { get; set; }
        public double score { get; set; }
        public override string ToString()
        {
            return $"\t{name}\t{score}";
        }
    }
    class Data
    {
        public List<Student> students = new List<Student>();
    }
    class ResStudent
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public int Age { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double Average { get; set; }
        public string XepLoai => $"{(Average >= 9.0 ? "Xuất sắc" : Average >= 8.0 ? "Giỏi" : Average >= 7 ? "Khá" : Average >= 6.5 ? "TBK" : "Yếu")}";
    }
    class ResData
    {
        public List<ResStudent> students = new List<ResStudent>();
    }
}
