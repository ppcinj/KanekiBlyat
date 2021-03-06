﻿using System;
using System.Windows.Forms;
using Autofac;
using TestEmployee.Autofac;

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

            using (var scope = AutofacConfiguration.Scope)
            {
                Application.Run(scope.Resolve<frmMain>());
            }
        }
    }
}
