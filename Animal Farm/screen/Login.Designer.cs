
namespace Animal_Farm
{
    partial class Login_frm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm2));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(198, 173);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(144, 29);
            this.username.TabIndex = 0;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(198, 240);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(128, 29);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.Beige;
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textpassword.Location = new System.Drawing.Point(360, 244);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.PlaceholderText = "Enter password";
            this.textpassword.Size = new System.Drawing.Size(215, 27);
            this.textpassword.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Beige;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt1.Location = new System.Drawing.Point(371, 168);
            this.txt1.Name = "txt1";
            this.txt1.PlaceholderText = "Enter username";
            this.txt1.Size = new System.Drawing.Size(215, 27);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(360, 321);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(240, 58);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Beige;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(381, 396);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(205, 38);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(460, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 547);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Account";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(371, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(354, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(354, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 1);
            this.panel4.TabIndex = 12;
            // 
            // Login_frm2
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(683, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_frm2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}