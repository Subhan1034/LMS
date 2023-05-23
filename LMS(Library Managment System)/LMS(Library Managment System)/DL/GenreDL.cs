using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LMS_Library_Managment_System_.BL;

namespace LMS_Library_Managment_System_.DL
{
    class GenreDL
    {
        private static List<Genre> AllGenre = new List<Genre>();

        public static List<Genre> AllGenre1 { get => AllGenre; set => AllGenre = value; }

        public static bool isEmpty(string genere, char genereCode)
        {
            if (genere == "" || genereCode == '\0')
            {
                return true;
            }
            return false;
        }
        public static List<string> allGenresList()
        {
            List<string> list = new List<string>();
            foreach (Genre rec in AllGenre)
            {
                list.Add(rec.Genere + "(" + rec.GenereCode + ")");
            }
            list.Add("OTHER");
            return list;
        }
        public static List<string> allSubGenresList(string Genre)
        {
            List<string> lstGen;
            List<string> lstCode;
            List<string> lst;
            foreach (Genre rec in AllGenre)
            {
                string GenwithCode = rec.Genere + "(" + rec.GenereCode + ")";
                if (GenwithCode == Genre)
                {
                    lstGen = rec.SubGenres.ToList();
                    lstCode = new List<string>(rec.SubGenresCode);
                    lst = new List<string>();
                    for (int i = 0; i < lstGen.Count; i++)
                    {
                        lst.Add(lstGen[i] + "(" + lstCode[i] + ")");
                    }
                    lst.Add("OTHER");
                    return lst;
                }
            }
            return null;
        }
        public static void addtoList(Genre genre)
        {
            AllGenre.Add(genre);
        }
        public static void addtoListofSubGen(Genre genre,string SubGen)
        {
            genre.SubGenres.Add(SubGen);
        }
        public static void addtoListofCodes(Genre genre,string SubGenCode)
        {
            genre.SubGenresCode.Add(SubGenCode);
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
                    string genere = splittedLine[0];
                    char genreCode = char.Parse(splittedLine[1]);
                    int counterOfBOOKS = int.Parse(splittedLine[2]);
                    string[] splittedSub = splittedLine[3].Split('|');
                    List<string> subGenres = new List<string>();
                    for (int i = 0; i < splittedSub.Length; i++)
                    {
                        subGenres.Add(splittedSub[i]);
                    }
                    string[] splittedSubCode = splittedLine[4].Split('|');
                    List<string> subGenresCode = new List<string>();
                    for (int i = 0; i < splittedSubCode.Length; i++)
                    {
                        subGenresCode.Add(splittedSubCode[i]);
                    }
                    string[] splittedSubCounter = splittedLine[5].Split('|');
                    List<int> counterofSubBooks = new List<int>();
                    for (int i = 0; i < splittedSubCounter.Length; i++)
                    {
                        counterofSubBooks.Add(int.Parse(splittedSubCounter[i]));
                    }
                    Genre genre = new Genre(genere, genreCode, counterOfBOOKS, subGenres, subGenresCode, counterofSubBooks);
                    addtoList(genre);
                }
                file.Close();
                return true;
            }
            return false;
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Genre rec in AllGenre)
            {
                string b = rec.SubGenresCode.ElementAt(0);
                string subGens = "";
                string code = "";
                string subGensCount = "";
                for (int i = 0; i < rec.SubGenres.Count - 1; i++)
                {
                    subGens += rec.SubGenres[i] + "|";
                }
                b = rec.SubGenresCode.ElementAt(0);
                subGens += rec.SubGenres[rec.SubGenres.Count - 1];
                b = rec.SubGenresCode.ElementAt(0);
                for (int i = 0; i < rec.SubGenresCode.Count - 1; i++)
                {
                    code += rec.SubGenresCode.ElementAt(i) + "|";
                    b = rec.SubGenresCode.ElementAt(0);
                }
                code += rec.SubGenresCode[rec.SubGenresCode.Count - 1];
                b = rec.SubGenresCode.ElementAt(0);
                for (int i = 0; i < rec.CounterofSubBooks.Count - 1; i++)
                {
                    subGensCount += rec.CounterofSubBooks[i] + "|";
                }
                subGensCount += rec.CounterofSubBooks[rec.CounterofSubBooks.Count - 1];
                file.WriteLine(rec.Genere + "," + rec.GenereCode + "," + rec.CounterofBooks + "," + subGens + "," + code + "," + subGensCount);
            }
            file.Flush();
            file.Close();
        }
        public static Genre Search(string subGenre)
        {
            foreach (Genre rec in AllGenre1)
            {
                foreach (String gen in rec.SubGenres)
                {
                    if (gen == subGenre)
                    {
                        return rec;
                    }

                }
            }
            return null;
        }
        public static int countSubGen(string subGenCode)
        {
            foreach (Genre rec in AllGenre1)
            {
                foreach (String gen in rec.SubGenresCode)
                {
                    if (gen == subGenCode)
                    {
                        return rec.CounterofSubBooks[rec.SubGenresCode.IndexOf(gen)];
                    }

                }
            }
            return -1;
        }
        public static string Equal(Genre genre)
        {
            string meassage = "";
            foreach (Genre rec in AllGenre)
            {
                if (rec.Genere == genre.Genere)
                {
                    meassage += "GENRE ALREADY EXIST\n";
                }
                if (rec.GenereCode == genre.GenereCode)
                {
                    meassage += "GENRECODE ALREADY EXIST\n";
                }
                for (int i = 0; i < rec.SubGenres.Count; i++)
                {
                    string subgen = genre.SubGenres[0];
                    string subgenCode = genre.SubGenresCode[0];
                    if (rec.SubGenres[i] == subgen)
                    {
                        meassage += "SUB-GENRE ALREADY EXIST\n";
                    }
                    if (rec.SubGenresCode[i] == subgenCode)
                    {
                        meassage += "SUB-GENRE CODE ALREADY EXIST\n";
                    }
                }
            }
            return meassage;
        }
        public static Genre SearchbyGen_GenCode(Genre genre)
        {
            foreach (Genre rec in AllGenre)
            {
                if (rec.Genere == genre.Genere && rec.GenereCode == genre.GenereCode)
                {
                    return rec;
                }
            }
            return null;
        }
        public static string EqualSubGen(Genre genre)
        {
            string meassage = "";
            Genre type;
            if (SearchbyGen_GenCode(genre)!=null)
            {
                type= SearchbyGen_GenCode(genre);
                for (int i = 0; i < type.SubGenres.Count; i++)
                {
                    if (type.SubGenres[i] == genre.SubGenres[0])
                    {
                        meassage += "SUB-GENRE ALREADY EXIST\n";
                    }
                    if (type.SubGenresCode[i] == genre.SubGenresCode[0])
                    {
                        meassage += "SUB-GENRE CODE ALREADY EXIST\n";
                    }
                }
            }
                    
            return meassage;
        }
        public static Genre Counterplus(string genre, string subGen)
        {
            foreach (Genre rec in AllGenre1)
            {
                if(rec.Genere==genre)
                {
                    int count = 0;
                    foreach(string subGenre in rec.SubGenres)
                    {
                        if(subGenre==subGen)
                        {
                            rec.CounterofBooks++;
                            rec.CounterofSubBooks[rec.SubGenres.IndexOf(subGenre)]++;
                        }
                        count++;
                    }
                }
            }
            return null;
        }
        
    }
}
