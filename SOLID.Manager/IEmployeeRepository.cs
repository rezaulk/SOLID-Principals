using SOLID.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Manager
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployee();

        Employee GetEmployeeById(int ProductId);

        void InsertEmployee(Employee product);
        void DeleteEmployee(int product);
        void UpdateEmployee(Employee product);
        void Save();
    }
}
