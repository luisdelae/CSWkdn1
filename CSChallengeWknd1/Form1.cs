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
        //List<List<string>> empDataList = new List<List<string>>();

        List<string> empDataList = new List<string>();

        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            empSalaryCostMonthly += Convert.ToDouble(txtSalary.Text);
            lblCostOfSalaryMonthly.Text = "$" + Convert.ToString(empSalaryCostMonthly);

            //Might need to add an array instead of strings to be able to delete the list.selectedindex 
            //at the selected item, and delete index at [4] of this selected item for it to
            //subtract the salary from the total once the employee is deleted
            empDataList.Add(txtId.Text + "\t\t" + txtFirstName.Text + "\t\t" + txtLastName.Text + "\t\t" + txtTitle.Text + "\t\t" + txtSalary.Text + "\n");
            //List<string> empInfo = new List<string> { Convert.ToString(txtId), Convert.ToString(txtFirstName), Convert.ToString(txtLastName)
            //    , Convert.ToString(txtTitle), Convert.ToString(txtSalary) };
            //empDataList.Add(empInfo);
            lstEmployeeData.DataSource = empDataList.ToList();
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        { 
            empDataList.RemoveAt(lstEmployeeData.SelectedIndex);

            //empSalaryCostMonthly -= Convert.ToDouble(empDataList[lstEmployeeData.SelectedIndex]);
            //lblCostOfSalaryMonthly.Text = Convert.ToString(empSalaryCostMonthly);

            lstEmployeeData.DataSource = null;
            lstEmployeeData.DataSource = empDataList.ToArray();
        }
    }
}