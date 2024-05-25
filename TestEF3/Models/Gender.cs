using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }

        public String GenderName { get; set; }
    }
}