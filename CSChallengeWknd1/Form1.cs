using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSChallengeWknd1
{
    public partial class frmEmployees : Form
    {
        double empSalaryCostMonthly = 0;

        List<Employee> empDataList = new List<Employee>();

        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            empSalaryCostMonthly += Convert.ToDouble(txtSalary.Text);
            lblCostOfSalaryMonthly.Text = "$" + Convert.ToString(empSalaryCostMonthly/12);

            empDataList.Add(new Employee
            {
                EmpID = Convert.ToInt32(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                Salary = Convert.ToDouble(txtSalary.Text)
            });
            
            lstEmployeeData.DataSource = empDataList.ToList();
            
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            empSalaryCostMonthly -= empDataList[lstEmployeeData.SelectedIndex].Salary;
            lblCostOfSalaryMonthly.Text = Convert.ToString(empSalaryCostMonthly/12);

            empDataList.RemoveAt(lstEmployeeData.SelectedIndex);

            lstEmployeeData.DataSource = null;
            lstEmployeeData.DataSource = empDataList.ToArray();
        }
    }
}