using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class EmployeeForm : Form
    {

        private int? _ssn;
        private Privileges _privilege;
        public int? SSN { get { return _ssn; } }

        private Controller controllerObj;

        public EmployeeForm(int? SSN, Privileges privilege = Privileges.Others)
        {
            InitializeComponent();
            _ssn = SSN;
            _privilege = privilege;
            if(_privilege == Privileges.Others)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void UpdateSuperComboBox()
        {
            superComboBox.DisplayMember = "Name";
            superComboBox.ValueMember = "SSN";
            superComboBox.DataSource = controllerObj.SelectEmployeeNames();
            superComboBox.Update();
        }

        private void UpdateDepartmentComboBox()
        {
            departmentComboBox.DisplayMember = "Dname";
            departmentComboBox.ValueMember = "Dnumber";
            departmentComboBox.DataSource = controllerObj.SelectDepartments();
            departmentComboBox.Update();
        }

        public void UpdateData()
        {
            DataRow employee = controllerObj.SelectEmployeeBySSN(SSN.GetValueOrDefault()).Rows[0];
            ssnNumericUpDown.Value = (int)employee["SSN"];
            fnameTextBox.Text = (string)employee["Fname"];
            minitTextBox.Text = employee["Minit"].ToString();
            lnameTextBox.Text = (string)employee["Lname"];
            addressTextBox.Text = (string)employee["Address"];
            if ((string)employee["Sex"] == "M")
            {
                maleRadioButton.Select();
            }
            else
                femaleRadioButton.Select();
            salaryNumericUpDown.Value = (int)employee["Salary"];
            birthDateTimePicker.Value = (System.DateTime)employee["Bdate"];
            if (employee["Super_SSN"] is System.DBNull)
            {
                superCheckBox.Checked = false;
                superComboBox.SelectedIndex = -1;
                superComboBox.ResetText();
                superComboBox.Enabled = false;
            }
            else
            {
                superCheckBox.Checked = true;
                superCheckBox.Enabled = true;
                superComboBox.SelectedValue = employee["Super_SSN"];
            }
            departmentComboBox.SelectedValue = employee["Dno"];

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            UpdateSuperComboBox();
            UpdateDepartmentComboBox();
            if (SSN != null)
            {
                UpdateData();
                button1.Text = "Update";
                ssnNumericUpDown.Enabled = false;
            }
            else
                button4.Enabled = false;
        }

        private void superCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (superCheckBox.Checked) superComboBox.Enabled = true;
            else
            {
                superComboBox.SelectedIndex = -1;
                superComboBox.ResetText();
                superComboBox.Enabled = false;

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (femaleRadioButton.Checked) sex = "F";
            else if (maleRadioButton.Checked) sex = "M";

            int? superSSN = null;
            if (superCheckBox.Checked) superSSN = (int)superComboBox.SelectedValue;

            int r;

            if (SSN != null)
            {
                 r = controllerObj.UpdateEmployee((int)SSN, fnameTextBox.Text,minitTextBox.Text.ToCharArray()[0], lnameTextBox.Text, birthDateTimePicker.Value,
                    addressTextBox.Text, sex, (int)salaryNumericUpDown.Value, (int)departmentComboBox.SelectedValue, superSSN);
                if (r > 0) MessageBox.Show("Employee Updated Successfully!");
                else MessageBox.Show("Error Updating Employee..");
            }
            else
            {
                if (fnameTextBox.Text == "" || minitTextBox.Text == "" || lnameTextBox.Text == "" || addressTextBox.Text == "" || 
                    sex == "" || (int)departmentComboBox.SelectedValue == -1 || (int)superComboBox.SelectedValue == -1)
                {
                    MessageBox.Show("Please Enter all required fields before inserting!");
                }
                else {
                    r = controllerObj.InsertEmployee((int)ssnNumericUpDown.Value, fnameTextBox.Text, minitTextBox.Text.ToCharArray()[0], lnameTextBox.Text, birthDateTimePicker.Value,
                       addressTextBox.Text, sex, (int)salaryNumericUpDown.Value, (int)departmentComboBox.SelectedValue, superSSN);
                    if (r > 0) MessageBox.Show("Employee Inserted Successfully!");
                    else MessageBox.Show("Error Inserting Employee..");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDepartmentComboBox();
            UpdateSuperComboBox();
            UpdateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteEmployee((int)ssnNumericUpDown.Value);
            if (r > 0) MessageBox.Show("Employee Deleted Successfully!");
            else MessageBox.Show("Error Deleting Employee..");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ssn = (int)superComboBox.SelectedValue;
            EmployeeForm empForm = new EmployeeForm(ssn, _privilege);
            empForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEmployeeProjects VF = new ViewEmployeeProjects((int)ssnNumericUpDown.Value);
            VF.Show();
        }
    }
}
