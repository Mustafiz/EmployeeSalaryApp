using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryAppUI : Form
    {
        public EmployeeSalaryAppUI()
        {
            InitializeComponent();
        }

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Name = employeeNameTextBox.Text;
            anEmployee.Basic = Convert.ToDouble(basicAmountTextBox.Text);
            anEmployee.HouseRent = Convert.ToDouble(houseRentTextBox.Text);
            anEmployee.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double salary = anEmployee.GetSalary();

            MessageBox.Show(anEmployee.Name + " your salary is: " + salary);
        }
    }
}
