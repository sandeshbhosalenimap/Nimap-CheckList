using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;

                string sm = string.Format("the sum of {0} and {1} is {2}" , a,b,(a+b));
                Console.WriteLine(sm);


            Console.WriteLine($"The sum of {a} and {b} id {a+b}");



        }
    }
}
