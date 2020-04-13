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
    public partial class ProjectByName : Form
    {
        Controller controllerObj = new Controller();
        public ProjectByName()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllProjects();
            comboBoxPName.DataSource = dt;
            comboBoxPName.DisplayMember = "Pname";
            comboBoxPName.ValueMember = "Pnumber";
            comboBoxPName.SelectedIndex = -1;
            empCountLabel.Text = " ";
            hoursLabel.Text = " ";
        }

        private void ProjectByName_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxPName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            DataTable data = controllerObj.GetCountHoursProject(Convert.ToInt32(comboBoxPName.SelectedValue));
            empCountLabel.Text = Convert.ToString(data.Rows[0]["EmpCount"]);
            hoursLabel.Text = Convert.ToString(data.Rows[0]["TotHrs"]);
     
        }

        private void empCountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
