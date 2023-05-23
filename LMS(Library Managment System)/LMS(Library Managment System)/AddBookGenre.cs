using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Library_Managment_System_.DL;
using LMS_Library_Managment_System_.BL;

namespace LMS_Library_Managment_System_
{
    public partial class AddBookGenre : Form
    {
        Genre type=null;
        public AddBookGenre()
        {
            InitializeComponent();
        }

    

        private void AddBookGenre_Load(object sender, EventArgs e)
        {
            //txtSearch.Text = "SEARCH";
            //freezControls();
            //gvGenre.Visible = false;
            txtSearch.Visible = false;
            cmbSearch.Visible=false;
            DataBind();
            GridColor();
            //DataGridView gvGenre = new DataGridView();
           // gvGenre.Rows[0].DataBoundItem = GenreDL.AllGenre1[0].SubGenres;
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "SEARCH")
            //{ 
            //    txtSearch.Text=""; 
            //}
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "SEARCH";
            //}
        }
        public void freezControls()
        {
            txtSearch.Enabled=false;
            cmbSearch.Enabled=false;
            txtGenre.Enabled=false;
            txtGenreCode.Enabled=false;
            txtSubGenre.Enabled=false;
            txtSubGenreCode.Enabled=false;
            btnADDSubGenre.Enabled=false;
        }


        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (txtGenre.Text != "" && txtGenreCode.Text != "")
            {
                //type = new Genre(txtGenre.Text.ToString(),char.Parse(txtGenreCode.Text.ToString()));
                lblG.Text = type.Genere+" ("+ type.GenereCode.ToString()+")";
                lblG.Visible = true;
                //cmbExist.SelectedIndex = cmbExist.FindStringExact("YES");

            }
            else
            {
                MessageBox.Show("EMPTY CREDENTIALS ARE NOT ALLOWED!");
            }
        }

        private void txtGenreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {

                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtSubGenreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {

                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnADDSubGenre_Click(object sender, EventArgs e)
        {
            if(type!=null)
            {
                if(txtSubGenre.Text != "" && txtSubGenreCode.Text != "")
                {
                    type.addCodetoList(txtSubGenreCode.Text);
                    type.addSubGenretoList(txtSubGenreCode.Text);
                    gvGenre.DataSource = type.SubGenres;
                    gvGenre.Refresh();
                }
                else
                {
                    MessageBox.Show("EMPTY CREDENTIALS ARE NOT ALLOWED!");
                }
            }
            else
            {
                MessageBox.Show("ADD GENRE FIRST!");
            }
        }
        public void DataBind()
        {
            gvGenre.DataSource = null;
            gvGenre.DataSource = GenreDL.AllGenre1.Select(c => new { c.Genere, c.GenereCode, c.SubGenres, c.SubGenresCode,c.CounterofBooks,c.CounterofSubBooks }).ToList();
            //gvGenre.Columns["SUB-GENRE"]
            gvGenre.Refresh();
        }
        public void GridColor()
        {
            for (int i = 0; i < gvGenre.Columns.Count; i++)
            {
                gvGenre.Columns[i].HeaderCell.Style.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
                gvGenre.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                //gvGenre.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                //gvGenre.Rows[i].HeaderCell.Style.BackColor = Color.Black;
                gvGenre.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular);
                if (i % 2 == 0)
                {
                    gvGenre.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    gvGenre.Columns[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void gvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string a = (Genre)gvGenre.CurrentRow.DataGridView;
            if (gvGenre.Columns["ADD"].Index == e.ColumnIndex)
            {
                txtGenre.Text = type.Genere;
            }
        }
    }
}
