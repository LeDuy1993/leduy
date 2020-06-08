using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyNews
{
    class SortList : IComparer
    {
        public int Compare(object x, object y)
        {
            return string.Compare(((News)x).Author, ((News)y).Author);
        }
    }
}
