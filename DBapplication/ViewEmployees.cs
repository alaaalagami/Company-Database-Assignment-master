using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ViewEmployees : Form
    {
        private Controller controllerObj;

        private Privileges _privilege;

        public ViewEmployees(Privileges privilege = Privileges.Others)
        {
            InitializeComponent();
            _privilege = privilege;
            if(_privilege == Privileges.Others)
            {
                insertButton.Enabled = false;
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            sexComboBox.SelectedIndex = 0;
            UpdateDepartmentCheckedBoxList();
            DataTable res =  controllerObj.SelectEmployeeNames();
            employeeListBox.DisplayMember = "Name";
            employeeListBox.ValueMember = "SSN";
            employeeListBox.DataSource = res;
            employeeListBox.Update();
        }

        private void UpdateDepartmentCheckedBoxList()
        {
            departmentCheckedListBox.DataSource = controllerObj.SelectDepartments();
            departmentCheckedListBox.DisplayMember = "Dname";
            departmentCheckedListBox.Refresh();
        }

        private void UpdateEmployeeList()
        {
            List<int> departments = new List<int>();
            foreach (DataRowView dept in departmentCheckedListBox.CheckedItems)
                departments.Add((int)dept.Row["Dnumber"]);
            DataTable result = controllerObj.SelectEmployeeNamesBySearch(nameTextBox.Text, 
                new string[] {"","M","F" }[sexComboBox.SelectedIndex], (bool?)isManagerCheckBox.Checked,departments);
            employeeListBox.DisplayMember = "Name";
            employeeListBox.ValueMember = "SSN";
            employeeListBox.DataSource = result;
            employeeListBox.Update();
        }

        private void employeeListBox_DoubleClick(object sender, EventArgs e)
        {
            int ssn = (int)employeeListBox.SelectedValue;
            EmployeeForm empForm = new EmployeeForm(ssn, _privilege);
            empForm.Show();
        }

        private void insetButton_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm(null,Privileges.Admin);
            empForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            UpdateEmployeeList();
        }

        private void uncheckAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < departmentCheckedListBox.Items.Count; i++)
                departmentCheckedListBox.SetItemChecked(i, false);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
