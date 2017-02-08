using System;
using System.Windows.Forms;
using Autofac;
using NHibernate;
using TestEmployee.Autofac;
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

            using (var scope = AutofacConfiguration.GetLifetimeScope())
            {
                Application.Run(scope.Resolve<frmMain>());
            }
        }
    }
}
