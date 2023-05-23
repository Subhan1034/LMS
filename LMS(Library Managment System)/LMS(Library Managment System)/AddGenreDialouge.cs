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
using LMS_Library_Managment_System_.DL;

namespace LMS_Library_Managment_System_
{
    public partial class AddGenreDialouge : Form
    {
        private string Genre;
        private char GenreCode;
        public AddGenreDialouge()
        {
            InitializeComponent();
        }
        public AddGenreDialouge(string Genre,char GenreCode)
        {
            InitializeComponent();
            this.Genre = Genre;
            this.GenreCode = GenreCode;
            txtGenre.Enabled = false;
            txtGenreCode.Enabled = false;
        }


        private void AddGenreDialouge_Load(object sender, EventArgs e)
        {
            txtGenre.Text = Genre;
            txtGenreCode.Text = GenreCode.ToString();
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtSubGenre.Text != "" && txtSubGenreCode.Text != "" && txtGenre.Text!="" && txtGenreCode.Text != "")
            {
                Genre type = new Genre(txtGenre.Text, char.Parse(txtGenreCode.Text), txtSubGenre.Text, txtSubGenreCode.Text);
                if(txtGenre.Enabled==false)
                {
                    if (GenreDL.EqualSubGen(type) == "")
                    {
                        Genre gen = GenreDL.SearchbyGen_GenCode(type);
                        GenreDL.addtoListofSubGen(gen,txtSubGenre.Text);
                        GenreDL.addtoListofCodes(gen,txtGenreCode.Text);
                        GenreDL.StoreData("GenreData.txt");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(GenreDL.Equal(type));
                    }
                }
                else
                {
                    if (GenreDL.Equal(type) == "")
                    {
                        GenreDL.addtoList(type);
                        GenreDL.StoreData("GenreData.txt");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(GenreDL.Equal(type));
                    }
                }
            }
            else
            {
                MessageBox.Show("EMPTY CREDENTIALS ARE NOT ALLOWED!");
            }
        }
    }
}
