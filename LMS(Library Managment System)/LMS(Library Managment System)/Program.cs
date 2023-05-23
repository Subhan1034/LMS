using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using LMS_Library_Managment_System_.Bissuness_Logic;
using LMS_Library_Managment_System_.DL;

namespace LMS_Library_Managment_System_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = "UserData.txt";
            string path1 = "GenreData.txt";
            string path2 = "BookData.txt";
            string path3 = "StudentData.txt";
            UserDL.loadData(path);
            GenreDL.LoadData(path1);
            BOOKDL.LoadData(path2);
            StudentDL.LoadData(path3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LMSWindowStudent(null));
           Application.Run(new Load());
           //Application.Run(new BorrowABook());
            Application.Run(new BookModule());
            //Application.Run(new BorrowABook());
            
        }
    }
}
