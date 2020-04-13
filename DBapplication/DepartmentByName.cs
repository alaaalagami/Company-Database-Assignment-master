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
    public partial class DepartmentByName : Form
    {

        Controller controllerObj = new Controller();
        public DepartmentByName()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectDepartments();
            comboBoxDName.DataSource = dt;
            comboBoxDName.DisplayMember = "Dname";
            comboBoxDName.ValueMember = "Dnumber";
            comboBoxDName.SelectedIndex = -1;
            empCountLabel.Text = " ";
        }

        private void DepartmentByName_Load(object sender, EventArgs e)
        {
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            DataTable data = controllerObj.GetCountDepartment(Convert.ToInt32(comboBoxDName.SelectedValue));
            DataTable data2 = controllerObj.GetProjectsDepartment(Convert.ToInt32(comboBoxDName.SelectedValue));
            empCountLabel.Text = Convert.ToString(data.Rows[0]["EmpCount"]);
            projectsList.DataSource = data2;
            projectsList.DisplayMember = "Pname";
        }

        private void projectsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
