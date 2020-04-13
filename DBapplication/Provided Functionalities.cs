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
    public partial class Provided_Functionalities : Form
    {

        private Privileges _privilege;
       
        public Provided_Functionalities(Privileges privilege = Privileges.Others)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.Others)
            {
                addProjectToolStripMenuItem.Enabled = false;
                updateProjectToolStripMenuItem.Enabled = false;
                updateDepartmentToolStripMenuItem.Enabled = false;
                addDepartmentToolStripMenuItem.Enabled = false;
            }
            
        }

        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            ViewEmployees v = new ViewEmployees(_privilege);
            v.Show();
           
        }

       
        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddProject().Show();
        }

        private void retrieveProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RetrieveProjects().Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewEmployees().Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Provided_Functionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Provided_Functionalities_Load(object sender, EventArgs e)
        {

        }

        private void getDepartmentByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentByName DN = new DepartmentByName();
            DN.Show();
        }

        private void getALLProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllProjects VAP = new ViewAllProjects();
            VAP.Show();
        }

        private void getALLDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllDepartments VAD = new ViewAllDepartments();
            VAD.Show();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment AD = new AddDepartment();
            AD.Show();
        }

        private void getProjectByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectByName PN = new ProjectByName();
            PN.Show();
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            new Statistics().Show(); 
        }

        private void updateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateProject().Show();
        }

        private void updateDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateDepartment().Show();
        }
    }
}
