using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Bank_Account
    {
        int Account_No, Account_Balance;
        string name,email,type;
   

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account_No");
            Account_No = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            Console.WriteLine("Enter Acc_Type");
            type = Console.ReadLine();
            Console.WriteLine("Enter Account_Balance");
            Account_Balance = int.Parse(Console.ReadLine());
          
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account_No: {Account_No} name: {name} email : {email} Balance: {Account_Balance} Type: {type}");
        }
    }
}
