using Autofac;
using NHibernate;
using TestEmployee.Database;
using TestEmployee.Database.Repo;
using TestEmployee.IoC;

namespace TestEmployee.Autofac
{
    public static class AutofacConfiguration
    {
        public static ILifetimeScope GetLifetimeScope()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<EmployeeDbFacade>().As<IEmployeeFacade>();
            containerBuilder.RegisterType<EmployeeInputValidator>().As<IEmployeeValidator>();
            containerBuilder.RegisterType<frmMain>();
            containerBuilder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();

            containerBuilder.RegisterInstance(NHConfig.Session).As<ISession>();

            return containerBuilder.Build().BeginLifetimeScope();
        }
    }
}
