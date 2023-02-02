using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_Operation_Sigle_Table.Models
{
    public class ServiceContext :DbContext
    {

        public DbSet<Employee> Employee { get; set; }
        


        public DbSet<UserLogIn> UserLogIn { get; set; }
    }
}