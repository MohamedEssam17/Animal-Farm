using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animal_Farm.screen
{
    public partial class sell : Form
    {
        Timer timer = new Timer();
        public sell()
        {
            InitializeComponent();
            
            tradernames.Items.AddRange(getTraderNames().ToArray());
            itemtosell.Items.AddRange(getProudctsNames().ToArray());
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            disp_data();

        }
        public void disp_data()
        {
            var con = model.DB.openConnection();
            SqlCommand cmd5 = con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from fatora";
            cmd5.ExecuteNonQuery();
            DataTable dt5 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd5);
            adapter3.Fill(dt5);
            dgv5.DataSource = dt5;
            con.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
        }

        List<string> getProudctsNames() {
            var li = new List<string>();
            var con = model.DB.openConnection();
            var q1 = "select distinct name from livestock";
            var q2 = "select distinct Type from productions";
            using (var cmd1 = new SqlCommand(q1, con)) {
                var r1 = cmd1.ExecuteReader();
                while (r1.Read())
                {
                    li.Add((string)r1["name"]);
                }
                r1.Close();
                cmd1.Dispose();

            }
            using (var cmd2 = new SqlCommand(q2, con))
            {
                var r2 = cmd2.ExecuteReader();
                while (r2.Read())
                {
                    li.Add((string)r2["Type"]);
                }
                cmd2.Dispose();
                r2.Close();

            }
            con.Close();
            return li;
        }
        void calctotal(){

            try
            {
                var p = double.Parse(itemPrice.Text);
                var q = double.Parse(quantity.Text);
                if (p != null && q != null)
                {
                    total.Text = (p * q).ToString();
                }
                else {
                    total.Text = "";
                }
            }
            catch { }

}
        List<string> getTraderNames()
        {
            var li = new List<string>();
            var con = model.DB.openConnection();
            var qu = "select * from traders";
            var cmd = new SqlCommand(qu,con);
            var rader = cmd.ExecuteReader();
            while (rader.Read())
            {
                li.Add((string)rader["name"]);
            }
            con.Close();
            cmd.Dispose();
            return li;
            
        }

        private void sell_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calctotal();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calctotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tradernames.Text != "" &&total.Text!=""&&itemtosell.Text!="") {
                if (double.Parse(total.Text) == double.Parse(paid.Text)) {
                    var con = model.DB.openConnection();
                    var q = $"insert into fatora values(N'{tradernames.Text}',N'{itemtosell.Text}'" +
                        $",N'{dateTimePicker1.Value.ToString("dd/MM/yyyy")}',{double.Parse(quantity.Text)}," +
                        $"{double.Parse(itemPrice.Text)},{double.Parse(total.Text)},{double.Parse(paid.Text)})";
                    var cmd = new SqlCommand(q,con);
                    if (cmd.ExecuteNonQuery()!=0)
                    {
                        MessageBox.Show("نم حفظ الفاتورة بنجاح");
                    }
                    cmd.Cancel();
                    disp_data();
                    con.Close();
                }

                else { MessageBox.Show("برجاء دفع المبلغ بالكامل"); }
            
            }
        }

        private void Homepd_Click(object sender, EventArgs e)
        {
            Lists k = new Lists();
            k.Show();
            this.Hide();
        }

        private void btndelet5_Click(object sender, EventArgs e)
        {

            try
            {
                var id = dgv5.SelectedRows[0].Cells[0].Value;

                var con = model.DB.openConnection();
                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = $"delete from fatora where ID ='{id}'";
                cmd5.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("delete has been successfully");

            }
            catch
            {
                MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
