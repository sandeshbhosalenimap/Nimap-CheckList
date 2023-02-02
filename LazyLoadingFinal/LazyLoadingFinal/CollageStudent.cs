using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingFinal
{
    public  class CollageStudent
    {


        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string StudentDescription { get; set; }

        public virtual  List<CollageCource> Courses { get; set; }        


    }
}
