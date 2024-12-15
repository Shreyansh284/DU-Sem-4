using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

class Account_Details
{
    public string AccountHolder;
    public double Balance;
    public double InterestRate;

    public Account_Details(string AccountHolder, double Balance, double InterestRate)
    {
        this.AccountHolder = AccountHolder;
        this.Balance = Balance;
        this.InterestRate = InterestRate;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}

class Interest : Account_Details
{
    public Interest(string AccountHolder, double Balance, double InterestRate)
        : base(AccountHolder, Balance, InterestRate)
    { }
    public void CalculateAndDisplayInterest()
    {
        double totalInterest = Balance * InterestRate / 100;
        Console.WriteLine($"Total Interest: {totalInterest}");
    }
}
