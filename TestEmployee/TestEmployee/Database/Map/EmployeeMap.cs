using FluentNHibernate.Mapping;

namespace TestEmployee.Database.Map
{
    public class EmployeeMap : ClassMap<EmployeeBE>
    {
        public EmployeeMap()
        {
            Table("Employee");
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.Name);
            Map(x => x.Salary);
            Map(x => x.Surname);
            Map(x => x.Workdays);
        }
    }
}
