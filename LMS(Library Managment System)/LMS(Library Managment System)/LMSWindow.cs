using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Library_Managment_System_.UI;
using LMS_Library_Managment_System_.DL;
using LMS_Library_Managment_System_.Bissuness_Logic;

namespace LMS_Library_Managment_System_
{
    public partial class LMSWindow : Form
    {
        private static Color colour;
        private User user;
        public static Color Colour { get => colour; set => colour = value; }
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public LMSWindow(User user)
        {
            InitializeComponent();
            random = new Random();
            this.user = user;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitleBar.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    colour = color;
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlWindow.Controls.Add(childForm);
            this.pnlWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTtleBar.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void LMSWindow_Load(object sender, EventArgs e)
        {
            lblTtleBar.Text = "Welcome " + user.Name + " !";
            lblName.Text = user.Name;
        }

        private void btnUserDashboard_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "USER DASHBOARD";
        }


        private void pnlWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
             BookModule frm = new BookModule() ;
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "BOOK DASHBOARD";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowABook frm = new BorrowABook();
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "BORROW BOOK";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnaBook frm = new ReturnaBook();
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "RETURN BOOK";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTtleBar_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
