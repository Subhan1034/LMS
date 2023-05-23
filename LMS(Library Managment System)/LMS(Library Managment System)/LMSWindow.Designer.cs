
namespace LMS_Library_Managment_System_
{
    partial class LMSWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMSWindow));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnUserDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTtleBar = new System.Windows.Forms.Label();
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnReturn);
            this.pnlMenu.Controls.Add(this.btnBorrow);
            this.pnlMenu.Controls.Add(this.btnBook);
            this.pnlMenu.Controls.Add(this.btnUserDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 813);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 60);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "  EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(0, 334);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(250, 60);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = " RETURN BOOK";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.AutoSize = true;
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.Location = new System.Drawing.Point(0, 274);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrow.Size = new System.Drawing.Size(250, 60);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = " BORROW BOOK";
            this.btnBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBook
            // 
            this.btnBook.AutoSize = true;
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 214);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(250, 60);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "  BOOK ";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnUserDashboard
            // 
            this.btnUserDashboard.AutoSize = true;
            this.btnUserDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUserDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserDashboard.FlatAppearance.BorderSize = 0;
            this.btnUserDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnUserDashboard.Image")));
            this.btnUserDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDashboard.Location = new System.Drawing.Point(0, 154);
            this.btnUserDashboard.Name = "btnUserDashboard";
            this.btnUserDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUserDashboard.Size = new System.Drawing.Size(250, 60);
            this.btnUserDashboard.TabIndex = 0;
            this.btnUserDashboard.Text = "  USER DASHBOARD";
            this.btnUserDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserDashboard.UseVisualStyleBackColor = false;
            this.btnUserDashboard.Click += new System.EventHandler(this.btnUserDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.lblName);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 154);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NAME";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(189, 93);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "LMS";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitleBar.Controls.Add(this.lblTtleBar);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(250, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1432, 100);
            this.pnlTitleBar.TabIndex = 2;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // lblTtleBar
            // 
            this.lblTtleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTtleBar.AutoSize = true;
            this.lblTtleBar.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.lblTtleBar.ForeColor = System.Drawing.Color.White;
            this.lblTtleBar.Location = new System.Drawing.Point(242, 5);
            this.lblTtleBar.Name = "lblTtleBar";
            this.lblTtleBar.Size = new System.Drawing.Size(187, 93);
            this.lblTtleBar.TabIndex = 0;
            this.lblTtleBar.Text = "Title";
            this.lblTtleBar.Click += new System.EventHandler(this.lblTtleBar_Click);
            // 
            // pnlWindow
            // 
            this.pnlWindow.AutoSize = true;
            this.pnlWindow.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWindow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlWindow.Location = new System.Drawing.Point(250, 100);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(1432, 713);
            this.pnlWindow.TabIndex = 3;
            this.pnlWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWindow_Paint);
            // 
            // LMSWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1682, 813);
            this.Controls.Add(this.pnlWindow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "LMSWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LMSWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LMSWindow_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnUserDashboard;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTtleBar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlWindow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturn;
    }
}