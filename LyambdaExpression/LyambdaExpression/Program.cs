using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LyambdaExpression
{
    class Student
    {

       
        public int rollNo{ get; set; }

        public string name
        {
            get;
            set;
        }
    }

    class GFG
    {

      
        static void Main(string[] args)
        {
            
            List<Student> details = new List<Student>() {
            new Student{ rollNo = 1, name = "Liza" },
                new Student{ rollNo = 2, name = "Stewart" },
                new Student{ rollNo = 3, name = "Tina" },
                new Student{ rollNo = 4, name = "Stefani" },
                new Student { rollNo = 5, name = "Trish" }
        };

               var sandesh  =  details.FindAll(x => x.rollNo > 1);
            
             foreach(var student in sandesh) {
                Console.WriteLine(student.name);
            }


        }
    }
}
