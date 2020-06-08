using Cau3.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3
{  
    class Menu
    {
        public static Dictionary<int, Account> Bank = new Dictionary<int, Account>();
        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("\nPlease select an option from 1 to 4:");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Pay Into");
                Console.WriteLine("3. Show Customers data");
                Console.WriteLine("4. Exit");
                Console.Write("Input number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                if (option > 4 || option < 1)
                {
                    Console.Clear();
                }
            }
            while (option > 4 || option < 1);
            Process(option);
        }
        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        CreateAccount();
                        break;
                    }
                case 2:
                    {
                        PayInto();
                        break;
                    }
                case 3:
                    {
                        ShowData();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }
        public static int id = 0;
       
        public static void CreateAccount()
        {
            Account account = new Account();
            Console.Write("Firtname: ");
            account.Fristname = Console.ReadLine();
            Console.Write("Lastname: ");
            account.Lastname = Console.ReadLine();
            Console.Write("Gender: ");
            account.Gender = Console.ReadLine();
            account.AccountId = ++id;
            Bank.Add(id, account);
            Console.WriteLine("Acount Ok");
        }
        public static void ShowData()
        {
            string str = "AccountId\tFirtname\tLastname\tGender\tBalance\n";
            foreach (Account account in Bank.Values)
            {
                str += $"\n{account.ShowInfo()}";
            }
            Console.WriteLine(str);
        }
        public static void PayInto()
        {
            try
            {
                Console.Write("Nhập AccountId: ");
                int accountid = int.Parse(Console.ReadLine());
                int ind = Check(accountid);
                if (ind != -1)
                {
                    float amount = 0;
                    do
                    {
                        Console.Write("Nhập số tiền chuyển vào: ");
                        float.TryParse(Console.ReadLine(), out amount);
                        if (amount == 0)
                        {
                            Console.WriteLine("Số tiền chuyển vào phải là 1 số lớn hơn 0");
                        }
                    } while (amount == 0);

                    Bank[ind].PayInto(amount);
                    Console.WriteLine("OKe");
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("AccountId là 1 số nguyên.Vui lòng nhập lại!");
                PayInto();
            }

        }
        public static int Check(int id)
        {
            foreach (int key in Bank.Keys)
            {
                if (key == id)
                {
                    return key;
                }
            }
            return -1;
        }

    }
}

