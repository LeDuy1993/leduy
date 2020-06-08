using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PhoneList
{
    public abstract class AbsPhone
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public abstract void InserPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
     
            
    }
}
