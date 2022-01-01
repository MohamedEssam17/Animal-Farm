using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Animal_Farm.screen
{
    public partial class feeding : Form
    {
        public feeding()
        {
            InitializeComponent();
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (name.SelectedIndex != -1)
            {
                refresh();
                if (animalCount.Text == "0")
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }

        }

        void refresh()
        {


            var animalsnum = 0;
            var feedToday = 0;
            string lastf = "لا شئ";
            var con = model.DB.openConnection();
            var qu = $"select count(name)  from livestock where name=N'{name.Text}'";
            var cmd = new SqlCommand(qu, con);
            animalsnum = (int)cmd.ExecuteScalar();
            cmd.Cancel();
            feedToday = (int)
                (new SqlCommand($"select count(*)  from feeding " +
                $"where feeddate=N'{DateTime.Now.ToString("dd/M/yyyy")}'" +
                $" and animalname=N'{name.Text}'", con)
                .ExecuteScalar());

            using (SqlDataReader reader3 = new SqlCommand($"select top 1 * from feeding where animalname=N'{name.Text}' ORDER BY id desc", con).ExecuteReader())
            {

                if (reader3.Read())
                {
                    lastf = (string)reader3["foodname"];
                    reader3.Close();
                }
            }
            con.Close();
            animalName.Text = name.Text;
            animalCount.Text = animalsnum.ToString();
            lastFood.Text = lastf;
            feedingTime.Text = feedToday.ToString();
            panel2.Visible = true;



        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Lists().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (food.SelectedIndex != -1)
            {
                var con = model.DB.openConnection();
                var qu = $"insert into feeding values(N'{food.Text}',N'{DateTime.Now.ToString("dd/M/yyyy")}',N'{animalName.Text}')";
                var cmd = new SqlCommand(qu, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("تم الاطعام");

                    cmd.Cancel();
                }
                con.Close();
                refresh();
            }
        }
    }
}
