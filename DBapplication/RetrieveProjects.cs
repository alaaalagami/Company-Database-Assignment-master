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
    public partial class RetrieveProjects : Form
    {
        Controller controllerObj = new Controller();

        public RetrieveProjects()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectDepLoc();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dlocation";
            comboBox1.ValueMember = "Dlocation";
        }

        private void RetrieveProjects_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectProject((string)comboBox1.SelectedValue);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
