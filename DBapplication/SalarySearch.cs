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
    public partial class SalarySearch : Form
    {
        Controller controllerObj = new Controller();

        public SalarySearch()
        {
            InitializeComponent();
        }

        
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DataTable data;
            bool isNumber = true; 

            foreach (char c in EnteredSalary.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false; 
            }

            if (CompareComboBox.SelectedIndex != -1 && isNumber)
            {
                data = controllerObj.GetEmployeeOfSalary(Convert.ToInt32(EnteredSalary.Text), CompareComboBox.SelectedIndex);
                EmployeesList.DataSource = data;
                EmployeesList.DisplayMember = "Name";
            }
        }

       
    }
}
