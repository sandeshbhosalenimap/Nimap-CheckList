using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Out_And_Ref_Parameter
{
    internal class Program
    {


        public static void Out(out int a)
        {
            a = 10;
        }

        public static void Ref(ref int a)
        {
            a = 10;
        }
        public static void Main()
        {


            int a = 10; int b = 10; int c = 10; int d = 10; int e = 10;

            Out(out a);

            Ref(ref b);



        }
    }
}
