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
using LMS_Library_Managment_System_.DL;

namespace LMS_Library_Managment_System_
{
    public partial class UpdateaBook : Form
    {
        private Book book;
        public UpdateaBook(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void NUDPrice_ValueChanged(object sender, EventArgs e)
        {
            NUDFinePerDay.Maximum = NUDPrice.Value;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (CheckEmpty()==null)
            {
                GenreDL.Counterplus(cmbGenre.GetItemText(cmbGenre.SelectedItem), cmbSubGenre.GetItemText(cmbSubGenre.SelectedItem));
                Book record= new Book(txtTitle.Text,txtAuthorName.Text, cmbGenre.GetItemText(cmbGenre.SelectedItem), cmbSubGenre.GetItemText(cmbSubGenre.SelectedItem),dtpYear.Value.Year,txtCallNumber.Text,yesNotoBool(cmbSoftCopy.Text), yesNotoBool(cmbBorrowable.Text), (int)NUDFinePerDay.Value, (int)NUDPrice.Value);
                BOOKDL.EditRecordinList(book,record);
                MessageBox.Show("Book Updated Sucessfully...");
                this.Close();
                //UserDL.StoreAllData(path);
                //DataBind();
                //GridColor();
                //UpdateUserDashBoard();
            }
            else
            {
                MessageBox.Show(CheckEmpty());
            }
        }
        private string CheckEmpty()
        {
            string error = null;
            if(txtAuthorName.Text=="")
            {
                error += "AUTHOR NAME IS EMPTY\n";
            }
            if(txtTitle.Text == "" )
            {
                error += "BOOK TITLE IS EMPTY\n";
            }
            if(cmbGenre.GetItemText(cmbGenre.SelectedItem) == "")
            {
                error += "GENRE IS NOT SELECTED\n";
            }
            if(cmbSubGenre.GetItemText(cmbSubGenre.SelectedItem) == "")
            {
                error += "SubGENRE IS NOT SELECTED\n";
            }
            if(txtCallNumber.Text == "" )
            {
                error += "Call Number IS NOT SELECTED\n";
            }
            if(cmbBorrowable.SelectedIndex < 0 )
            {
                error += "Borrowable is IS NOT SELECTED\n";
            }
            if( cmbSoftCopy.SelectedIndex < 0)
            {
                error += "SoftCopy is IS NOT SELECTED\n";
            }
            return error;
        }
        private bool yesNotoBool(string selectedItem)
        {
            if(selectedItem=="YES")
            {
                return true;
            }
            return false;
        }
        private string BooltoYesNo(bool check)
        {
            if(check==true)
            {
                return "YES";
            }
            return "NO";
        }

        private void AddaBook_Load(object sender, EventArgs e)
        {
            btnGenre.Enabled = false;
            btnSubGenre.Enabled= false;
            dtpYear.CustomFormat = "yyyy";
            refresh();
            assignValuestControls(book);
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGenre.GetItemText(cmbGenre.SelectedItem)!="OTHER")
            {
                cmbSubGenre.Items.Clear();
                string a = cmbGenre.GetItemText(cmbGenre.SelectedItem);
                List<string> SubGenre = GenreDL.allSubGenresList(a);
                btnGenre.Enabled = false;

                if (SubGenre != null)
                {
                    foreach (String rec in SubGenre)
                    {
                        cmbSubGenre.Items.Add(rec);
                    }
                }
            }
            else
            {
                cmbSubGenre.Items.Clear();
                cmbSubGenre.Enabled = false;
                cmbSubGenre.Items.Add("ADD SUB-GENRE");
                cmbSubGenre.SelectedIndex = cmbSubGenre.FindStringExact("ADD SUB-GENRE");
                btnSubGenre.Enabled = false;
                btnGenre.Enabled = true;
            }
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            int count = GenreDL.AllGenre1.Count;
            AddGenreDialouge frm = new AddGenreDialouge();
            frm.ShowDialog();
            refresh();
        }

        private void cmbSubGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSubGenre.GetItemText(cmbSubGenre.SelectedItem)=="OTHER")
            {
                btnSubGenre.Enabled = true;
            }
            else
            {
                cmbSubGenre.Enabled = true;
                btnSubGenre.Enabled = false;
            }
        }

        private void btnCallNo_Click(object sender, EventArgs e)
        {
            if (!(txtAuthorName.Text == "" || txtTitle.Text == "" || cmbGenre.GetItemText(cmbGenre.SelectedItem) == "" || cmbSubGenre.GetItemText(cmbSubGenre.SelectedItem) == ""))
            {
                string item = cmbSubGenre.GetItemText(cmbSubGenre.SelectedItem);
                string[] splitted = item.Split('(');
                string subgen = splitted[0];
                string[] splittedCode = splitted[1].Split(')');
                string subgenCode = splittedCode[0];
                // subgenCode = subgenCode[0].ToString() + subgenCode[1].ToString();
                Genre gen = GenreDL.Search(subgen);
                txtCallNumber.Text = BOOKDL.GenerateCallNumber(gen, subgenCode, txtTitle.Text, dtpYear.Value.Year);
            }
            else
            {
                MessageBox.Show("EMPTY CREDENTIALS");
            }
        }

        private void btnSubGenre_Click(object sender, EventArgs e)
        {
            AddGenreDialouge frm = new AddGenreDialouge(cmbGenre.GetItemText(cmbGenre.SelectedItem).Split('(')[0], 'L');
            frm.ShowDialog();
            cmbGenre_SelectedIndexChanged(sender, e);
        }
        private void refresh()
        {
            cmbGenre.Items.Clear();
            List<string> Genre = GenreDL.allGenresList();
            foreach (String rec in Genre)
            {
                cmbGenre.Items.Add(rec);
            }
        }
        private void assignValuestControls(Book book)
        {
            int A;
            txtTitle.Text=book.Title;
            txtAuthorName.Text=book.AuthorName;
            cmbGenre.SelectedItem=book.Genre;
            cmbSubGenre.SelectedItem= book.Subgenre;
            //dtpYear.Value = new DateTime(long.Parse((book.Publishyear).ToString()));
            txtCallNumber.Text=book.CallNumber;
            cmbSoftCopy.SelectedItem = BooltoYesNo(book.SoftCopy); 
            cmbBorrowable.SelectedItem = BooltoYesNo(book.Borrowable); ;
            NUDFinePerDay.Value=book.FineperDay;
            NUDPrice.Value =book.Price;
        }
    }
}
