using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Arraylist
{
    class SortedListDemo
    {
        SortedList slDemo = new SortedList();

        public object Add { get; private set; }

        public void TestSL()
        {
            slDemo.Add(1, new Student()
            {
                Id = 1,
                Name = "Ngao Cho",
                Age = 21
            });
            slDemo.Add(2, new Student()
            {
                Id = 2,
                Name = "Ngao Da",
                Age = 23
            });
            slDemo.Add(3, new Student()
            {
                Id = 3,
                Name = "Ngao Thuoc",
                Age = 22
            });
           foreach(var key in slDemo.Keys)
            {
                Console.WriteLine(slDemo[key]);
            }
        }
    }
}
