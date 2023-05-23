using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library_Managment_System_.BL
{
    public class Book
    {
        private string title;
		private string authorName;
		private string callNumber;
		private string genre;
		private string subgenre;
		private bool borrowable;
		private bool  softCopy;
		private bool onShelf;
		private int price;
		private int fineperDay;
		private int publishyear;

        public Book(string title, string authorName, string genre, string subgenre, int publishyear, string callNumber, bool softCopy, bool borrowable, int fineperDay, int price)
        {
            this.title = title;
            this.authorName = authorName;
            this.genre = genre;
            this.subgenre = subgenre;
            this.publishyear = publishyear;
            this.callNumber = callNumber;
            this.softCopy = softCopy;
            this.borrowable = borrowable;
            this.fineperDay = fineperDay;
            this.price = price;
            this.onShelf = true;
        }

        public Book(string title, string authorName, string callNumber, string genre, string subgenre, bool borrowable, bool softCopy, bool onShelf, int price, int fineperDay)
        {
            this.title = title;
            this.authorName = authorName;
            this.callNumber = callNumber;
            this.genre = genre;
            this.subgenre = subgenre;
            this.borrowable = borrowable;
            this.softCopy = softCopy;
            this.onShelf = onShelf;
            this.price = price;
            this.fineperDay = fineperDay;
        }

        public Book(string title, string authorName, string genre, string subgenre, int publishyear, string callNumber, bool softCopy, bool borrowable, int fineperDay, int price, bool onShelf)
        {
            this.title = title;
            this.authorName = authorName;
            this.genre = genre;
            this.subgenre = subgenre;
            this.publishyear = publishyear;
            this.callNumber = callNumber;
            this.softCopy = softCopy;
            this.borrowable = borrowable;
            this.fineperDay = fineperDay;
            this.price = price;
            this.onShelf = onShelf;
        }

        public string Title { get => title; set => title = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string CallNumber { get => callNumber; set => callNumber = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Subgenre { get => subgenre; set => subgenre = value; }
        public int Publishyear { get => publishyear; set => publishyear = value; }
        public bool SoftCopy { get => softCopy; set => softCopy = value; }
        public bool Borrowable { get => borrowable; set => borrowable = value; }
        public int FineperDay { get => fineperDay; set => fineperDay = value; }
        public int Price { get => price; set => price = value; }
        public bool OnShelf { get => onShelf; set => onShelf = value; }
    }
}
