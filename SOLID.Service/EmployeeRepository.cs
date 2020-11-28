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
            Employee employee = new Employee();

            Designation designation = new HR();
            //For Hr
            employee.Designation = designation.GetDesignation();

            //For Manager
            designation = new Manager();
            employee.Designation = designation.GetDesignation();


            

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


    public class Bonus
    {
        public virtual double GetSalaryDiscount(double amount)
        {
            return amount + 2500;
        }
    }

    public class SenirEmployee : Bonus
    {
        public override double GetSalaryDiscount(double amount)
        {
            return base.GetSalaryDiscount(amount) + 5000;
        }
    }
    public class MidEmployee : Bonus
    {
        public override double GetSalaryDiscount(double amount)
        {
            return base.GetSalaryDiscount(amount) + 3000;
        }
    }




    public abstract class Designation
    {
        public abstract string GetDesignation();
    }
    public class HR : Designation
    {
        public override string GetDesignation()
        {
            return "HR";
        }
    }
    public class Manager : Designation
    {
        public override string GetDesignation()
        {
            return "Manager";
        }
    }




    public interface ICommonTasks
    {
        void JoinMeeting(string meeting);
        void Presentation(string presentation);
    }
    interface ISeniorTasks
    {
        void WorldTour(string tour);
    }
    interface IJuniorTasks
    {
        void WordUpdateInExcel(string update);
    }

    public class Senior : ICommonTasks, ISeniorTasks
                                   
    {
        public void JoinMeeting(string PrintContent)
        {
            Console.WriteLine("Senior Meeting Done");
        }
        public void Presentation(string ScanContent)
        {
            Console.WriteLine("Senior Presentation Done");
        }
        public void WorldTour(string FaxContent)
        {
            Console.WriteLine("Senior World Done");
        }
    }
 
    public class Junior : IJuniorTasks
    {
        public void JoinMeeting(string PrintContent)
        {
            Console.WriteLine("Junior Meeting Done");
        }
        public void Presentation(string ScanContent)
        {
            Console.WriteLine("Junior Presention Done");
        }
        public void WordUpdateInExcel(string ScanContent)
        {
            Console.WriteLine("Work Update Done");
        }


    }




}
