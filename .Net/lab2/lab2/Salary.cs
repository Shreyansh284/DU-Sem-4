using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public class Salary
{
    public double Basic;
    public double TA;
    public double DA;
    public double HRA;

    public Salary(double Basic, double TA, double DA = 1000.00, double HRA = 2000.00)
    {
        this.Basic = Basic;
        this.TA = TA;
        this.DA = DA;
        this.HRA = HRA;
    }

    public double CalculateSalary()
    {
        return Basic + TA + DA + HRA;
    }

    public void DisplaySalaryDetails()
    {
        Console.WriteLine($"\nBasic Salary: {Basic}");
        Console.WriteLine($"TA (Transport Allowance): {TA}");
        Console.WriteLine($"DA (Dearness Allowance): {DA}");
        Console.WriteLine($"HRA (House Rent Allowance): {HRA}");
        Console.WriteLine($"Total Salary: {CalculateSalary()}");
    }
}
