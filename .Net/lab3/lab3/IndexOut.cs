using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class IndexOut
    {
        public void check()
        {
            int[] arr = new int[5];
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine("Enter Value : " + (i + 1));
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                        
            }
        }

    }
}
