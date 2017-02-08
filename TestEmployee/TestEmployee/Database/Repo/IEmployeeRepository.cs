using System;
using System.Collections.Generic;
using TestEmployee.Database.Map;

namespace TestEmployee.Database.Repo
{
    public interface IEmployeeRepository
    {
        IList<EmployeeBE> GetAllEmployees();
        EmployeeBE GetEmployeeById(Guid id);
        void Remove(EmployeeBE e);
        void SaveOrUpdate(EmployeeBE e);
    }
}