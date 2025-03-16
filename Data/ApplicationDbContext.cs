using EF_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Data
{
    class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFProject512;" +
                "Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Product>()
                .Property(e => e.Quantity)
                .HasColumnType("real");

            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true);
        }
    }
}
