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
    public partial class UpdateDepartment : Form
    {
        Controller controllerObj = new Controller();
        public UpdateDepartment()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectDepartments();
            comboBoxDName.DataSource = dt;
            comboBoxDName.DisplayMember = "Dname";
            comboBoxDName.ValueMember = "Dnumber";
            comboBoxDName.SelectedIndex = -1;
        }

        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            DataTable data = controllerObj.SelectDepartmentByNum(Convert.ToInt32(comboBoxDName.SelectedValue));
            Txt_DNumber.Text = Convert.ToString(comboBoxDName.SelectedValue);
            Txt_MgrSSN.Text = Convert.ToString(data.Rows[0]["Mgr_SSN"]);
            dateTimePicker.Value = Convert.ToDateTime(data.Rows[0]["Mgr_Start_Date"]);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (Txt_DNumber.Text == "" || Txt_MgrSSN.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.UpdateDepartment(comboBoxDName.Text, Convert.ToInt32(Txt_DNumber.Text), Convert.ToInt32(Txt_MgrSSN.Text), dateTimePicker.Value);
                if (r > 0)
                {
                    string mydep = comboBoxDName.Text;
                    DataTable dt = controllerObj.SelectDepartments();
                    comboBoxDName.DataSource = dt;
                    comboBoxDName.DisplayMember = "Dname";
                    comboBoxDName.ValueMember = "Dnumber";
                    comboBoxDName.Text = mydep;
                    MessageBox.Show("Department updated successfully");
                }
                else
                    MessageBox.Show("Error updating department");
            }
        }
    }
}
