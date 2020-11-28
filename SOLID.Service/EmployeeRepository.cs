using Microsoft.EntityFrameworkCore;
using SOLID.Enitites;
using SOLID.Infrustructure;
using SOLID.Manager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Service
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SolidDBContext _dbContext;

        public EmployeeRepository(SolidDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteEmployee(int productId)
        {
            var product = _dbContext.Employees.Find(productId);
            _dbContext.Employees.Remove(product);
            Save();
        }

        public Employee GetEmployeeById(int productId)
        {
            return _dbContext.Employees.Find(productId);
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return _dbContext.Employees.ToList();
        }
        public void InsertEmployee(Employee product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void UpdateEmployee(Employee product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

     
    }
}
