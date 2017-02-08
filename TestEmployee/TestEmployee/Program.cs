using System;
using System.Windows.Forms;
using Autofac;
using NHibernate;
using TestEmployee.Database;
using TestEmployee.IoC;

namespace TestEmployee
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EmployeeRamFacade.Configure();
            EmployeeFileFacade.Configure();

            // Autofac
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<EmployeeDbFacade>().As<IEmployeeFacade>();
            containerBuilder.RegisterType<EmployeeInputValidator>().As<IEmployeeValidator>();
            containerBuilder.RegisterType<frmMain>();
            containerBuilder.RegisterAssemblyTypes(typeof(Employee).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .PropertiesAutowired();
            containerBuilder.RegisterInstance(NHConfig.Session).As<ISession>();
            var container = containerBuilder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.Run(scope.Resolve<frmMain>());
            }
        }
    }
}
