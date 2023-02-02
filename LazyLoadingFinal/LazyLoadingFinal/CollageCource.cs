using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LazyLoadingFinal
{
    public  class CollageCource
    {

        [Key]
        public int CourceId {  get; set; }  

        public string CourceName { get; set; }        
    }
}
