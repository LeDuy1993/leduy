using System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Arraylist
{
    class ArrayListDemo {
        ArrayList al = new ArrayList();

        public void Test()
        {
            al.Add(new Student()
            {
                Id = 0,
                Name = "Duy",
                Age = 20
            });
            al.Add(new Student()
            {
                Id = 1,
                Name = "An",
                Age = 20
            });
            al.Add(new Student()
            {
                Id = 2,
                Name = "Phap",
                Age = 20
            });
            al.Add(new Student()
            {
                Id = 3,
                Name = "Vu",
                Age = 20
            });
            foreach (var item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
