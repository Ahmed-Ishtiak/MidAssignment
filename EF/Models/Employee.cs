using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MidAssignment.EF.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

       
        //public Restuarent restuarent { get; set; }

        public virtual List<Restuarent> Restuarents { get; set;}
    }
}