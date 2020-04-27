using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trash_Collector_Proj.Models;

namespace Trash_Collector_Proj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" });
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 1, Name = "Sunday" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 2, Name = "Monday" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 3, Name = "Tuesday" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 4, Name = "Wednesday" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 5, Name = "Thursday" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 6, Name = "Friday" });
            builder.Entity<WeekDay>()
                .HasData(new WeekDay { Id = 7, Name = "Saturday" });
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
    }
}
