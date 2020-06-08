using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shop.Service
{
    class ReadWriteData<T> where T : class
    {
        public static void ReadData(string fullpath, out T data)
        {
            using (StreamReader sr = File.OpenText(fullpath))
            {
                var obj = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<T>(obj);
            }
        }

        public static void WriteData(string fullpath, T data)
        {
            using (StreamWriter sw = File.CreateText(fullpath))
            {
                var resData = JsonConvert.SerializeObject(data);
                sw.WriteLine(resData);
            }
        }
    }
}
