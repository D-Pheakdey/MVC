using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        [Required(ErrorMessage = "Unit Name Is Required")]
        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }
        public string UnitPrice { get; set; }
        
    }
}