using System;
using System.Windows.Forms;
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
            Application.Run(new frmMain(new EmployeeDbFacade(), new EmployeeInputValidator()));
        }
    }
}
