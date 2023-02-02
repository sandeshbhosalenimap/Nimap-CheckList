using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPL
{
    internal class Program
    {

        private static void MunltiCore()

        {
            string x = " ";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            // Thread a = new Thread(MunltiCore);

            // Thread a2 = new Thread(MunltiCore);

            // a2.Start();

            //  a.Start();
            Parallel.For(0, 10, x => MunltiCore());
           

        }
    }
}
