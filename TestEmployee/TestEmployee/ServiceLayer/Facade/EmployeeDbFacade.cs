using System.Collections.Generic;
using System.Linq;
using TestEmployee.Database.Map;
using TestEmployee.Database.Repo;

namespace TestEmployee.ServiceLayer.Facade
{
    public class EmployeeDbFacade : IEmployeeFacade
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeDbFacade(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees().Select(Map).ToList();
        }

        public void AddEmployee(Employee employee)
        {
            Edit(employee);
        }

        public void Edit(Employee employee)
        {
            _employeeRepository.SaveOrUpdate(Map(employee));
        }

        public void Remove(Employee employee)
        {
            _employeeRepository.Remove(Map(employee));
        }

        private EmployeeBE Map(Employee e)
        {
            var emp = _employeeRepository.GetEmployeeById(e.Id) ?? new EmployeeBE();
            emp.Name = e.Name;
            emp.Salary = e.Salary;
            emp.Surname = e.Surname;
            emp.Workdays = e.Workdays;
            return emp;
        }

        private Employee Map(EmployeeBE e)
        {
            return new Employee
            {
                Salary = e.Salary,
                Workdays = e.Workdays,
                Name = e.Name,
                Surname = e.Surname,
                Id = e.Id
            };
        }
    }
}
