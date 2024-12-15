using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface Calculate2
    {
       abstract void  Addition(int x,int y);
       abstract void Subtraction(int x, int y);
    }

    class Result : Calculate2
    {
        
        public void Addition(int x, int y)
        {
            Console.WriteLine("Add : "+(x + y));
        }
        public void Subtraction(int x, int y)
        {
            Console.WriteLine("sub : " + (x - y));
        }
    }
}
