using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStatic
{
    class StudentProduct
    {
        
        public string Ten { get; set; }
        public string Dob { get; set; }
        public string Phone { get; set; }
        public double Toan { get; set; }
        public double Van { get; set; }
        public double Anh { get; set; }
        private double avg;
        public double Avg
        {
            get => avg;
        }

        public void TinhAvg()
        {
            avg = (Toan + Van + Anh) / 3;
        }
        public string Show()
        {
            return $"Ten: {Ten}\t" +
                $"DoB: {Dob}\t" +
                $"Phone: {Phone}\t" +
                $"Toan: {Toan}\t" +
                $"Van: {Van}\t" +
                $"Anh: {Anh}\t" +
                $"Diem trung binh: {avg}";

        }
    }
}
