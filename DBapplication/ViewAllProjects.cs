﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ViewAllProjects : Form
    {
        Controller controllerObj = new Controller();
        public ViewAllProjects()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectProjects();
            dataGridView.DataSource = dt;
            dataGridView.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewAllProjects_Load(object sender, EventArgs e)
        {

        }
    }
}
