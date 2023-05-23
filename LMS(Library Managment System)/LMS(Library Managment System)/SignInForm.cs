using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Library_Managment_System_.Bissuness_Logic;
using LMS_Library_Managment_System_.DL;


namespace LMS_Library_Managment_System_
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Maximized;
            lblLMS.Text = " L  IBRARY\nM ANAGMENT\n S YSTEM";
            lblLMS.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            lblLMS.ForeColor = Color.FromArgb(30,30,85);
            lblLMS.BackColor = Color.White;
        }

        private void btnSubmitt_Click(object sender, EventArgs e)
        {
            VerifyUser();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
            cmbRole.Text=null;
            lblWrongCredentials.Visible = false;
        }

        private void Credential_Click(object sender, EventArgs e)
        {
            lblWrongCredentials.Visible = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=! char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=13)
            {
                lblWrongCredentials.Text = "Password Allows Only Numeric Values";
                lblWrongCredentials.Visible = true;
            }
        }
        private void VerifyUser()
        {
            if (!(txtUserName.Text == "" || txtPassword.Text == "" || cmbRole == null))
            {
                User logIn = new User(txtUserName.Text, txtPassword.Text, cmbRole.Text);
                logIn = UserDL.isUserValid(logIn);
                if (logIn != null)
                {
                    LMSWindow LMS = new LMSWindow(logIn);
                    this.Hide();
                    LMS.Show();
                }
                else
                {
                    lblWrongCredentials.Text = "Wrong Credential!";
                    lblWrongCredentials.Visible = true;
                }
            }
            else
            {
                lblWrongCredentials.Text = "Enter all Credentials First!";
                lblWrongCredentials.Visible = true;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                VerifyUser();
            }
        }

        private void CredientialChanged(object sender, EventArgs e)
        {
            lblWrongCredentials.Visible = false;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            //if (txtPassword.PasswordChar == 'O')
            //{
            //    txtPassword.PasswordChar = '\0';
            //}
            //else if (txtPassword.PasswordChar == '\0')
            //{
            //    txtPassword.PasswordChar = 'O';
            //}
        }

        private void btnEye_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == 'O')
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnEye_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = 'O';
            }
        }
    }
}
