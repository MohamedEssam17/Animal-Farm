using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Animal_Farm.screen
{
    public partial class livestockfeeds : Form

    {
        SqlConnection conn3 = new SqlConnection(@"server=DESKTOP-NKRK2K3\SQLEXPRESS; database=farm;integrated security =true;");
        public livestockfeeds()
        {
            InitializeComponent();
            dgv2.MultiSelect = false;
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            Lists a = new Lists();
            a.Show();
            this.Hide();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (name.SelectedIndex != -1)
            {
                conn3.Open();
                SqlCommand cmd3 = conn3.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into livestockfeeds values(N'" + name.Text + "',N'مصدر نباتي',N'" + txtQuantity.Text + "',N'" + date.Value.ToString("dd/M/yyyy") + "')";
                cmd3.ExecuteNonQuery();
                conn3.Close();
                name.SelectedIndex = -1;

                txtQuantity.Text = "";
                date.Value = DateTime.Now;

                disp_data();
                MessageBox.Show("record inserted successfully");
            }
        }
        public void disp_data()
        {
            conn3.Open();
            SqlCommand cmd3 = conn3.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from livestockfeeds";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            adapter3.Fill(dt3);
            dgv2.DataSource = dt3;
            conn3.Close();
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgv2.SelectedRows[0].Cells[0].Value;

                conn3.Open();
                SqlCommand cmd3 = conn3.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = $"delete from livestockfeeds where ID ='{id}'";
                cmd3.ExecuteNonQuery();
                conn3.Close();
                disp_data();
                MessageBox.Show("delete has been successfully");

            }
            catch
            {
                MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit1_Click(object sender, EventArgs e)
        {
            if (name.SelectedIndex != -1)
            {
                try
                {
                    var id = dgv2.SelectedRows[0].Cells[0].Value;

                    conn3.Open();
                    SqlCommand cmd3 = conn3.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "update livestockfeeds set name=N'" + name.Text + "',Type=N'مصدر نباتي',Quantity=N'" + txtQuantity.Text + "',Date=N'" + date.Value.ToString("dd/M/yyyy") + "' where ID ='" + id + "'";
                    cmd3.ExecuteNonQuery();
                    conn3.Close();
                    disp_data();
                    MessageBox.Show("The Edit has been successfully");

                }
                catch
                {
                    MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            conn3.Open();
            SqlCommand cmd3 = conn3.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = $"select * from livestockfeeds where name like N'%{txtSearch1.Text}%'";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            adapter3.Fill(dt3);
            dgv2.DataSource = dt3;
            conn3.Close();
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void livestockfeeds_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
