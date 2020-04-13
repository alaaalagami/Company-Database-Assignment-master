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
    public partial class UpdateProject : Form
    {
        Controller controllerObj = new Controller();
        public UpdateProject()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllProjects();
            comboBoxPName.DataSource = dt;
            comboBoxPName.DisplayMember = "Pname";
            comboBoxPName.ValueMember = "Pnumber";
            comboBoxPName.SelectedIndex = -1;
            dt = controllerObj.SelectDepartments();
            comboBoxDName.DataSource = dt;
            comboBoxDName.DisplayMember = "Dname";
            comboBoxDName.ValueMember = "Dnumber";
            comboBoxDName.SelectedIndex = -1;

        }

        private void UpdateProject_Load(object sender, EventArgs e)
        {

        }

        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            DataTable data = controllerObj.SelectProjectByNum(Convert.ToInt32(comboBoxPName.SelectedValue));
            Txt_PNumber.Text = Convert.ToString(comboBoxPName.SelectedValue);
            Txt_PLocation.Text = Convert.ToString(data.Rows[0]["Plocation"]);
            comboBoxDName.SelectedValue = Convert.ToString(data.Rows[0]["Dnum"]);
        }

        private void Btn_AddProject_Click(object sender, EventArgs e)
        {
            if (Txt_PNumber.Text == "" || Txt_PLocation.Text == "" || comboBoxDName.SelectedIndex < 0)
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.UpdateProject(comboBoxPName.Text, Convert.ToInt32(Txt_PNumber.Text), Txt_PLocation.Text, Convert.ToInt32(comboBoxDName.SelectedValue));
                if (r > 0)
                    MessageBox.Show("Project updated successfully");
                else
                    MessageBox.Show("Error updating project");
            }
        }
    }
}
