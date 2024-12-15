using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Staff
    {
       public string name,department,designation;
       public  int experience, salary;

        public void GetStaffDetails()
        {


            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department");
            department = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Experience ");
            experience = int.Parse(Console.ReadLine());
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine($" name: {name} Department: {department} Designation: {designation} Experince: {experience} Salary : {salary}");
        }


    }
}
