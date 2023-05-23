using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_Library_Managment_System_.Bissuness_Logic;
namespace LMS_Library_Managment_System_.BL
{
    public class BorrowBook
    {
        Book borroweBook;
        DateTime deadline;
        public BorrowBook()
        {

        }
        public BorrowBook(Book borroweBook, DateTime deadline)
        {
            this.borroweBook = borroweBook;
            this.deadline = deadline;
        }

        public DateTime Deadline { get => deadline; set => deadline = value; }
        public Book BorroweBook { get => borroweBook; set => borroweBook = value; }
        //Fine & Borrow & Return Book
    }
}
