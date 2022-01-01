
namespace Animal_Farm.screen
{
    partial class sell
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
            this.tradernames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemtosell = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Prizes = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Homepd = new System.Windows.Forms.Button();
            this.dgv5 = new System.Windows.Forms.DataGridView();
            this.btndelet5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
            this.SuspendLayout();
            // 
            // tradernames
            // 
            this.tradernames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tradernames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tradernames.BackColor = System.Drawing.Color.DimGray;
            this.tradernames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tradernames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tradernames.FormattingEnabled = true;
            this.tradernames.Location = new System.Drawing.Point(22, 66);
            this.tradernames.Name = "tradernames";
            this.tradernames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tradernames.Size = new System.Drawing.Size(410, 36);
            this.tradernames.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم التاجر";
            // 
            // itemtosell
            // 
            this.itemtosell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemtosell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemtosell.BackColor = System.Drawing.Color.DimGray;
            this.itemtosell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemtosell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemtosell.FormattingEnabled = true;
            this.itemtosell.Location = new System.Drawing.Point(22, 166);
            this.itemtosell.Name = "itemtosell";
            this.itemtosell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemtosell.Size = new System.Drawing.Size(411, 36);
            this.itemtosell.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "اسم المنتج";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.SystemColors.ControlDark;
            this.date.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(-148, 491);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 31);
            this.date.TabIndex = 27;
            this.date.Text = "00:00:00";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(894, 531);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(136, 34);
            this.quantity.TabIndex = 28;
            this.quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1086, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "الكمية";
            // 
            // itemPrice
            // 
            this.itemPrice.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.itemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemPrice.Location = new System.Drawing.Point(442, 531);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(163, 34);
            this.itemPrice.TabIndex = 30;
            this.itemPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(636, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "سعر القطعه";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(45, 534);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(143, 34);
            this.total.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "الاجمالي";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.CustomFormat = "dd/M/yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 34);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // Prizes
            // 
            this.Prizes.AutoSize = true;
            this.Prizes.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prizes.Location = new System.Drawing.Point(340, 231);
            this.Prizes.Name = "Prizes";
            this.Prizes.Size = new System.Drawing.Size(71, 31);
            this.Prizes.TabIndex = 33;
            this.Prizes.Text = "التاريخ";
            // 
            // paid
            // 
            this.paid.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paid.Location = new System.Drawing.Point(700, 598);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(353, 34);
            this.paid.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1068, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "المدفوع";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(69, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 52);
            this.button1.TabIndex = 37;
            this.button1.Text = "Save the bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Homepd
            // 
            this.Homepd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Homepd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Homepd.Location = new System.Drawing.Point(360, 654);
            this.Homepd.Name = "Homepd";
            this.Homepd.Size = new System.Drawing.Size(146, 44);
            this.Homepd.TabIndex = 38;
            this.Homepd.Text = "Home";
            this.Homepd.UseVisualStyleBackColor = false;
            this.Homepd.Click += new System.EventHandler(this.Homepd_Click);
            // 
            // dgv5
            // 
            this.dgv5.AllowUserToAddRows = false;
            this.dgv5.AllowUserToDeleteRows = false;
            this.dgv5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv5.Location = new System.Drawing.Point(483, 12);
            this.dgv5.Name = "dgv5";
            this.dgv5.RowHeadersWidth = 51;
            this.dgv5.RowTemplate.Height = 29;
            this.dgv5.Size = new System.Drawing.Size(703, 446);
            this.dgv5.TabIndex = 39;
            // 
            // btndelet5
            // 
            this.btndelet5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelet5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelet5.FlatAppearance.BorderSize = 3;
            this.btndelet5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndelet5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelet5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelet5.Location = new System.Drawing.Point(588, 655);
            this.btndelet5.Name = "btndelet5";
            this.btndelet5.Size = new System.Drawing.Size(115, 48);
            this.btndelet5.TabIndex = 40;
            this.btndelet5.Text = "Delete";
            this.btndelet5.UseVisualStyleBackColor = true;
            this.btndelet5.Click += new System.EventHandler(this.btndelet5_Click);
            // 
            // sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1182, 729);
            this.ControlBox = false;
            this.Controls.Add(this.btndelet5);
            this.Controls.Add(this.dgv5);
            this.Controls.Add(this.Homepd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Prizes);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemtosell);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tradernames);
            this.Name = "sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tradernames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemtosell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Prizes;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Homepd;
        private System.Windows.Forms.DataGridView dgv5;
        private System.Windows.Forms.Button btndelet5;
    }
}