using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Category { 
    
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name Is Required")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public string Note { get; set; }

    }
}