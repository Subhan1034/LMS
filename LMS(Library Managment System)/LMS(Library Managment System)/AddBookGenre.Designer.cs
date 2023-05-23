
namespace LMS_Library_Managment_System_
{
    partial class AddBookGenre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvGenre = new System.Windows.Forms.DataGridView();
            this.ADDSUBGENRE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SUBGENRE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubGenreCode = new System.Windows.Forms.Label();
            this.txtSubGenreCode = new System.Windows.Forms.TextBox();
            this.lblGenreCode = new System.Windows.Forms.Label();
            this.txtGenreCode = new System.Windows.Forms.TextBox();
            this.lblSubGenre = new System.Windows.Forms.Label();
            this.txtSubGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnADDSubGenre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblG = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddaGenre = new System.Windows.Forms.Label();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGenre)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.88804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.11196F));
            this.tableLayoutPanel1.Controls.Add(this.gvGenre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.43299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.56701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 747);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gvGenre
            // 
            this.gvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvGenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvGenre.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADDSUBGENRE,
            this.SUBGENRE});
            this.gvGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGenre.Location = new System.Drawing.Point(666, 106);
            this.gvGenre.Name = "gvGenre";
            this.gvGenre.RowHeadersWidth = 51;
            this.gvGenre.RowTemplate.Height = 24;
            this.gvGenre.Size = new System.Drawing.Size(778, 607);
            this.gvGenre.TabIndex = 15;
            this.gvGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGenre_CellContentClick);
            // 
            // ADDSUBGENRE
            // 
            this.ADDSUBGENRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ADDSUBGENRE.HeaderText = "ADD SUB-GENRE";
            this.ADDSUBGENRE.MinimumWidth = 6;
            this.ADDSUBGENRE.Name = "ADDSUBGENRE";
            this.ADDSUBGENRE.Text = "ADD";
            this.ADDSUBGENRE.UseColumnTextForButtonValue = true;
            this.ADDSUBGENRE.Width = 113;
            // 
            // SUBGENRE
            // 
            this.SUBGENRE.HeaderText = "SUB-GENRE";
            this.SUBGENRE.MinimumWidth = 6;
            this.SUBGENRE.Name = "SUBGENRE";
            this.SUBGENRE.Width = 93;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07496F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92504F));
            this.tableLayoutPanel2.Controls.Add(this.lblSubGenreCode, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtSubGenreCode, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblGenreCode, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtGenreCode, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSubGenre, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtSubGenre, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblGenre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGenre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnADDSubGenre, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(657, 455);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblSubGenreCode
            // 
            this.lblSubGenreCode.AutoSize = true;
            this.lblSubGenreCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubGenreCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubGenreCode.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGenreCode.ForeColor = System.Drawing.Color.Black;
            this.lblSubGenreCode.Location = new System.Drawing.Point(3, 250);
            this.lblSubGenreCode.Name = "lblSubGenreCode";
            this.lblSubGenreCode.Size = new System.Drawing.Size(322, 50);
            this.lblSubGenreCode.TabIndex = 34;
            this.lblSubGenreCode.Text = "SUB-GENRE CODE:";
            this.lblSubGenreCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubGenreCode
            // 
            this.txtSubGenreCode.BackColor = System.Drawing.Color.White;
            this.txtSubGenreCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubGenreCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubGenreCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubGenreCode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubGenreCode.ForeColor = System.Drawing.Color.Black;
            this.txtSubGenreCode.Location = new System.Drawing.Point(331, 253);
            this.txtSubGenreCode.MaxLength = 2;
            this.txtSubGenreCode.Name = "txtSubGenreCode";
            this.txtSubGenreCode.Size = new System.Drawing.Size(323, 36);
            this.txtSubGenreCode.TabIndex = 33;
            this.txtSubGenreCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubGenreCode_KeyPress);
            // 
            // lblGenreCode
            // 
            this.lblGenreCode.AutoSize = true;
            this.lblGenreCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGenreCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenreCode.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreCode.ForeColor = System.Drawing.Color.Black;
            this.lblGenreCode.Location = new System.Drawing.Point(3, 100);
            this.lblGenreCode.Name = "lblGenreCode";
            this.lblGenreCode.Size = new System.Drawing.Size(322, 50);
            this.lblGenreCode.TabIndex = 29;
            this.lblGenreCode.Text = "GENRE CHAR:";
            this.lblGenreCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGenreCode
            // 
            this.txtGenreCode.BackColor = System.Drawing.Color.White;
            this.txtGenreCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenreCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGenreCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGenreCode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreCode.ForeColor = System.Drawing.Color.Black;
            this.txtGenreCode.Location = new System.Drawing.Point(331, 103);
            this.txtGenreCode.MaxLength = 1;
            this.txtGenreCode.Name = "txtGenreCode";
            this.txtGenreCode.Size = new System.Drawing.Size(323, 36);
            this.txtGenreCode.TabIndex = 30;
            this.txtGenreCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenreCode_KeyPress);
            // 
            // lblSubGenre
            // 
            this.lblSubGenre.AutoSize = true;
            this.lblSubGenre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubGenre.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGenre.ForeColor = System.Drawing.Color.Black;
            this.lblSubGenre.Location = new System.Drawing.Point(3, 200);
            this.lblSubGenre.Name = "lblSubGenre";
            this.lblSubGenre.Size = new System.Drawing.Size(322, 50);
            this.lblSubGenre.TabIndex = 28;
            this.lblSubGenre.Text = "SUB-GENRE:";
            this.lblSubGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubGenre
            // 
            this.txtSubGenre.BackColor = System.Drawing.Color.White;
            this.txtSubGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubGenre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubGenre.ForeColor = System.Drawing.Color.Black;
            this.txtSubGenre.Location = new System.Drawing.Point(331, 203);
            this.txtSubGenre.Name = "txtSubGenre";
            this.txtSubGenre.Size = new System.Drawing.Size(323, 36);
            this.txtSubGenre.TabIndex = 27;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(3, 50);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(322, 50);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "GENRE:";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.White;
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.ForeColor = System.Drawing.Color.Black;
            this.txtGenre.Location = new System.Drawing.Point(331, 53);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(323, 36);
            this.txtGenre.TabIndex = 4;
            // 
            // btnADDSubGenre
            // 
            this.btnADDSubGenre.BackColor = System.Drawing.Color.DarkGray;
            this.btnADDSubGenre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDSubGenre.ForeColor = System.Drawing.Color.Black;
            this.btnADDSubGenre.Location = new System.Drawing.Point(331, 303);
            this.btnADDSubGenre.Name = "btnADDSubGenre";
            this.btnADDSubGenre.Size = new System.Drawing.Size(311, 44);
            this.btnADDSubGenre.TabIndex = 35;
            this.btnADDSubGenre.Text = "ADD SUB-GENRE";
            this.btnADDSubGenre.UseVisualStyleBackColor = false;
            this.btnADDSubGenre.Click += new System.EventHandler(this.btnADDSubGenre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblG);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.cmbSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(666, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 97);
            this.panel2.TabIndex = 4;
            // 
            // lblG
            // 
            this.lblG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Gainsboro;
            this.lblG.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.Color.Black;
            this.lblG.Location = new System.Drawing.Point(277, 58);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(202, 34);
            this.lblG.TabIndex = 30;
            this.lblG.Text = "GENRE CHAR:";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblG.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(234, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(544, 36);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // cmbSearch
            // 
            this.cmbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.cmbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.ForeColor = System.Drawing.Color.White;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "ALL",
            "GENRE",
            "GENRECODE"});
            this.cmbSearch.Location = new System.Drawing.Point(0, 0);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(208, 35);
            this.cmbSearch.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 34);
            this.label5.TabIndex = 12;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblAddaGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 97);
            this.panel1.TabIndex = 2;
            // 
            // lblAddaGenre
            // 
            this.lblAddaGenre.AutoSize = true;
            this.lblAddaGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.lblAddaGenre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAddaGenre.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddaGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddaGenre.Location = new System.Drawing.Point(0, 27);
            this.lblAddaGenre.Name = "lblAddaGenre";
            this.lblAddaGenre.Size = new System.Drawing.Size(427, 70);
            this.lblAddaGenre.TabIndex = 2;
            this.lblAddaGenre.Text = "ADD A GENRE";
            // 
            // EDIT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "EDIT";
            this.EDIT.DefaultCellStyle = dataGridViewCellStyle1;
            this.EDIT.FillWeight = 14.68429F;
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Width = 50;
            // 
            // DELETE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "DELETE";
            this.DELETE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DELETE.FillWeight = 185.3158F;
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 73;
            // 
            // AddBookGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddBookGenre";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "AddBookGenre";
            this.Load += new System.EventHandler(this.AddBookGenre_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGenre)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddaGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvGenre;
        private System.Windows.Forms.Label lblSubGenre;
        private System.Windows.Forms.TextBox txtSubGenre;
        private System.Windows.Forms.Label lblSubGenreCode;
        private System.Windows.Forms.TextBox txtSubGenreCode;
        private System.Windows.Forms.Label lblGenreCode;
        private System.Windows.Forms.TextBox txtGenreCode;
        private System.Windows.Forms.Button btnADDSubGenre;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.DataGridViewButtonColumn ADDSUBGENRE;
        private System.Windows.Forms.DataGridViewComboBoxColumn SUBGENRE;
    }
}