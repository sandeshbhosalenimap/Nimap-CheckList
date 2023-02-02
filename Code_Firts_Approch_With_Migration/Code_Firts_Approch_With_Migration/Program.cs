using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Code_Firts_Approch_With_Migration
{
    public class Course
    {
        public int Id { get; set; }
        public string Tital { get; set; }
        public string Description { get; set; }

        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }

        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }

    public class Author
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }

    public class Tag
    {


        public int Id { get; set; }
            public string Name { get; set; }
        public IList<Course> Courses { get; set; }  
    }
    public enum CourseLevel
    {
        Beginner = 1,
        Intermediate = 2 , 
        Advanced = 3 
    }


    public class DatabasesConetxt : DbContext
    {
        public DbSet<Course> Courses { get; set; }


        public DbSet<Tag> Tags { get; set;}
        public DbSet<Author> Authors { get; set; }





    }

    public  class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
