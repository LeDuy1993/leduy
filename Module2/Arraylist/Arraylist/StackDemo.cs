using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arraylist
{
    class StackDemo
    {
        Stack st = new Stack();
        public void TestST()
        {
            st.Push(new Student()
            {
                Id = 1,
                Name = "An",
                Age = 18
            });
            st.Push(new Student()
            {
                Id = 2,
                Name = "Vu",
                Age = 18
            });
            st.Push(new Student()
            {
                Id = 3,
                Name = "Ngao",
                Age = 18
            });
            Console.WriteLine(st.Count);
            
            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
            Console.WriteLine(st.Count);
        }

    }
}

