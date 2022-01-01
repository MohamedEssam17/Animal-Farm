
namespace Animal_Farm.screen
{
    partial class feeding
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastFood = new System.Windows.Forms.Label();
            this.feedingTime = new System.Windows.Forms.Label();
            this.animalCount = new System.Windows.Forms.Label();
            this.animalName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 45);
            this.panel1.TabIndex = 0;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DimGray;
            this.name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.FormattingEnabled = true;
            this.name.Items.AddRange(new object[] {
            "بقر",
            "جاموس",
            "ماعز"});
            this.name.Location = new System.Drawing.Point(232, 106);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(279, 36);
            this.name.TabIndex = 20;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(304, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "اختار الحيوان";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.food);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lastFood);
            this.panel2.Controls.Add(this.feedingTime);
            this.panel2.Controls.Add(this.animalCount);
            this.panel2.Controls.Add(this.animalName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(57, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 311);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(115, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "اطعام";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(456, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "اخر  تغذية";
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.DimGray;
            this.food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.food.FormattingEnabled = true;
            this.food.Items.AddRange(new object[] {
            "القش",
            "شعير",
            "ذرة",
            "تبن",
            "برسيم"});
            this.food.Location = new System.Drawing.Point(230, 257);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(338, 36);
            this.food.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(285, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "عدد مرات الاطعام لهذا اليوم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(391, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "عدد افراد القطيع";
            // 
            // lastFood
            // 
            this.lastFood.AutoSize = true;
            this.lastFood.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastFood.ForeColor = System.Drawing.Color.Cornsilk;
            this.lastFood.Location = new System.Drawing.Point(156, 177);
            this.lastFood.Name = "lastFood";
            this.lastFood.Size = new System.Drawing.Size(66, 31);
            this.lastFood.TabIndex = 22;
            this.lastFood.Text = "لا شئ";
            // 
            // feedingTime
            // 
            this.feedingTime.AutoSize = true;
            this.feedingTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feedingTime.ForeColor = System.Drawing.Color.Cornsilk;
            this.feedingTime.Location = new System.Drawing.Point(178, 123);
            this.feedingTime.Name = "feedingTime";
            this.feedingTime.Size = new System.Drawing.Size(27, 31);
            this.feedingTime.TabIndex = 22;
            this.feedingTime.Text = "0";
            // 
            // animalCount
            // 
            this.animalCount.AutoSize = true;
            this.animalCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.animalCount.ForeColor = System.Drawing.Color.Cornsilk;
            this.animalCount.Location = new System.Drawing.Point(178, 69);
            this.animalCount.Name = "animalCount";
            this.animalCount.Size = new System.Drawing.Size(27, 31);
            this.animalCount.TabIndex = 22;
            this.animalCount.Text = "0";
            // 
            // animalName
            // 
            this.animalName.AutoSize = true;
            this.animalName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.animalName.ForeColor = System.Drawing.Color.Lavender;
            this.animalName.Location = new System.Drawing.Point(178, 21);
            this.animalName.Name = "animalName";
            this.animalName.Size = new System.Drawing.Size(44, 31);
            this.animalName.TabIndex = 22;
            this.animalName.Text = "بقر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(438, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "اسم الحيوان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "العودة";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // feeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(768, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "feeding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "feeding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label feedingTime;
        private System.Windows.Forms.Label animalCount;
        private System.Windows.Forms.Label animalName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox food;
        private System.Windows.Forms.Label lastFood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}