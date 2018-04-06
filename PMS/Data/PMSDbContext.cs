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
        public DbSet<Project> Projects { get; set; }

        public PMSDbContext(DbContextOptions<PMSDbContext> options) 
            : base(options)
        { }
    }
}
