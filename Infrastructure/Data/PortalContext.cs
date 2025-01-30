using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options)
            : base(options)
        {
        }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<Titulo> Titulo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>().HasKey(t => t.Id);
            modelBuilder.Entity<Titulo>().HasKey(t => t.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
