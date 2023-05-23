using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LMS_Library_Managment_System_.Bissuness_Logic;
using LMS_Library_Managment_System_.BL;
using LMS_Library_Managment_System_.DL;

namespace LMS_Library_Managment_System_.DL
{
    public class StudentDL
    {
        private static List<Student> allStudents = new List<Student>();

        public static List<Student> AllStudents { get => allStudents; set => allStudents = value; }

        public static  void AddtoList(User user)
        {
            Student student = new Student(user);
            allStudents.Add(student);
        }
        public static void AddtoList(Student user)
        {
            allStudents.Add(user);
        }
        public static Student Search(string searchString)
        {
            foreach (Student rec in allStudents)
            {
                if (rec.UserName == searchString && rec.Role == "STUDENT")
                {
                    return rec;
                }
            }
            return null;
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Student rec in allStudents)
            {
                string Dates = "";
                string Books = "";
                for (int i = 0; i < rec.AllBorrowedBooks.Count - 1; i++)
                {
                    Dates += rec.AllBorrowedBooks[i].Deadline + "|";
                    Books += rec.AllBorrowedBooks[i].BorroweBook.CallNumber+ "|";
                }
                if(rec.AllBorrowedBooks.Count>0)
                {
                Dates += rec.AllBorrowedBooks[rec.AllBorrowedBooks.Count -1].Deadline ;
                Books += rec.AllBorrowedBooks[rec.AllBorrowedBooks.Count - 1].BorroweBook.CallNumber;
                }
                file.WriteLine(rec.UserName+","+Books + "," +Dates);
            }
            file.Flush();
            file.Close();
        }
        public static bool LoadData(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedLine = line.Split(',');
                    string UserName = splittedLine[0];
                    if(splittedLine[1]!="" && splittedLine[2]!="")
                    {
                        string[] Books = splittedLine[1].Split('|');
                        string[] Dates = splittedLine[2].Split('|');
                        List<BorrowBook> lstBook = new List<BorrowBook>();
                        for (int i = 0; i < Books.Length; i++)
                        {
                            if (BOOKDL.Search(Books[i]) != null)
                            {
                                BorrowBook temp = new BorrowBook();
                                temp.BorroweBook = BOOKDL.Search(Books[i]);
                                temp.Deadline = DateTime.Parse(Dates[i]);
                                lstBook.Add(temp);
                            }
                        }
                        if (Search(UserName) != null)
                        {

                            Search(UserName).AllBorrowedBooks = lstBook;
                        }
                        
                    }
                    
                }
                int a = allStudents.Count;
                file.Close();
                return true;
            }
            return false;
        }
    }
}
