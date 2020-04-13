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
    public partial class ViewAllDepartments : Form
    {
        Controller controllerObj = new Controller();
        public ViewAllDepartments()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectDepartmentsMgr();
            dataGridView.DataSource = dt;
            dataGridView.Refresh();
        }

        private void ViewAllDepartments_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
