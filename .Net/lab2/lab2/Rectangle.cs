using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Rectangle
    {
        int l, w;
        public Rectangle(int l,int w)
        {
            this.l = l; this.w = w;
        }
        public void Area()
        {
            Console.WriteLine($"\nRectangle Area: {l * w}");
        }

    }
}
