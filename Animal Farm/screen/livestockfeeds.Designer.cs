
namespace Animal_Farm.screen
{
    partial class livestockfeeds
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.Prizes = new System.Windows.Forms.Label();
            this.AnimalName = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimalKind = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.Edit1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.Prizes);
            this.panel3.Controls.Add(this.AnimalName);
            this.panel3.Controls.Add(this.Weight);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Controls.Add(this.AnimalKind);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 389);
            this.panel3.TabIndex = 20;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.date.CustomFormat = "";
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(126, 232);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(229, 34);
            this.date.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(183, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "مصدر نباتي";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DimGray;
            this.name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.FormattingEnabled = true;
            this.name.Items.AddRange(new object[] {
            "القش",
            "شعير",
            "ذرة",
            "تبن",
            "برسيم"});
            this.name.Location = new System.Drawing.Point(126, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(229, 36);
            this.name.TabIndex = 20;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.DimGray;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.ForeColor = System.Drawing.Color.White;
            this.txtQuantity.Location = new System.Drawing.Point(140, 163);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(215, 27);
            this.txtQuantity.TabIndex = 15;
            // 
            // Prizes
            // 
            this.Prizes.AutoSize = true;
            this.Prizes.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prizes.Location = new System.Drawing.Point(26, 235);
            this.Prizes.Name = "Prizes";
            this.Prizes.Size = new System.Drawing.Size(66, 31);
            this.Prizes.TabIndex = 4;
            this.Prizes.Text = "Date";
            // 
            // AnimalName
            // 
            this.AnimalName.AutoSize = true;
            this.AnimalName.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnimalName.Location = new System.Drawing.Point(25, 43);
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.Size = new System.Drawing.Size(79, 31);
            this.AnimalName.TabIndex = 1;
            this.AnimalName.Text = "Name";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Weight.Location = new System.Drawing.Point(24, 175);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(110, 31);
            this.Weight.TabIndex = 3;
            this.Weight.Text = "Quantity";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(140, 196);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(215, 1);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // AnimalKind
            // 
            this.AnimalKind.AutoSize = true;
            this.AnimalKind.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnimalKind.Location = new System.Drawing.Point(25, 109);
            this.AnimalKind.Name = "AnimalKind";
            this.AnimalKind.Size = new System.Drawing.Size(67, 31);
            this.AnimalKind.TabIndex = 2;
            this.AnimalKind.Text = "Type";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btndelete1);
            this.panel4.Controls.Add(this.btnHome1);
            this.panel4.Controls.Add(this.btnAdd1);
            this.panel4.Controls.Add(this.Edit1);
            this.panel4.Location = new System.Drawing.Point(12, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 277);
            this.panel4.TabIndex = 31;
            // 
            // btndelete1
            // 
            this.btndelete1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete1.FlatAppearance.BorderSize = 3;
            this.btndelete1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndelete1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete1.Location = new System.Drawing.Point(38, 180);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(115, 48);
            this.btndelete1.TabIndex = 28;
            this.btndelete1.Text = "Delete";
            this.btndelete1.UseVisualStyleBackColor = true;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btnHome1
            // 
            this.btnHome1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome1.FlatAppearance.BorderSize = 3;
            this.btnHome1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome1.Location = new System.Drawing.Point(244, 182);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(110, 44);
            this.btnHome1.TabIndex = 25;
            this.btnHome1.Text = "Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd1.FlatAppearance.BorderSize = 3;
            this.btnAdd1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd1.Location = new System.Drawing.Point(35, 73);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(118, 40);
            this.btnAdd1.TabIndex = 26;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // Edit1
            // 
            this.Edit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Edit1.FlatAppearance.BorderSize = 3;
            this.Edit1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Edit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Edit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit1.Location = new System.Drawing.Point(245, 73);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(109, 40);
            this.Edit1.TabIndex = 27;
            this.Edit1.Text = "Edit";
            this.Edit1.UseVisualStyleBackColor = true;
            this.Edit1.Click += new System.EventHandler(this.Edit1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.txtSearch1);
            this.panel5.Controls.Add(this.btnSearch1);
            this.panel5.Location = new System.Drawing.Point(525, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 160);
            this.panel5.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(103, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 54);
            this.label6.TabIndex = 20;
            this.label6.Text = "مخازن الاغذية";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(102, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 22;
            // 
            // txtSearch1
            // 
            this.txtSearch1.BackColor = System.Drawing.Color.DimGray;
            this.txtSearch1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearch1.ForeColor = System.Drawing.Color.White;
            this.txtSearch1.Location = new System.Drawing.Point(102, 118);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.PlaceholderText = "Serech Here";
            this.txtSearch1.Size = new System.Drawing.Size(215, 31);
            this.txtSearch1.TabIndex = 23;
            this.txtSearch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch1.Location = new System.Drawing.Point(380, 122);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(127, 38);
            this.btnSearch1.TabIndex = 21;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv2.Location = new System.Drawing.Point(397, 178);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 29;
            this.dgv2.Size = new System.Drawing.Size(782, 533);
            this.dgv2.TabIndex = 33;
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh1.Location = new System.Drawing.Point(1051, 134);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(127, 38);
            this.btnRefresh1.TabIndex = 34;
            this.btnRefresh1.Text = "Refresh";
            this.btnRefresh1.UseVisualStyleBackColor = false;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // livestockfeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1181, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "livestockfeeds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.livestockfeeds_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label Prizes;
        private System.Windows.Forms.Label AnimalName;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label AnimalKind;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button Edit1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
    }
}