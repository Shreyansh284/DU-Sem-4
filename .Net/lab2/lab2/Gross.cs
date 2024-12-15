using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public interface Gross
{
    double Gross_sal();
}

class Salary2 : Gross
{
    public double HRA, TA, DA;
    public Salary2(double HRA, double TA, double DA)
    {
        this.HRA = HRA;
        this.TA = TA;
        this.DA = DA;
    }

    public void Disp_sal()
    {
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("TA: " + TA);
        Console.WriteLine("DA: " + DA);
    }

    public double Gross_sal()
    {
        return HRA + TA + DA;
    }
}

class Employee : Gross
{
    public string Name;
    public double Basic_Salary;

    public Employee(string name, double basic_salary)
    {
        Name = name;
        Basic_Salary = basic_salary;
    }

    public void basic_sal()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Basic Salary: " + Basic_Salary);
    }

    public double Gross_sal()
    {
        return Basic_Salary;
    }
}
