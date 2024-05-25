using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Client Name Is Required")]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}