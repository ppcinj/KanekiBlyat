using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using Autofac.Core;
using TestEmployee.Autofac;
using TestEmployee.ServiceLayer.Facade;
using TestEmployee.ServiceLayer.Validation;

namespace TestEmployee
{
    public partial class frmMain : Form
    {
        private readonly IEmployeeFacade _employeeFacade;
        private readonly IEmployeeValidator _employeeValidator;

        public frmMain(IEmployeeFacade employeeFacade, IEmployeeValidator employeeValidator)
        {
            _employeeFacade = employeeFacade;
            _employeeValidator = employeeValidator;
            InitializeComponent();
            RebuildList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newEmployee = EditEmployee(new Employee());

            if (newEmployee == null) return;

            _employeeFacade.AddEmployee(newEmployee);
            RebuildList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex == -1) return;

            var newEmployee = EditEmployee((Employee) lbEmployees.SelectedItem);

            if (newEmployee == null) return;

            _employeeFacade.Edit(newEmployee);
            RebuildList();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            RebuildList();
        }

        private void lbEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                var selectedEmployee = (Employee) lbEmployees.SelectedItem;
                lblName.Text = selectedEmployee.Name;
                lblSurname.Text = selectedEmployee.Surname;
                lblWorkdays.Text = selectedEmployee.Workdays.ToString();
                lblSalary.Text = selectedEmployee.Salary.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                lblName.Text = string.Empty;
                lblSurname.Text = string.Empty;
                lblWorkdays.Text = string.Empty;
                lblSalary.Text = string.Empty;
            }
        }

        private void RebuildList()
        {
            lbEmployees.Items.Clear();
            _employeeFacade.GetAllEmployees()
                .Where(employee => 
                    employee.ToString().ToLower().Contains(tbFilter.Text.ToLower()))
                .OrderBy(employee => employee.ToString())
                .ToList()
                .ForEach(employee => lbEmployees.Items.Add(employee));
        }

        private Employee EditEmployee(Employee employee)
        {
            var addForm = AutofacConfiguration.Scope.Resolve<frmEdit>(new List<Parameter>()
            {
                new NamedParameter("employee", employee)
            });

            addForm.ShowDialog();
            return addForm.Action == EditCloseAction.Save ? addForm.MyEmployee : null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex == -1) return;

            if (
                MessageBox.Show("Are you sure, that you want to remove the employee?", "Remove",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _employeeFacade.Remove((Employee)lbEmployees.SelectedItem);
                RebuildList();
                lbEmployees_SelectedValueChanged(null, null);
            }
        }
    }
}
