using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Coffee
{
    class JsonCoffee
    {
        public static void StreamWriterTable(string pathjson, Table table)
        {
            using (StreamWriter swjson = File.CreateText(pathjson))
            {
                var data = JsonConvert.SerializeObject(table);
                swjson.WriteLine(data);
            }
        }
        public static void StreamWriteAllBill(string path, Table table)
        {
            using (StreamWriter swjson = File.CreateText(path))
            {
                    var data = JsonConvert.SerializeObject(table);
                    swjson.WriteLine(table);
            }
        }
    }
}
