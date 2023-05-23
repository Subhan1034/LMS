
namespace LMS_Library_Managment_System_
{
    partial class SearchCatalouge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.cmbSearchBook = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBorrowable = new System.Windows.Forms.Label();
            this.lblOnShelf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubGenere = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCallNum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.79524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.5786F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 757);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchBook);
            this.panel2.Controls.Add(this.txtSearchBook);
            this.panel2.Controls.Add(this.cmbSearchBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1441, 131);
            this.panel2.TabIndex = 13;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.btnSearchBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.Black;
            this.btnSearchBook.Location = new System.Drawing.Point(1296, 71);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(145, 60);
            this.btnSearchBook.TabIndex = 17;
            this.btnSearchBook.Text = "SEARCH";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.BackColor = System.Drawing.Color.White;
            this.txtSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBook.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBook.Location = new System.Drawing.Point(0, 35);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(1441, 36);
            this.txtSearchBook.TabIndex = 16;
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchBook
            // 
            this.cmbSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.cmbSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSearchBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBook.ForeColor = System.Drawing.Color.White;
            this.cmbSearchBook.FormattingEnabled = true;
            this.cmbSearchBook.Items.AddRange(new object[] {
            "TITLE",
            "CALL NUMBER"});
            this.cmbSearchBook.Location = new System.Drawing.Point(0, 0);
            this.cmbSearchBook.Name = "cmbSearchBook";
            this.cmbSearchBook.Size = new System.Drawing.Size(1441, 35);
            this.cmbSearchBook.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.lblBorrowable);
            this.panel1.Controls.Add(this.lblOnShelf);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSubGenere);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAuthorName);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblCallNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 614);
            this.panel1.TabIndex = 0;
            // 
            // lblBorrowable
            // 
            this.lblBorrowable.AutoSize = true;
            this.lblBorrowable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblBorrowable.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBorrowable.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowable.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowable.Location = new System.Drawing.Point(0, 302);
            this.lblBorrowable.Name = "lblBorrowable";
            this.lblBorrowable.Size = new System.Drawing.Size(235, 36);
            this.lblBorrowable.TabIndex = 12;
            this.lblBorrowable.Text = "→Borrowable";
            this.lblBorrowable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOnShelf
            // 
            this.lblOnShelf.AutoSize = true;
            this.lblOnShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblOnShelf.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOnShelf.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnShelf.ForeColor = System.Drawing.Color.Black;
            this.lblOnShelf.Location = new System.Drawing.Point(0, 266);
            this.lblOnShelf.Name = "lblOnShelf";
            this.lblOnShelf.Size = new System.Drawing.Size(195, 36);
            this.lblOnShelf.TabIndex = 11;
            this.lblOnShelf.Text = "→On Shelf";
            this.lblOnShelf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 10;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubGenere
            // 
            this.lblSubGenere.AutoSize = true;
            this.lblSubGenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblSubGenere.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubGenere.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGenere.ForeColor = System.Drawing.Color.Black;
            this.lblSubGenere.Location = new System.Drawing.Point(0, 194);
            this.lblSubGenere.Name = "lblSubGenere";
            this.lblSubGenere.Size = new System.Drawing.Size(215, 36);
            this.lblSubGenere.TabIndex = 9;
            this.lblSubGenere.Text = "LITERATURE";
            this.lblSubGenere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGenre.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(0, 158);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(195, 36);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "CLASSICAL";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 36);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthorName.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.Black;
            this.lblAuthorName.Location = new System.Drawing.Point(0, 77);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(548, 45);
            this.lblAuthorName.TabIndex = 6;
            this.lblAuthorName.Text = "BY HENRY CLARK WHILSON";
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 46);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "IN THE OLD DAYS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCallNum
            // 
            this.lblCallNum.AutoSize = true;
            this.lblCallNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.lblCallNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCallNum.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallNum.ForeColor = System.Drawing.Color.Black;
            this.lblCallNum.Location = new System.Drawing.Point(0, 0);
            this.lblCallNum.Name = "lblCallNum";
            this.lblCallNum.Size = new System.Drawing.Size(303, 31);
            this.lblCallNum.TabIndex = 3;
            this.lblCallNum.Text = "LB 2395 .C65 1991";
            this.lblCallNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchCatalouge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchCatalouge";
            this.Text = "BorrowABook";
            this.Load += new System.EventHandler(this.BorrowABook_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.ComboBox cmbSearchBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBorrowable;
        private System.Windows.Forms.Label lblOnShelf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubGenere;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCallNum;
        private System.Windows.Forms.Button btnSearchBook;
    }
}