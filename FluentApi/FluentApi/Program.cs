using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Context = new PlutoCotext();
            var course =  Context.Courses.Single(c => c.Id == 1);
           
            foreach(var tag in course.Tags)
            {
                Console.WriteLine(tag.Name);
            }
        }
    }
}
