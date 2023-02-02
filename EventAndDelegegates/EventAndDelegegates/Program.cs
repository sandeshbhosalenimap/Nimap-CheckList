using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegegates
{


    public delegate void Tranformer(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a Number");
            int i =  int.Parse(Console.ReadLine());

            Tranformer t;
            t = Squre;

            t += Cober;

            t.Invoke(i);


            NotificationMaethod obj  = new NotificationMaethod();

               obj.transformerEvent += User1.Xhandker;

                obj.transformerEvent += User2.Yhandker;
            obj.NotifyOnCell(i);
            Console.ReadLine(); 
        }

        static void Squre(int x) {
            Console.WriteLine("in Squrfe ");
        }

        static void Cober(int x) {
            Console.WriteLine("in Cube ");
        }
    }

    class NotificationMaethod
    {
        public event Tranformer transformerEvent;

        public void NotifyOnCell(int x) 
        { 

            if(transformerEvent != null)
            {
                transformerEvent(x);
            }
            
        }


    }

    class User1
    {
        public static void Xhandker(int x) {
            Console.WriteLine("Event Recived by user 1111  ine ibject" + x);
        }
    }
    class User2
    {
        public static void Yhandker(int x)
        {
            Console.WriteLine("Event Recived by user  ine ibject");
        }
    }


}
