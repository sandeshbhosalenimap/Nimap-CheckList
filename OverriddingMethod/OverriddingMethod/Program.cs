using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverriddingMethod
{
    class OverRideClass
    {

        public virtual void MethodforOverrind()
        {
            Console.WriteLine("The Base Class");
        }
    }



    class Program : OverRideClass
    {
        public override void MethodforOverrind()
        {
            Console.WriteLine("The Driven Class Class");
        }

        static void Main(string[] args)
        {

            Program p = new Program();  
            p.MethodforOverrind();  
        }
    }
}
