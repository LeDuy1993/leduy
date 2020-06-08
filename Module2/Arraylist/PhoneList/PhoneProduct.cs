using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneList
{
    class PhoneProduct
    {
      
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $" Name: {Name}, Phone: {Phone.Substring(0,6)}XXX";
           
        }
    }
}
