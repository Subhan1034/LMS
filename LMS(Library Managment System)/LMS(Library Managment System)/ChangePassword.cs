using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Library_Managment_System_.BL;
using LMS_Library_Managment_System_.Bissuness_Logic;
using LMS_Library_Managment_System_.DL;

namespace LMS_Library_Managment_System_
{
    public partial class ChangePassword : Form
    {
        private Student User;
        public ChangePassword(Student User)
        {
            InitializeComponent();
            this.User = User;
        }


      

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                MessageBox.Show("Password Allows Only Numeric Values");
            }
        }

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text!=null)
            {
                User.Password = txtPassword.Text;
                UserDL.StoreAllData("UserData.txt");
                MessageBox.Show("Congractulation!Password Changed Sucessfully!");
            }
        }
    }
}
