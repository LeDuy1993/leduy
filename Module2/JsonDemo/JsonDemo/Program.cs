using System;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string path = @"E:\codegym\Module2\JsonDemo\JsonDemo\Data\Student.json";
            string path1 = @"E:\codegym\Module2\JsonDemo\JsonDemo\Data\NewStudent.json";
            Data payload = Fucition.StreamReaderStudent(path);
            Fucition.WriteLineStuden(payload);
            Fucition.StreamWriterStrudent(path1, payload);
        }
    }
}
