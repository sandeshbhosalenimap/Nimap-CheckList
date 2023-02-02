using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ReffrenceDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList sm = new ArrayList(); 

            sm.Add(1);  
            sm.Add(2);
            sm.Add(3);

            

           LinkedList<string> list = new LinkedList<string>(); 

            list.AddFirst("a"); 
            list.AddFirst("b");
             foreach (string s in list) {
                Console.WriteLine(s);
            }
            

            Dictionary<int , string > dict = new Dictionary<int , string>();


            dict.Add(1, "sandesh");
            dict.Add(1, );

            foreach (var s in dict)
            {
               
                
                Console.WriteLine(s);
            }
                    

            List<string> t = new List<string>();   
            t.Add("a");
            

           

           

        }
    }
}
