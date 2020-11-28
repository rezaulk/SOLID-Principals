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
    }
}
