using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using LMS_Library_Managment_System_.Bissuness_Logic;

namespace LMS_Library_Managment_System_.DL
{
    class UserDL
    {
        private static List<User> allUsers = new List<User>();
        public static List<User> AllUser()
        {
            return allUsers;
        }
        public static User isUserValid(User logIn)
        {
            foreach(User rec in allUsers)
            {
                if(logIn.UserName==rec.UserName && logIn.Password==rec.Password && logIn.Role==rec.Role)
                {
                    return rec;
                }
            }
            return null;
        }
        public static bool loadData(string path)
        {
            StreamReader file=new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedLine = line.Split(',');
                    string role = splittedLine[0];
                    string name = splittedLine[1];
                    string userName = splittedLine[2];
                    string password = splittedLine[3];
                    User rec = new User(userName,name,password,role);
                    addtoList(rec);
                }

                file.Close();
                return true;
            }
            return false;
        }
        public static void addtoList(User rec)
        {
            allUsers.Add(rec);
            if(rec.Role=="STUDENT")
            {
                StudentDL.AddtoList(rec);
            }
        }
        public static void EditRecordinList(User previous, User Updated)
        {
            foreach (User rec in allUsers)
            {
                if(previous==rec)
                {
                    rec.Role = Updated.Role;
                    rec.Name = Updated.Name;
                    rec.UserName = Updated.UserName;
                    rec.Password = Updated.Password;
                }
            }
        }
        public static int AdminCount()
        {
            int count = 0;
            foreach (User rec in allUsers)
            {
                if(rec.Role=="ADMIN")
                {
                    count += 1;
                }
            }
            return count;
        }
        public static int UserCount()
        {
            return allUsers.Count();
        }
        public static float AdminPercent()
        {
            return (AdminCount()*0.1f / allUsers.Count()) * 1000;
        }
        public static float StudentPercent()
        {
            return (StudentCount()*0.1f / allUsers.Count()) * 1000;
        }
        public static int StudentCount()
        {
            int count = 0;
            foreach (User rec in allUsers)
            {
                if(rec.Role=="STUDENT")
                {
                    count += 1;
                }
            }
            return count;
        }
        public static void StoreAllData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach(User rec in allUsers)
            {
                file.WriteLine(rec.Role+","+rec.Name + "," +rec.UserName + "," +rec.Password);
                file.Flush();
            }
            file.Close();
        }
        public static void DeleteaRec(User recToDel)
        {
            for(int i=0;i<allUsers.Count;i++)
            {
                if(allUsers[i]==recToDel)
                {
                    allUsers.RemoveAt(i);
                }
            }
        }
        public static int randomPassword(int digit)
        {
            int min, max;
            string minmum="1", maximum="";
            for(int i=0; i<digit-1;i++)
            {
                minmum += "0";
            }
            for(int i=0; i<digit;i++)
            {
                maximum += "9";
            }
            min = int.Parse(minmum);
            max = int.Parse(maximum);
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        public bool isAnyCredentialEmpty(User user)
        {
            if (user.Role == "" || user.Name == "" || user.UserName == "" || user.Password == "")
            {
                return true;
            }
            return false;
        }
        public static bool isUserNameUnique(string UserName)
        {
            foreach(User rec in allUsers)
            {
                if(UserName==rec.UserName)
                {
                    return false;
                }
            }
            return true;
        }
        public static User Search(string searchString)
        {
            foreach (User rec in allUsers)
            {
                if (rec.UserName == searchString && rec.Role=="STUDENT")
                {
                    return rec;
                }
            }
            return null;
        }
    }
}
