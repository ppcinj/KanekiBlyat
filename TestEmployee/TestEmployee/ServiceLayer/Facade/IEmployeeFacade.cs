using System.Collections.Generic;

namespace TestEmployee.ServiceLayer.Facade
{
    public interface IEmployeeFacade
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void Edit(Employee employee);
        void Remove(Employee employee);
    }
}
