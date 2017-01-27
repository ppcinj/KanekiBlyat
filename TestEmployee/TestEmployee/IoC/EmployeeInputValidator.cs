using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployee.IoC
{
    public interface IEmployeeValidator
    {
        bool IsValid(string name, string surname, string workdays, string salary);
    }

    public class EmployeeInputValidator : IEmployeeValidator
    {
        public bool IsValid(string name, string surname, string workdays, string salary)
        {
            int outWorkdays;
            double outSalary;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                return false;

            return int.TryParse(workdays, out outWorkdays) && double.TryParse(salary, out outSalary);
        }
    }
}
