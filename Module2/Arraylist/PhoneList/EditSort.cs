using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhoneList
{
    class EditSort : IComparer
    {
        public int Compare(object x, object y)
        {
            return string.Compare(((PhoneProduct)x).Name, ((PhoneProduct)y).Name);

        }
    }
}
