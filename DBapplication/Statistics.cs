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
    public partial class Statistics : Form
    {
        Controller controllerObj = new Controller();
        public Statistics()
        {
            InitializeComponent();
            DataTable dataA = controllerObj.GetAllStats();
            DataTable dataF = controllerObj.GetFStats();
            DataTable dataM = controllerObj.GetMStats();
            DataTable MC = controllerObj.GetManagersCount();
            DataTable SC = controllerObj.GetSupervisorsCount();
            DataTable OC = controllerObj.GetOthersCount();
            DataTable SeniorsC = controllerObj.GetSeniorsCount();
            DataTable DC = controllerObj.GetDepartmentsCount();
            DataTable PC = controllerObj.GetProjectsCount();

            ACount.Text = Convert.ToString(dataA.Rows[0][0]);
            AAvg.Text = Convert.ToString(dataA.Rows[0][1]);
            AMin.Text = Convert.ToString(dataA.Rows[0][2]);
            AMax.Text = Convert.ToString(dataA.Rows[0][3]);

            FCount.Text = Convert.ToString(dataF.Rows[0][0]);
            FAvg.Text = Convert.ToString(dataF.Rows[0][1]);
            FMin.Text = Convert.ToString(dataF.Rows[0][2]);
            FMax.Text = Convert.ToString(dataF.Rows[0][3]);

            MCount.Text = Convert.ToString(dataM.Rows[0][0]);
            MAvg.Text = Convert.ToString(dataM.Rows[0][1]);
            MMin.Text = Convert.ToString(dataM.Rows[0][2]);
            MMax.Text = Convert.ToString(dataM.Rows[0][3]);

            ManagersCount.Text = Convert.ToString(MC.Rows[0][0]);
            SupervisorsCount.Text = Convert.ToString(SC.Rows[0][0]);
            OthersCount.Text = Convert.ToString(OC.Rows[0][0]);
            SeniorsCount.Text = Convert.ToString(SeniorsC.Rows[0][0]);

            DepartmentsCount.Text = Convert.ToString(DC.Rows[0][0]);
            ProjectsCount.Text = Convert.ToString(PC.Rows[0][0]);

        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

    }
}
