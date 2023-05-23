using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library_Managment_System_.BL
{
    class Genre
    {
        string genere;
        char genereCode;
        int counterofBooks;
        List<string> subGenres;
        List<String> subGenresCode;
        List<int> counterofSubBooks;

        public Genre(string genere, char genereCode,int counterofBooks,List<string> subGenres,List<string>subGenresCode)
        {
            this.genere = genere;
            this.genereCode = genereCode;
            this.subGenres =subGenres ;
            this.subGenresCode = subGenresCode;
            this.counterofBooks = counterofBooks;
            counterofSubBooks = new List<int>();
        }
        public Genre(string genere,char genereCode,string subGenre,string subGenreCode)
        {
            this.genere = genere;
            this.genereCode = genereCode;
            this.subGenres = new List<string>();
            this.subGenres.Add(subGenre);
            this.subGenresCode = new List<string>();
            this.subGenresCode.Add(subGenreCode);
            this.counterofSubBooks = new List<int>();
            this.counterofSubBooks.Add(0);
            this.counterofBooks = 0;
        }

        public Genre(string genere, char genereCode, int counterofBooks, List<string> subGenres, List<string> subGenresCode, List<int> counterofSubBooks)
        {
            this.genere = genere;
            this.genereCode = genereCode;
            this.counterofBooks = counterofBooks;
            this.subGenres = subGenres;
            this.subGenresCode = subGenresCode;
            this.counterofSubBooks = counterofSubBooks;
        }

        public string Genere { get => genere; set => genere = value; }
        public char GenereCode { get => genereCode; set => genereCode = value; }
        public List<string> SubGenres { get => subGenres; set => subGenres = value; }
        public List<string> SubGenresCode { get => subGenresCode; set => subGenresCode = value; }
        public int CounterofBooks { get => counterofBooks; set => counterofBooks = value; }
        public List<int> CounterofSubBooks { get => counterofSubBooks; set => counterofSubBooks = value; }

        public void addSubGenretoList(string subGenre)
        {
            subGenres.Add(subGenre);
        }
        public void addCodetoList(string subGenreCode)
        {
            subGenresCode.Add(subGenreCode);
        }
     
    }
}
