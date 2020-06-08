using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Collections;

namespace TestList
{
    public class Animal
    {
        public string Name { get; set; }
        public string Chirp { get; set; }
        public double Age { get; set; }
        public override string ToString()
        {
            return $"{Name}" +
                $"{Chirp}"+
                $"{Age}";
        }
    }

}
