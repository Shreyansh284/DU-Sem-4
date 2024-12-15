using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    internal class Student
    {
        int Enrollment_No, Semester;
        double CPI, SPI;
        string Student_Name;

        public Student(int Enrollment_No,int Semester,string Student_Name, double CPI,double SPI)
        {
            this.Enrollment_No = Enrollment_No;
            this.Student_Name = Student_Name;
            this.Semester = Semester;
            this.CPI = CPI;
            this.SPI = SPI;

        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($" Enrollment_No : {Enrollment_No}, Semester : {Semester}, Student_Name : {Student_Name},  CPI : {CPI}, SPI : {SPI}");
        }

    }

}
