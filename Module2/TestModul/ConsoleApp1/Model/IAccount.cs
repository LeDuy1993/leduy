using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3.Model
{
    public interface IAccount
    {
       
        public string ShowInfo();

        public void PayInto(float Amount);
    }
}
