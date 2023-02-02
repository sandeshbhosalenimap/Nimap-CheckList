using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumbearble_Vs_IQuerable
{

   

    class Employee
    {
        private static object asqurable;
        int id;
        int salary;
        string name;
        string department;


       
        static void Main(string[] args)
        {

            
            List<Employee> emp = new List<Employee>()
                   {
          
        
                       new Employee{ id = 201, name = "Druva",
                                            salary = 12000, department = "HR" },
                        new Employee{ id = 202, name = "Deepu",
                                         salary = 15000, department = "Development" },
                         new Employee{ id = 203, name = "Manoja",
                                         salary = 13000, department = "HR" },
                         new Employee{ id = 204, name = "Sathwik",
                                            salary = 12000, department = "Designing" },
                      new Employee{ id = 205, name = "Suraj",
                                              salary = 15000, department = "Development" }
            };

            

             IEnumerable<Employee> result = emp.Where(x => x.salary >  12000);

              



            

             foreach (Employee e in result)
             {
                 Console.WriteLine(e.id + " " + e.name + " " + e.department + "  " + e.salary);
             }
         





        }
    }
}
