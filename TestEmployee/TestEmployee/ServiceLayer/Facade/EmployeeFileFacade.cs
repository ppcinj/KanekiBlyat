using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TestEmployee.ServiceLayer.Facade
{
    public class EmployeeFileFacade : IEmployeeFacade
    {
        private const string FileName = "employee.db";

        static EmployeeFileFacade()
        {
            if (!File.Exists(FileName))
                Create();
        }

        private static void Create()
        {
            File.Create(FileName).Close();
        }

        private List<Employee> GetFileContent()
        {
            try
            {
                var readObject = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(FileName));

                return readObject ?? new List<Employee>();
            }
            catch (JsonSerializationException)
            {
                File.Delete(FileName);
                Create();
                return GetFileContent();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return GetFileContent();
        }

        public void AddEmployee(Employee employee)
        {
            var employees = GetFileContent();
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            File.WriteAllText(FileName, JsonConvert.SerializeObject(employees));
        }

        public void Edit(Employee employee)
        {
            var list = GetAllEmployees();
            list.RemoveAll(x => x.Id == employee.Id);
            list.Add(employee);
            File.WriteAllText(FileName, JsonConvert.SerializeObject(list));
        }

        public void Remove(Employee employee)
        {
            var list = GetAllEmployees();
            list.RemoveAll(x => x.Id == employee.Id);
            File.WriteAllText(FileName, JsonConvert.SerializeObject(list));
        }
    }
}
