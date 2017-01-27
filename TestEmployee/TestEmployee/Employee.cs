using System;

namespace TestEmployee
{
    public class Employee
    {
        public Employee()
        {
            Name = string.Empty;
            Surname = string.Empty;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Workdays { get; set; }
        public double Salary { get; set; }
        public Guid Id { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} [{Workdays} -> {Salary}]";
        }
    }
}
