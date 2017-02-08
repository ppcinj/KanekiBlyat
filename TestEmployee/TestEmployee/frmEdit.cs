using System;
using System.Globalization;
using System.Windows.Forms;
using TestEmployee.ServiceLayer.Validation;

namespace TestEmployee
{
    public partial class frmEdit : Form
    {
        private readonly IEmployeeValidator _employeeValidator;
        public Employee MyEmployee { get; set; }
        public EditCloseAction Action { get; private set; }

        public frmEdit(IEmployeeValidator employeeValidator, Employee employee)
        {
            _employeeValidator = employeeValidator;
            MyEmployee = employee;
            Action = EditCloseAction.Discard;

            InitializeComponent();
            tbName.Text = MyEmployee.Name;
            tbSurname.Text = MyEmployee.Surname;
            tbWorkdays.Text = MyEmployee.Workdays.ToString();
            tbSalary.Text = MyEmployee.Salary.ToString(CultureInfo.InvariantCulture);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_employeeValidator.IsValid(tbName.Text, tbSurname.Text, tbWorkdays.Text, tbSalary.Text))
            {
                Action = EditCloseAction.Save;
                MyEmployee.Name = tbName.Text;
                MyEmployee.Surname = tbSurname.Text;
                MyEmployee.Workdays = int.Parse(tbWorkdays.Text);
                MyEmployee.Salary = double.Parse(tbSalary.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid information provided!");
            }
        }
    }

    public enum EditCloseAction
    {
        Discard,
        Save
    }
}
