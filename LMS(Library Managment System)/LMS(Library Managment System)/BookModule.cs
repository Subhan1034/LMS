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
    public partial class BookModule : Form
    {
        private Book record;
        public BookModule()
        {
            InitializeComponent();
        }

        private void BookModule_Load(object sender, EventArgs e)
        {
            DataBind();
            GridColor();
        }
        public void DataBind()
        {
            gvBook.DataSource = null;
            gvBook.DataSource = BOOKDL.AllBooks;
            gvBook.Refresh();
        }
        public void GridColor()
        {
            for (int i = 0; i < gvBook.Columns.Count; i++)
            {
                gvBook.Columns[i].HeaderCell.Style.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
                gvBook.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                //gvBook.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                //gvBook.Rows[i].HeaderCell.Style.BackColor = Color.Black;
                gvBook.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular);
                if (i % 2 == 0)
                {
                    gvBook.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    gvBook.Columns[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddaBook frm = new AddaBook();
            frm.ShowDialog();
            if(frm.getBook()!=null)
            {
                BOOKDL.AddtoList(frm.getBook());
                BOOKDL.StoreData("BookData.txt");
                DataBind();
                GridColor();
            }
        }

        private void gvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            record = (Book)gvBook.CurrentRow.DataBoundItem;
            // if (gvBook.Columns["EDIT"].Index == e.ColumnIndex)
            // {
            //     
            // }
            //try
            //{
                if (gvBook.Columns["DEL"].Index == e.ColumnIndex)
                {
                    DialogResult delete = MessageBox.Show("Do you want to delete record?", "CONFIRM DELETION", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        BOOKDL.DeleteaRec(record);
                        BOOKDL.StoreData("BookData.txt");
                        DataBind();
                        GridColor();
                    }
                }
                else if (gvBook.Columns["UPDATE"].Index == e.ColumnIndex)
                {
                UpdateaBook frm = new UpdateaBook(record);
                frm.ShowDialog();
                BOOKDL.StoreData("BookData.txt");
                DataBind();
                GridColor();

                //if (delete == DialogResult.Yes)
                //{
                //    BOOKDL.DeleteaRec(record);
                //    BOOKDL.StoreData("BookData.txt");
                //    DataBind();
                //    GridColor();
                //}
            }
            //}
            //catch(Exception exp)
            //{
            //    if (gvBook.Columns["DELETE"].Index == e.ColumnIndex)
            //    {
            //        DialogResult delete = MessageBox.Show("Do you want to delete record?", "CONFIRM DELETION", MessageBoxButtons.YesNo);
            //        if (delete == DialogResult.Yes)
            //        {
            //            BOOKDL.DeleteaRec(record);
            //            BOOKDL.StoreData("BookData.txt");
            //            DataBind();
            //            GridColor();
            //        }
            //    }
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if(txtSearch.Text="")
            //{
            //}
        }

    }
}
