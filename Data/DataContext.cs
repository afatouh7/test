using EmpApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LineofBusiness> LineofBusinesses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(c => c.Id);
            modelBuilder.Entity<Employee>().HasKey(c => c.Name);
            modelBuilder.Entity<Employee>().HasKey(c => c.NationalId);
            modelBuilder.Entity<Employee>().HasKey(c => c.DateofBirth);
            modelBuilder.Entity<Employee>().HasKey(c => c.Age);
            modelBuilder.Entity<Account>().HasKey(c => c.Id);
            modelBuilder.Entity<Account>().HasKey(c => c.Name);
            modelBuilder.Entity<LineofBusiness>().HasKey(c => c.Id);
            modelBuilder.Entity<LineofBusiness>().HasKey(c => c.Name);


        }
    }
}
