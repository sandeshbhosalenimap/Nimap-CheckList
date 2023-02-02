using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] age = { 1, 2,3,4,5,6,7,8,9,8,6,5,5,4,4,32,2,8786 };   
            
            var Result =  from i in age where i > 7 select i;
            foreach ( var item in Result )
            {
                Console.WriteLine(item);    
            }  
        }
    }
}
