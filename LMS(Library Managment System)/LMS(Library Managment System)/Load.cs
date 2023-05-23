using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Library_Managment_System_
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        int initialpoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            initialpoint+=10;
            PBLoad.Value = initialpoint;
            if (PBLoad.Value==100)
            {
                timer1.Stop();
                //SignInForm logIn = new SignInForm();
                LogInForm logIn = new LogInForm();
                this.Hide();
                logIn.Show();
            }
        }
    }
}
