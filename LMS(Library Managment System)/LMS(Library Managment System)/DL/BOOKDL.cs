using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LMS_Library_Managment_System_.BL;

namespace LMS_Library_Managment_System_.DL
{
    class BOOKDL
    {
        private static List<Book> allBooks = new List<Book>();

        public static List<Book> AllBooks { get => allBooks; set => allBooks = value; }

        public static void AddtoList(Book record)
        {
            AllBooks.Add(record);
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
                    string title=splittedLine[0];
                    string authorName= splittedLine[1];
                    string genre=splittedLine[2];
                    string subgenre=splittedLine[3];
                    int publishyear=int.Parse(splittedLine[4]);
                    string callNumber=splittedLine[5];
                    bool softCopy=bool.Parse(splittedLine[6]);
                    bool borrowable=bool.Parse(splittedLine[7]);
                    int price=int.Parse(splittedLine[8]);
                    int fineperDay=int.Parse(splittedLine[9]);
                    bool onShelf=bool.Parse(splittedLine[10]);
                    Book rec = new Book(title,authorName,genre,subgenre,publishyear,callNumber,softCopy,borrowable,fineperDay,price,onShelf);
                    AddtoList(rec);
                }
                file.Close();
                return true;
            }
            return false;
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Book rec in allBooks)
            {
                file.WriteLine(rec.Title+","+rec.AuthorName + "," +rec.Genre  + "," +rec.Subgenre + "," +rec.Publishyear + "," +rec.CallNumber + "," +rec.SoftCopy + "," +rec.Borrowable + "," +rec.FineperDay + "," +rec.Price + "," +rec.OnShelf);
            }
            file.Flush();
            file.Close();
        }
        public static string GenerateCallNumber(Genre gen,string subGenCode,string title,int Year)
        {
            string callno=subGenCode;
            string count = (gen.CounterofBooks+1).ToString();
            string SubGencount= (GenreDL.countSubGen(subGenCode)+1).ToString();
            if(subGenCode.Length<2)
            {
                string temp = "0" + SubGencount;
                subGenCode = temp;
            }
            if(count.Length<4)
            {
                string temp = "";
                for (int i=0;i<4-count.Length;i++)
                {
                    temp += "0" ;
                }
                    count = temp+count;
            }
            return subGenCode + " " + count + " " + "." + title[0] + SubGencount + " " + Year;
        }
        public static void EditRecordinList(Book previous,Book  Updated)
        {
            foreach (Book rec in allBooks)
            {
                if ( rec.CallNumber==previous.CallNumber && rec.Title==previous.Title)
                {
                    rec.Title = Updated.Title;
                    rec.AuthorName = Updated.AuthorName;
                    rec.Genre = Updated.Genre;
                    rec.Subgenre = Updated.Subgenre;
                    rec.Publishyear = Updated.Publishyear;
                    rec.CallNumber = Updated.CallNumber;
                    rec.SoftCopy = Updated.SoftCopy;
                    rec.Borrowable = Updated.Borrowable;
                    rec.FineperDay = Updated.FineperDay;
                    rec.Price = Updated.Price;
                    rec.OnShelf = true;
                }
            }
        }
        public static void DeleteaRec(Book recToDel)
        {
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i] == recToDel)
                {
                    allBooks.RemoveAt(i);
                }
            }
        }
        public static Book Search(string searchString)
        {
            foreach(Book rec in allBooks)
            {
                if(rec.Title==searchString || rec.CallNumber==searchString)
                {
                    return rec;
                }
            }
            return null;
        }
        
    }
}
