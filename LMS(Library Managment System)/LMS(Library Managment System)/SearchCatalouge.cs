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
    public partial class SearchCatalouge : Form
    {
        private Book book;
        private Student user;
        public SearchCatalouge()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            cmbSearchBook.GetItemText(cmbSearchBook.SelectedItem);
            book = BOOKDL.Search(txtSearchBook.Text);
            if(book!=null)
            {
                if(book.Borrowable==false)
                {
                    MessageBox.Show("BOOK IS READ ONLY");
                }
                else
                {
                    ShowinLabel(book);
                }
            }
            else
            {
                MessageBox.Show("NO BOOK FOUNDED");
            }
        }
        private void clearLabels()
        {
            lblTitle.Text="";
            lblAuthorName.Text="";
            lblCallNum.Text="";
            lblGenre.Text="";
            lblSubGenere.Text="";
            lblOnShelf.Text = "";
            lblBorrowable.Text = "";
        }
        private void ShowinLabel(Book book)
        {
            lblTitle.Text =book.AuthorName;
            lblAuthorName.Text = book.Title;
            lblCallNum.Text = book.CallNumber;
            lblGenre.Text = book.Genre;
            lblSubGenere.Text = book.Subgenre;
            lblBorrowable.Text = "";
            if(book.Borrowable==true)
            {
                if (book.OnShelf == true)
                {
                    lblOnShelf.Text = "→ON SHELF";
                }
                else
                {
                    lblOnShelf.Text = "→BORROWED BY ANOTHER PATRON";
                }
            }
            else
            {
                    lblBorrowable.Text = "→READ ONLY BOOK";
            }

        }

        private void BorrowABook_Load(object sender, EventArgs e)
        {
            clearLabels();
        }
    }
}
