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
using LMS_Library_Managment_System_.BL;

namespace LMS_Library_Managment_System_
{
    public partial class Form1 : Form
    {
        //private static Color colour;
        //public static Color Colour { get => colour; set => colour = value; }
        private User record;
        private string path = "UserData.txt";
        public Form1()
        {
            InitializeComponent();
            //colour = Colour;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBind();
            GridColor();
            UpdateUserDashBoard();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnUser.Text == "UPDATE")
            {
                    if(!(txtUserName.Text == "" || txtName.Text == "" || txtPassword.Text == "" || cmbRole == null))
                    {
                        DialogResult save = MessageBox.Show("Do you want to update record?", "CONFIRM UPDATION", MessageBoxButtons.YesNo);
                    if (save == DialogResult.Yes)
                    {
                        User editedRec = new User(txtUserName.Text, txtName.Text, txtPassword.Text, cmbRole.SelectedItem.ToString());
                        UserDL.EditRecordinList(record, editedRec);
                        lblAddaUser.Text = "ADD A USER";
                        btnUser.Text = "ADD";
                        EmptyCredentials();
                        UserDL.StoreAllData(path);
                        DataBind();
                        GridColor();
                        UpdateUserDashBoard();
                    }
                    }
                    else
                    {
                        MessageBox.Show("Add All Credentials First");
                    }


            }
            else if (btnUser.Text == "ADD")
            {
                if(!(txtUserName.Text == "" ||txtName.Text==""|| txtPassword.Text == "" || cmbRole == null))
                {
                record = new User(txtUserName.Text, txtName.Text, txtPassword.Text, cmbRole.SelectedItem.ToString());
                if(cmbRole.SelectedItem.ToString() == "STUDENT")
                    {
                        Student rec = new Student(record);
                        StudentDL.AddtoList(record);
                    }
                UserDL.addtoList(record);
                MessageBox.Show("User added Sucessfully...");
                UserDL.StoreAllData(path);
                DataBind();
                GridColor();
                UpdateUserDashBoard();
                EmptyCredentials();
                }
                else
                {
                    MessageBox.Show("Add All Credentials First");
                }

            }
        }

        private void gvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            record = (User)gvUser.CurrentRow.DataBoundItem;
            if (gvUser.Columns["EDIT"].Index == e.ColumnIndex)
            {
                lblAddaUser.Text = "EDIT DATA";
                cmbRole.SelectedIndex = cmbRole.FindStringExact(record.Role);
                txtName.Text = record.Name;
                txtUserName.Text = record.UserName;
                txtPassword.Text = record.Password;
                btnUser.Text = "UPDATE";
            }
            else if (gvUser.Columns["DELETE"].Index == e.ColumnIndex)
            {
                DialogResult delete = MessageBox.Show("Do you want to delete record?", "CONFIRM DELETION", MessageBoxButtons.YesNo);
                if (delete==DialogResult.Yes)
                {
                    UserDL.DeleteaRec(record);
                    UserDL.StoreAllData(path);
                    DataBind();
                    GridColor();
                    UpdateUserDashBoard();
                }
            }
        }
        public void DataBind()
        {
            gvUser.DataSource = null;
            gvUser.DataSource = UserDL.AllUser();
            gvUser.Refresh();
        }
        public void GridColor()
        {
            for (int i = 0; i < gvUser.Columns.Count; i++)
            {
                gvUser.Columns[i].HeaderCell.Style.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
                gvUser.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                //gvUser.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                //gvUser.Rows[i].HeaderCell.Style.BackColor = Color.Black;
                gvUser.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular);

                if (i % 2 == 0)
                {
                    gvUser.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    gvUser.Columns[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                }
                //gvUser.Columns[i].DefaultCellStyle.BackColor =(i % 2 == 0) ?  Color.Black : Color.FromArgb(240, 240, 240);
            }
        }
        public void UpdateUserDashBoard()
        {
            lblAdmin.Text = (UserDL.AdminCount()).ToString() + "(" + UserDL.AdminPercent().ToString() + " %)";
            lblUser.Text = (UserDL.StudentCount()).ToString() + "(" + UserDL.StudentPercent().ToString() + " %)";
            lblTotal.Text = (UserDL.UserCount()).ToString();
        }
        public void EmptyCredentials()
        {
            cmbRole.SelectedItem = null;
            txtName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TLBForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAddaUser_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                MessageBox.Show("Password Allows Only Numeric Values");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnAutoCode_Click(object sender, EventArgs e)
        {
            txtPassword.Text = (UserDL.randomPassword(9)).ToString();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!="")
            {
                txtUserName.Text += "@LMS.COM";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
