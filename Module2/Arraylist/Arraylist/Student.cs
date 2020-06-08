using System;
using System.Collections.Generic;
using System.Text;


namespace Arraylist
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }

}

