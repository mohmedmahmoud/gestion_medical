using System;
using gestion_medical.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
namespace gestion_medical.Data
{
 

    public class AppDbContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurations supplémentaires pour les entités, le cas échéant

            modelBuilder.Entity<Medicine>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Sale>()
                .HasKey(s => s.Id);
        }
    }

}

