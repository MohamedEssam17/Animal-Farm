
namespace Animal_Farm.screen
{
    partial class productions
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
            this.type = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Prizes = new System.Windows.Forms.Label();
            this.AnimalName = new System.Windows.Forms.Label();
            this.txtPrizes2 = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.AnimalKind = new System.Windows.Forms.Label();
            this.txtQuantity2 = new System.Windows.Forms.TextBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuy2 = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.Edit2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.type);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.Prizes);
            this.panel3.Controls.Add(this.AnimalName);
            this.panel3.Controls.Add(this.txtPrizes2);
            this.panel3.Controls.Add(this.Weight);
            this.panel3.Controls.Add(this.AnimalKind);
            this.panel3.Controls.Add(this.txtQuantity2);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 389);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.date.CustomFormat = "";
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(125, 175);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(229, 34);
            this.date.TabIndex = 23;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.DimGray;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "حليب ابقار",
            "حليب جاموس",
            "حليب ماعز"});
            this.type.Location = new System.Drawing.Point(125, 52);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(229, 36);
            this.type.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(138, 136);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 1);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(139, 255);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(215, 1);
            this.flowLayoutPanel4.TabIndex = 18;
            // 
            // Prizes
            // 
            this.Prizes.AutoSize = true;
            this.Prizes.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prizes.Location = new System.Drawing.Point(14, 242);
            this.Prizes.Name = "Prizes";
            this.Prizes.Size = new System.Drawing.Size(80, 31);
            this.Prizes.TabIndex = 4;
            this.Prizes.Text = "Prices";
            // 
            // AnimalName
            // 
            this.AnimalName.AutoSize = true;
            this.AnimalName.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnimalName.Location = new System.Drawing.Point(14, 48);
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.Size = new System.Drawing.Size(67, 31);
            this.AnimalName.TabIndex = 1;
            this.AnimalName.Text = "Type";
            // 
            // txtPrizes2
            // 
            this.txtPrizes2.BackColor = System.Drawing.Color.DimGray;
            this.txtPrizes2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrizes2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrizes2.ForeColor = System.Drawing.Color.White;
            this.txtPrizes2.Location = new System.Drawing.Point(135, 224);
            this.txtPrizes2.Name = "txtPrizes2";
            this.txtPrizes2.Size = new System.Drawing.Size(215, 27);
            this.txtPrizes2.TabIndex = 17;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Weight.Location = new System.Drawing.Point(14, 178);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(68, 31);
            this.Weight.TabIndex = 3;
            this.Weight.Text = "Time";
            // 
            // AnimalKind
            // 
            this.AnimalKind.AutoSize = true;
            this.AnimalKind.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnimalKind.Location = new System.Drawing.Point(14, 109);
            this.AnimalKind.Name = "AnimalKind";
            this.AnimalKind.Size = new System.Drawing.Size(110, 31);
            this.AnimalKind.TabIndex = 2;
            this.AnimalKind.Text = "Quantity";
            // 
            // txtQuantity2
            // 
            this.txtQuantity2.BackColor = System.Drawing.Color.DimGray;
            this.txtQuantity2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity2.ForeColor = System.Drawing.Color.White;
            this.txtQuantity2.Location = new System.Drawing.Point(136, 109);
            this.txtQuantity2.Name = "txtQuantity2";
            this.txtQuantity2.Size = new System.Drawing.Size(215, 27);
            this.txtQuantity2.TabIndex = 13;
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv3.Location = new System.Drawing.Point(397, 158);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 29;
            this.dgv3.Size = new System.Drawing.Size(784, 514);
            this.dgv3.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.txtSearch2);
            this.panel5.Location = new System.Drawing.Point(538, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(509, 149);
            this.panel5.TabIndex = 32;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(202, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 54);
            this.label6.TabIndex = 20;
            this.label6.Text = "الانتاج";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(102, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 22;
            // 
            // txtSearch2
            // 
            this.txtSearch2.BackColor = System.Drawing.Color.DimGray;
            this.txtSearch2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearch2.ForeColor = System.Drawing.Color.White;
            this.txtSearch2.Location = new System.Drawing.Point(102, 118);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.PlaceholderText = "Serech Here";
            this.txtSearch2.Size = new System.Drawing.Size(215, 31);
            this.txtSearch2.TabIndex = 23;
            this.txtSearch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch2.Location = new System.Drawing.Point(1053, 55);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(127, 38);
            this.btnSearch2.TabIndex = 21;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh2.Location = new System.Drawing.Point(1053, 114);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(127, 38);
            this.btnRefresh2.TabIndex = 33;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBuy2);
            this.panel4.Controls.Add(this.btnHome2);
            this.panel4.Controls.Add(this.btnAdd2);
            this.panel4.Controls.Add(this.Edit2);
            this.panel4.Location = new System.Drawing.Point(2, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 257);
            this.panel4.TabIndex = 34;
            // 
            // btnBuy2
            // 
            this.btnBuy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy2.ForeColor = System.Drawing.Color.Black;
            this.btnBuy2.Location = new System.Drawing.Point(38, 180);
            this.btnBuy2.Name = "btnBuy2";
            this.btnBuy2.Size = new System.Drawing.Size(115, 48);
            this.btnBuy2.TabIndex = 28;
            this.btnBuy2.Text = "Delete";
            this.btnBuy2.UseVisualStyleBackColor = true;
            this.btnBuy2.Click += new System.EventHandler(this.btnBuy2_Click);
            // 
            // btnHome2
            // 
            this.btnHome2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome2.ForeColor = System.Drawing.Color.Black;
            this.btnHome2.Location = new System.Drawing.Point(245, 180);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(109, 48);
            this.btnHome2.TabIndex = 25;
            this.btnHome2.Text = "Home";
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd2.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.Location = new System.Drawing.Point(35, 73);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(118, 40);
            this.btnAdd2.TabIndex = 26;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // Edit2
            // 
            this.Edit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit2.ForeColor = System.Drawing.Color.Black;
            this.Edit2.Location = new System.Drawing.Point(245, 73);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(109, 40);
            this.Edit2.TabIndex = 27;
            this.Edit2.Text = "Edit";
            this.Edit2.UseVisualStyleBackColor = true;
            this.Edit2.Click += new System.EventHandler(this.Edit2_Click);
            // 
            // productions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1181, 667);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.panel3);
            this.Name = "productions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.productions_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label Prizes;
        private System.Windows.Forms.Label AnimalName;
        private System.Windows.Forms.TextBox txtPrizes2;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label AnimalKind;
        private System.Windows.Forms.TextBox txtQuantity2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuy2;
        private System.Windows.Forms.Button btnHome2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button Edit2;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.DateTimePicker date;
    }
}