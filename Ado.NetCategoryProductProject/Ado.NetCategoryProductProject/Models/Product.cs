﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ado.NetCategoryProductProject.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }


        public string ProductName { get; set; }    


        public string ProductDescription { get; set; }


         public int ProductPrise { get; set; }

         public int CategoryId { get; set; }
    }
}