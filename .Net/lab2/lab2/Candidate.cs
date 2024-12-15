using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Candidate
    {
        int id ,age;
        string name ;
        double weight, height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            height = double.Parse(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Id: {id} name: {name} age: {age} weight: {weight} height: {height}");
        }
    }
}
