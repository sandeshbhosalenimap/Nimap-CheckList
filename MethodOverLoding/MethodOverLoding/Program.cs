using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoding
{
    
      public class Program 
    {
        int id;
        string Name;



        public void MethodOverloding111(int id, string name)
        {
            Console.WriteLine(id);
            Console.WriteLine(name);

        }

        public void MethodOverloding111(string name)
        {
            Console.WriteLine(name);

        }




        static void Main(string[] args)
        {
            Program p = new Program();  
            p.MethodOverloding111(1 ,"hello");
            p.MethodOverloding111( "tello");

        }
    }
}
