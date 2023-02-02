using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumberable_And_Enumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); 
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(17);

            IEnumerable<int> sm = (IEnumerable<int>)primeNumbers;

            IEnumerator<int> ssmm = primeNumbers.GetEnumerator(); 




            while (ssmm.MoveNext())
            {
                int n = ssmm.Current;
                if(n > 7)
                Console.WriteLine(n);   
            }

            
        }
    }
}
