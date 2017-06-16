using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hermes.Domain;

namespace Hermes.Data
{
    public class HermesDbContext : DbContext
    {
        public DbSet<Call> Calls { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CallCategory> CallCategories { get; set; }
        public DbSet<CallPriority> CallPriorities { get; set; }
        public DbSet<CallStatus> CallStatus { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Hermes;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CallCategories>(entity =>
            //{

            //});
        }
    }
    
}
