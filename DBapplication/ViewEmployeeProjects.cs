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
    public partial class ViewEmployeeProjects : Form
    {

        private int _ssn;
        private Controller controllerObj;

        public ViewEmployeeProjects(int ssn)
        {
            InitializeComponent();
            _ssn = ssn;
        }

        private void ViewEmployeeProjects_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataRow employee = controllerObj.SelectEmployeeBySSN(_ssn).Rows[0];
            label1.Text = "Name: " + employee["Fname"] + " " + employee["Minit"] + ". " + employee["Lname"];
            dataGridView1.DataSource = controllerObj.SelectProjectsEmployeeWorksOn(_ssn);
            dataGridView1.Refresh();
        }
    }
}
