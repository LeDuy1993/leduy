using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Cau3.Model
{
   public class Account : IAccount
    {
        public int AccountId { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public float Balance { get; private set; }

        public void PayInto(float Amount)
        {

            Balance = Balance + Amount;

        }

        public string ShowInfo()
        {
            return $"{AccountId}\t{Lastname} {Fristname}\t{Gender}\t{Gender}";
        }
    }
}
