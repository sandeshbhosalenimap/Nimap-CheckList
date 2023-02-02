using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingFinal
{
    public  class DataBaseContext : DbContext
    {

        public DbSet<CollageCource> CollageCource { get;set; }


        public DbSet<CollageStudent> CollageStudent { get; set; }


    }
}
