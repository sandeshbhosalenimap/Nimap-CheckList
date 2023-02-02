using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderclass
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder("java");

            s.Append(".net");

          
            

            s.Append("GeeksForGeeks");
            s.AppendLine("GEEKS");

            Console.WriteLine(s);

        }
    }
}
