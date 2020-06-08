using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhoneList
{

   public class PhoneBook : AbsPhone
    {
        public ArrayList PhoneList = new ArrayList()
        {
           new PhoneProduct()
           {
               Name = "Duy",
               Phone ="01234466600"
           },
             new PhoneProduct()
           {
               Name = "VuNhom",
               Phone ="0235566000"
           },
                new PhoneProduct()
           {
               Name = "Phap",
               Phone ="02355661110"
           }
        };
        public void Show()
        {
            foreach (var item in PhoneList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public override void InserPhone(string name, string phone)
        {
            if (CheckName(name, out var index))
            {
                ((PhoneProduct)PhoneList[index]).Phone += $": {phone}";
            }
            else
            {
                PhoneList.Add(new PhoneProduct()
                {
                    Name = name,
                    Phone = phone
                });
            }
          
        }
        public bool CheckName(string name, out int index)
        {
            index = -1;
            foreach (PhoneProduct item in PhoneList)
            {
                if (item.Name.ToUpper().Equals(name.ToUpper()))
                {
                    index = PhoneList.IndexOf(item);
                    return true;
                }
            }
            return false;
        }

        public override void RemovePhone(string name)
        {
            if (CheckName(name, out var index))
            {
                PhoneList.RemoveAt(index);
                Show();
            }
            else
            {
                Console.WriteLine(HeoMe.NotFount);
            }
        }

        public override void SearchPhone(string name)
        {
            if (CheckName(name, out var index))
            {
                Console.WriteLine((PhoneProduct)PhoneList[index]);
            }
            else
            {
                Console.WriteLine(HeoMe.NotFount);
            }
        }

        public override void Sort()
        {
            PhoneList.Sort(new EditSort());
            Show();
        }

        public override void UpdatePhone(string name, string newphone)
        {
            if (CheckName(name, out var index))
            {
                ((PhoneProduct)PhoneList[index]).Phone = newphone;
            }
            else
            {
                Console.WriteLine(HeoMe.NotFount);
            }
            Show();

        }
    }
}
