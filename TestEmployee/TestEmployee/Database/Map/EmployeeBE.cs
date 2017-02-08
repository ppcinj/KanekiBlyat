using System;

namespace TestEmployee.Database.Map
{
    public class EmployeeBE
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual int Workdays { get; set; }
        public virtual double Salary { get; set; }
    }
}
