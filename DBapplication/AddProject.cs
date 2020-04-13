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
    public partial class AddProject : Form
    {
        Controller controllerObj = new Controller();
        public AddProject()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectDepNum_and_Name();
            ComboBox_DName.DataSource = dt;
            ComboBox_DName.DisplayMember = "Dname";
            ComboBox_DName.ValueMember = "Dnumber";
        }

        private void Btn_AddProject_Click(object sender, EventArgs e)
        {
            if (Txt_PName.Text == "" || Txt_PNumber.Text == "" || Txt_PLocation.Text == "" || ComboBox_DName.SelectedValue == null) //validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.InsertProject(Txt_PName.Text, Convert.ToInt32(Txt_PNumber.Text), Txt_PLocation.Text, Convert.ToInt32(ComboBox_DName.SelectedValue));
                if (r > 0)
                    MessageBox.Show("Project inserted successfully");
                else
                    MessageBox.Show("Error inserting project");
            }
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox_DName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
