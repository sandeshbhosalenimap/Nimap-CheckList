using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUD_Operation_Sigle_Table.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Salary { get; set; }
        [Required]
        public string Department { get; set; }



    }
}