using System;
using System.Collections;

namespace Arraylist
{
    internal class HashTableDemo
    {
        Hashtable hb = new Hashtable();
        public void TestHB()
        {
            hb.Add("10", new Student()
            {
                Id = 1,
                Name ="Ngao",
                Age = 20
            });
            hb.Add("11", new Student()
            {
                Id = 2,
                Name = "So2",
                Age = 20
            });
            hb.Add("12", new Student()
            {
                Id = 3,
                Name = "So1",
                Age = 20
            });
            hb.Add("9", new Student()
            {
                Id = 4,
                Name = "An",
                Age = 20
            });
            foreach (var key in  hb.Keys) 
            {
                Console.WriteLine(hb[key].ToString());
            }

        }
    }
}