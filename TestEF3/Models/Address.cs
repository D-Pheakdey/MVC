using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public String AddressName { get; set; }
    }
}