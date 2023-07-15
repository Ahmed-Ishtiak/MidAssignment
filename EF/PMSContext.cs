using MidAssignment.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MidAssignment.EF
{
    public class PMSContext: DbContext
    {
        public DbSet<Restuarent>Restuarents { get; set; }
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Employee>Employees { get; set; }

        public System.Data.Entity.DbSet<MidAssignment.Models.RestuarentDTO> RestuarentDTOes { get; set; }
    }
    
    
}