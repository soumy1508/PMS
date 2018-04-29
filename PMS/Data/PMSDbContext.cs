using Microsoft.EntityFrameworkCore;
using PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Data
{
    public class PMSDbContext : DbContext
    {
        public DbSet<PMS.Models.Project> Projects { get; set; }
        public DbSet<PMS.Models.Task> Tasks { get; set; }
       
        

        public PMSDbContext(DbContextOptions<PMSDbContext> options) 
            : base(options)
        { }

        

    }
}
