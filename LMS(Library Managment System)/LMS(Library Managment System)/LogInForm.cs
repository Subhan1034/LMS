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
using LMS_Library_Managment_System_.BL;
using LMS_Library_Managment_System_.DL;

namespace LMS_Library_Managment_System_
{
    public partial class LogInForm : Form
    {
        private User logIn;
        //string fileUser,  fileBook, fileBorrowed, fileStude, fileGenre;
        //string fileUser, string fileBook,string fileBorrowed,string fileStude,string fileGenre
        public LogInForm()
        {
            InitializeComponent();
        }


        private void LogInForm_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblLMS.Text = " L  IBRARY\nM ANAGMENT\n S YSTEM";
            lblLMS.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            lblLMS.ForeColor = Color.FromArgb(30, 30, 85);
            lblLMS.BackColor = Color.White;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitt_Click(object sender, EventArgs e)
        {
            VerifyUser();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
            cmbRole.Text = null;
        }
        private void VerifyUser()
        {
            if (!(txtUserName.Text == "" || txtPassword.Text == "" || cmbRole == null))
            {
                 logIn = new User(txtUserName.Text, txtPassword.Text, cmbRole.Text);
                logIn = UserDL.isUserValid(logIn);
                if (logIn != null)
                {
                    if(logIn.Role=="ADMIN")
                    {
                        LMSWindow LMS = new LMSWindow(logIn);
                        this.Hide();
                        LMS.Show();
                    }
                    else if(logIn.Role == "STUDENT")
                    {
                        LMSWindowStudent LMS = new LMSWindowStudent(logIn);
                        this.Hide();
                        LMS.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Wrong Credential!");
                }
            }
            else
            {
                MessageBox.Show("Enter all Credentials First!");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                MessageBox.Show("Password Allows Only Numeric Values!");
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyUser();
            }
        }
    }
}
