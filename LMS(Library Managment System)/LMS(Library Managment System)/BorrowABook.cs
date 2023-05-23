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
    public partial class BorrowABook : Form
    {
        private Book book;
        private Student user;
        public BorrowABook()
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

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            cmbSearchUser.GetItemText(cmbSearchUser.SelectedItem);
            user = StudentDL.Search(txtSearchUser.Text);
            if (user != null)
            {
                txtName.Text = user.Name;
                txtUserName.Text = user.UserName;
            }
            else
            {
                MessageBox.Show("NO USER FOUNDED");
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (book != null && user != null)
            {
                if (book.Borrowable == true && book.OnShelf == true)
                {
                    book.OnShelf = false;
                    DateTime date = dtpDaedline.Value;
                    BorrowBook record = new BorrowBook(book, date);
                    user.AddtoList(record);
                    int a = user.AllBorrowedBooks.Count;
                    StudentDL.StoreData("StudentData.txt");
                    BOOKDL.StoreData("BookData.txt");
                    MessageBox.Show("Book Added Sucessfully");
                }
                else
                {
                    MessageBox.Show("BOOK CANNOT BE BORROWED");
                }
            }
            else
            {
                    MessageBox.Show("EMPTY CREDENTIALS");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
