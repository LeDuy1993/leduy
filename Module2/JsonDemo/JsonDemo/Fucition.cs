using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonDemo
{
    class Fucition
    {

        public static Data StreamReaderStudent(string path)
        {
            Data payload = new Data();
            try
            {

                using StreamReader sr = File.OpenText(path);
                var data = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<Data>(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Hẹn gặp bạn lần sau");
            }
            return payload;

        }
        public static void WriteLineStuden(Data payload)
        {
            Console.WriteLine($"Id\tFullname\t\tGender\t\tDate of birth\tAge");
            foreach (var student in payload.students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public static void StreamWriterStrudent(string pathResult, Data payload)
        {
            ResData resData = new ResData();

            using StreamWriter sw = File.CreateText(pathResult);
            foreach (var std in payload.students)
            {
                var res = new ResStudent()
                {
                    Age = std.age,
                    Average = std.average,
                    DOB = std.dob.ToString("dd MMM yyyy"),
                    Fullname = std.fullName,
                    Gender = std.gender ? "Nam" : "Nu",
                    Id = std.id,
                    Toan = std.courses[0].score,
                    Ly = std.courses[1].score,
                    Hoa = std.courses[2].score
                    
                };
                resData.students.Add(res);
            }
            var data = JsonConvert.SerializeObject(resData);
            sw.WriteLine(data);
        }
    }
}
