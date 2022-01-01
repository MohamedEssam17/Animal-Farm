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
    public partial class trader : Form
    {
        public trader()
        {
            InitializeComponent();
            refresh();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (name.Text!=""&&adress.Text!=""&&phone.Text!="") {
                var con = model.DB.openConnection();
                var qu = $"insert into traders values(N'{name.Text}',N'{adress.Text}',N'{phone.Text}')";
                var cmd = new SqlCommand(qu,con);
                if (cmd.ExecuteNonQuery()!=0) {
                    MessageBox.Show("تم الحفظ");
 
}
                con.Close();
                cmd.Dispose();
                name.Text = "";
                adress.Text = "";
                phone.Text = "";
                refresh();
                tabPage2.BringToFront();
                tabPage2.Show();
                tabPage2.Focus();

            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Lists().Show(); 
        }

        void refresh()
        {

            var con = model.DB.openConnection();
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from traders";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            adapter3.Fill(dt3);
            dgv2.DataSource = dt3;
            var q = $"select count(name) from traders";
            var cmd = new SqlCommand(q, con);
            tradersCount.Text = ((int)cmd.ExecuteScalar()).ToString();
            con.Close();
            cmd.Cancel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Lists().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgv2.SelectedRows[0].Cells[0].Value;

                var con = model.DB.openConnection();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from traders where id ='{id}'";
               if( cmd.ExecuteNonQuery()!=0) MessageBox.Show("delete has been successfully");
                con.Close();
                refresh();
               

            }
            catch
            {
                MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
