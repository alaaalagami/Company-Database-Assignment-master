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
    public partial class AddDepartment : Form
    {
        Controller controllerObj = new Controller();
        public AddDepartment()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectEmployees();
            ComboBox_MName.DataSource = dt;
            ComboBox_MName.ValueMember = "SSN";
            ComboBox_MName.DisplayMember = "Name";
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void Btn_AddProject_Click(object sender, EventArgs e)
        {
            if (Txt_DName.Text == "" || Txt_DNumber.Text == "")
            {
                MessageBox.Show("Please fill all the required fields.");
            }
            else
            {
                int r = controllerObj.InsertDepartment(Txt_DName.Text, Convert.ToInt32(Txt_DNumber.Text), Convert.ToInt32(ComboBox_MName.SelectedValue), dateTimePicker.Value);
                if (r > 0)
                    MessageBox.Show("Department inserted successfully");
                else
                    MessageBox.Show("Error inserting department");
            }
        }
    }
}
