using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestEF3.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
       
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }

        public string StaffPhone { get; set; }
        public decimal StaffSalary { get; set; }

    }
}