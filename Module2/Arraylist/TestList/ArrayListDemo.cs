using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestList
{
    class ArrayListDemo
    {
        ArrayList al = new ArrayList();
        public void Test()
        {
            al.Add(new Animal()
            {
                Name = "An",
                Chirp = "Gau gau",
                Age = 20
            });
            al.Add(new Animal()
            {
                Name = "Phap",
                Chirp = "Ang Ang",
                Age = 21

            });
            foreach (var item in al)
            {
                Console.WriteLine(item.ToString());
            }
            al.Sort(new SortAnimal());
            foreach (var item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class SortAnimal : IComparer
    {
        public int Compare(object x, object y)
        {
            Animal a1 = x as Animal;
            Animal a2 = y as Animal;
            if (a1 == null || a2 == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                if (a1.Age < a2.Age)
                {
                    return 1;
                }
                else if (a1.Age == a2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

    }
}
