using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public enum Privileges
    {
        Admin = 1,
        Others = 2
    }
   
    public partial class Login : Form
    {
        
        private Controller controllerObj; // A Reference of type Controller 
                                          // (Initially NULL; NO Controller Object is created yet)

        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller(); // Create the Controler Object
        }


        


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            int p = controllerObj.CheckPassword_Basic(TxtBx_username.Text, TxtBx_pass.Text);
            if (p > 0)
            {
                Provided_Functionalities PF = new Provided_Functionalities((Privileges)p);
                PF.Show(this);
                TxtBx_pass.Clear();
                TxtBx_username.Clear();
                this.Hide();
        }
            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD!!!");
            }
}

        
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TxtBx_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
