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
using LMS_Library_Managment_System_.BL;

namespace LMS_Library_Managment_System_
{
    public partial class LMSWindowStudent : Form
    {
        private static Color colour;
        private  Student user;
        public static Color Colour { get => colour; set => colour = value; }

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string nameofUser;
        public LMSWindowStudent(User user)
        {
            InitializeComponent();
            random = new Random();
            this.user =(StudentDL.Search(user.UserName)) ;
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



        private void pnlWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
             SearchCatalouge frm = new SearchCatalouge() ;
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "SEARCH CATALOUGE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowedBooks frm = new BorrowedBooks(user);
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "BORROW BOOK";
        }
        private void btnchagePassword_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(user);
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "CHANGE PASS WORD";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
