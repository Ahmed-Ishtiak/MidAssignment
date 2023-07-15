using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MidAssignment.EF.Models
{
    public class Admin
    {
        [Key]
        public int AId { get; set; }
        public string Status { get; set; }
        [ForeignKey("Restuarent")]
        public int Id { get; set; }
        public virtual Restuarent Restuarent { get; set; }
        
        public virtual ICollection<Restuarent>Restuarents { get; set; }

        public Admin()
        {
            Restuarents = new List<Restuarent>();
        }

    }
}