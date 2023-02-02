using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingFinal
{
    public  class Program
    {
        static void Main(string[] args)
        {

            var student = new DataBaseContext();


            //Lazy Loading
            var DataInStudent = student.CollageStudent.Single(c => c.StudentId ==1);

             
            var detailsnew  = student.CollageStudent.Include(c => c.Courses).ToList();

            //Egger Loading
            var allDetails = student.CollageStudent.Include(c => c.Courses.Single(  p => p.CourceName == "java")).ToList();
             foreach (var data in detailsnew) { 
                Console.WriteLine(data.StudentName  , data.Courses );    
            
            }
        }
    }
}
