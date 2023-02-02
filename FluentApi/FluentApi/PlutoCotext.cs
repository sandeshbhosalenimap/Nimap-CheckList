using FluentApi.EntityConfiguration;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FluentApi
{
    public partial class PlutoCotext : DbContext
    {
        public PlutoCotext()
            : base("name=PlutoCotext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {




            modelBuilder.Configurations.Add(new CourseConfiguration());




        }
    }
}
