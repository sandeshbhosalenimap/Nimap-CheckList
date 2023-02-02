using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace StackImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack sk = new Stack(); 
            sk.Push(1);
            sk.Push(2);
            sk.Push(3);
            sk.Push(5);


            foreach(var item in sk)
            {

                Console.WriteLine(item);
            }
           
            Console.WriteLine(sk.Peek());

        }
    }
}
