using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_Library_Managment_System_.Bissuness_Logic;
using LMS_Library_Managment_System_.BL;


namespace LMS_Library_Managment_System_.BL
{
    public class Student:User
    {
        private List<BorrowBook> allBorrowedBooks;

        public List<BorrowBook> AllBorrowedBooks { get => allBorrowedBooks; set => allBorrowedBooks = value; }

        public Student(string userName, string name, string password, string role) : base(userName, name, password, role)
        {
            allBorrowedBooks = new List<BorrowBook>();
        }
        public Student(User user) : base(user)
        {
            allBorrowedBooks = new List<BorrowBook>();
        }
        public Student(User user, List<BorrowBook> allBorrowedBooks) : base(user)
        {
            this.allBorrowedBooks = allBorrowedBooks;
        }
        public void AddtoList(BorrowBook rec)
        {
            allBorrowedBooks.Add(rec);
            int a = allBorrowedBooks.Count;
        }
        public void RemoveBook(Book book)
        {
            int count = 0;
            foreach (BorrowBook rec in AllBorrowedBooks)
            {
                if(rec.BorroweBook==book)
                {
                    allBorrowedBooks.RemoveAt(count);
                    break;
                }
                count++;
            }
        }
    }
}
