using Autofac;
using NHibernate;
using TestEmployee.Database;
using TestEmployee.Database.Repo;
using TestEmployee.IoC;

namespace TestEmployee.Autofac
{
    public static class AutofacConfiguration
    {
        private static ILifetimeScope _scope;

        public static ILifetimeScope Scope => _scope ?? (_scope = GetLifetimeScope());

        private static ILifetimeScope GetLifetimeScope()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<EmployeeDbFacade>().As<IEmployeeFacade>();
            containerBuilder.RegisterType<EmployeeInputValidator>().As<IEmployeeValidator>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();

            containerBuilder.RegisterAssemblyTypes(typeof(Employee).Assembly)
                .Where(t => t.Name.StartsWith("frm"));

            containerBuilder.RegisterType<frmEdit>().WithParameter(new TypedParameter(typeof(Employee), "employee"));

            containerBuilder.RegisterInstance(NHConfig.Session).As<ISession>();

            return containerBuilder.Build().BeginLifetimeScope();
        }
    }
}
