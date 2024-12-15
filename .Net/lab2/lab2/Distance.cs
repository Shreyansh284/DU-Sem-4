using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public class Distance
{
    public double dist1, dist2, dist3;
    public Distance(double dist1, double dist2)
    {
        this.dist1 = dist1;
        this.dist2 = dist2;
        dist3 = 0;
    }

    public void CalculateAddition()
    {
        dist3 = dist1 + dist2;
    }

    public void DisplayAddition()
    {
        Console.WriteLine("The addition of dist1 and dist2 is: " + dist3);
    }
}
