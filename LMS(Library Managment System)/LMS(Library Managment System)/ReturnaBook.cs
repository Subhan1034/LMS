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
    
    public partial class ReturnaBook : Form
    {
        private Book book;
        private Student user;
        public ReturnaBook()
        {
            InitializeComponent();
        }

        private void ReturnaBook_Load(object sender, EventArgs e)
        {
            clearLabels();
        }
        private void clearLabels()
        {
            lblTitle.Text = "";
            lblAuthorName.Text = "";
            lblCallNum.Text = "";
            lblGenre.Text = "";
            lblSubGenere.Text = "";
            lblOnShelf.Text = "";
            lblBorrowable.Text = "";
            cmbBook.Items.Clear();
        }
        private void ShowinLabel(Book book)
        {
            lblTitle.Text = book.AuthorName;
            lblAuthorName.Text = book.Title;
            lblCallNum.Text = book.CallNumber;
            lblGenre.Text = book.Genre;
            lblSubGenere.Text = book.Subgenre;
            lblBorrowable.Text = "";
            if (book.Borrowable == true)
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

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSearchStudent_Click_1(object sender, EventArgs e)
        {
            cmbBook.GetItemText(cmbBook.SelectedItem);
            user = StudentDL.Search(txtSearchUser.Text);
            if (user != null)
            {
                cmbBook.Items.Clear();
                for(int i=0;i<user.AllBorrowedBooks.Count;i++)
                {
                    cmbBook.Items.Add(user.AllBorrowedBooks[i].BorroweBook.Title.ToString());
                }
                txtName.Text = user.Name;
                txtUserName.Text = user.UserName;
            }
            else
            {
                MessageBox.Show("NO USER FOUNDED");
            }
        }

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title=cmbBook.GetItemText(cmbBook.SelectedItem);
            if(BOOKDL.Search(title)!=null)
            {
                book=BOOKDL.Search(title);
                lblCallNum.Text = book.CallNumber;
                lblAuthorName.Text = book.AuthorName;
                lblTitle.Text = book.Title;
                lblGenre.Text =book.Genre;
                lblSubGenere.Text=book.Subgenre;
                if (book.Borrowable == true)
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
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(book!=null && user!=null)
            {
                book.OnShelf = true;
                user.RemoveBook(book);
                StudentDL.StoreData("StudentData.txt");
                MessageBox.Show("BooK Returned Sucessfully..");
            }

        else
            {
                MessageBox.Show("Find Book && User First");
            }
        }
    }
}
