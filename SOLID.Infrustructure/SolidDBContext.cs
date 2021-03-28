using Microsoft.EntityFrameworkCore;
using SOLID.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Infrustructure
{
    public class SolidDBContext: DbContext
    {
     
        public SolidDBContext(DbContextOptions<SolidDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name="AB",
                    Designation = "Senior",
                    Address = "Dhaka",
                },
                new Employee
                {
                    Id = 2,
                    Name= "ABC",
                    Designation = "Senior",
                    Address = "Dhaka",
                },
                new Employee
                {
                    Id = 3,
                    Name= "ABCD",
                    Designation = "Grocery",
                    Address = "Grocery Items",
                }
            );
        }
    }
}
