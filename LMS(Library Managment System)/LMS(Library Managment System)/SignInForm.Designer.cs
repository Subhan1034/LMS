
namespace LMS_Library_Managment_System_
{
    partial class SignInForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSubmitt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWrongCredentials = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEye = new System.Windows.Forms.Button();
            this.lblLMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(926, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 73);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOGIN";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.White;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.ForeColor = System.Drawing.Color.Black;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "ADMIN",
            "STUDENT"});
            this.cmbRole.Location = new System.Drawing.Point(892, 148);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(373, 35);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.Tag = "";
            this.cmbRole.TextChanged += new System.EventHandler(this.CredientialChanged);
            this.cmbRole.Click += new System.EventHandler(this.Credential_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(754, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "ROLE:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(680, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "USERNAME:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(892, 326);
            this.txtPassword.MaximumSize = new System.Drawing.Size(400, 40);
            this.txtPassword.MaxLength = 9;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'O';
            this.txtPassword.Size = new System.Drawing.Size(373, 38);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Click += new System.EventHandler(this.Credential_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.CredientialChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(892, 239);
            this.txtUserName.MaximumSize = new System.Drawing.Size(400, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(373, 38);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Click += new System.EventHandler(this.Credential_Click);
            this.txtUserName.TextChanged += new System.EventHandler(this.CredientialChanged);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // btnSubmitt
            // 
            this.btnSubmitt.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitt.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitt.Location = new System.Drawing.Point(1126, 459);
            this.btnSubmitt.Name = "btnSubmitt";
            this.btnSubmitt.Size = new System.Drawing.Size(139, 46);
            this.btnSubmitt.TabIndex = 12;
            this.btnSubmitt.Text = "Submitt";
            this.btnSubmitt.UseVisualStyleBackColor = true;
            this.btnSubmitt.Click += new System.EventHandler(this.btnSubmitt_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(672, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "PASSWORD:";
            // 
            // lblWrongCredentials
            // 
            this.lblWrongCredentials.BackColor = System.Drawing.Color.Maroon;
            this.lblWrongCredentials.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCredentials.ForeColor = System.Drawing.Color.White;
            this.lblWrongCredentials.Location = new System.Drawing.Point(686, 524);
            this.lblWrongCredentials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWrongCredentials.Name = "lblWrongCredentials";
            this.lblWrongCredentials.Size = new System.Drawing.Size(599, 54);
            this.lblWrongCredentials.TabIndex = 18;
            this.lblWrongCredentials.Text = "WRONG CREDENTIALS !";
            this.lblWrongCredentials.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWrongCredentials.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
            this.btnClear.Location = new System.Drawing.Point(686, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 46);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEye
            // 
            this.btnEye.AutoSize = true;
            this.btnEye.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
            this.btnEye.Image = ((System.Drawing.Image)(resources.GetObject("btnEye.Image")));
            this.btnEye.Location = new System.Drawing.Point(1271, 323);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(62, 44);
            this.btnEye.TabIndex = 20;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            this.btnEye.MouseEnter += new System.EventHandler(this.btnEye_MouseEnter);
            this.btnEye.MouseLeave += new System.EventHandler(this.btnEye_MouseLeave);
            // 
            // lblLMS
            // 
            this.lblLMS.AutoSize = true;
            this.lblLMS.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lblLMS.Location = new System.Drawing.Point(3, 386);
            this.lblLMS.Name = "lblLMS";
            this.lblLMS.Size = new System.Drawing.Size(0, 70);
            this.lblLMS.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblLMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 864);
            this.panel1.TabIndex = 19;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1345, 864);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWrongCredentials);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmitt);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LIBRARY MANAGMENT SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSubmitt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWrongCredentials;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Label lblLMS;
        private System.Windows.Forms.Panel panel1;
    }
}

