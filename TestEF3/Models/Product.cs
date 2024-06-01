using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name Is Required")]
        [Display(Name = "Product Name")]
        public String ProductName { get; set; }
        public int UnitId { get; set; }
        public virtual Unit UnitName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category CategoryName { get; set; }
        public int Code { get; set; }

    }
}