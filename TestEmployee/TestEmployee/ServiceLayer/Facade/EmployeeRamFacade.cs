using System;
using System.Collections.Generic;

namespace TestEmployee.ServiceLayer.Facade
{
    public class EmployeeRamFacade : IEmployeeFacade
    {
        private static List<Employee> Employees { get; set; }

        static EmployeeRamFacade()
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
