using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Object_Dyanamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var java = "sandesh";

            java = "sandesh" + "dac";

            dynamic net = "sandesh";

            net = "sandesh" + "dac";

            net = 10;


            object c = "sandesh";

            c = "sandesh" + "dac";

            c = 10;


        }
    }
}
