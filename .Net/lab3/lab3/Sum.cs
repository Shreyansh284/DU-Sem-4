using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Sum
    {
       
        abstract public void SumOfTwo(int x, int y);
        abstract public void SumOfThree(int x, int y,int z);
    

    }

    class Calculate : Sum {

        override
        public void SumOfTwo(int x, int y)
        {
            Console.WriteLine("Sum of Two :  " + (x + y));
        }
        override
        public void SumOfThree(int x, int y,int z)
        {
            Console.WriteLine("Sum of Three : " + (x + y+z));
        }

    }
}
