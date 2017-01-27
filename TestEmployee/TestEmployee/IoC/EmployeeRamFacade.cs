using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEmployee.IoC
{
    public interface IEmployeeFacade
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void Edit(Employee employee);
        void Remove(Employee employee);
    }

    public class EmployeeRamFacade : IEmployeeFacade
    {
        private static List<Employee> Employees { get; set; }

        public static void Configure()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        public void AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            Employees.Add(employee);
        }

        public void Edit(Employee employee)
        {
            Employees.RemoveAll(x => x.Id == employee.Id);
            Employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            Employees.RemoveAll(x => x.Id == employee.Id);
        }
    }
}
