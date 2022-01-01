using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Animal_Farm.screen
{
    public partial class productions : Form
    {
        SqlConnection conn4 = new SqlConnection(@"server=DESKTOP-NKRK2K3\SQLEXPRESS; database=farm;integrated security =true;");
        public productions()
        {
            InitializeComponent();
            dgv3.MultiSelect = false;
        }

        private void productions_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (type.SelectedIndex != -1)
            {
                conn4.Open();
                SqlCommand cmd4 = conn4.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "insert into productions values(N'" + type.Text + "',N'" + txtQuantity2.Text + "',N'" + date.Value.ToString("dd/M/yyyy") + "',N'" + txtPrizes2.Text + "')";
                cmd4.ExecuteNonQuery();
                conn4.Close();
                type.SelectedIndex = -1;
                txtQuantity2.Text = "";
                date.Value = DateTime.Now;
                txtPrizes2.Text = "";

                disp_data();
                MessageBox.Show("record inserted successfully");
            }
        }
        public void disp_data()
        {
            conn4.Open();
            SqlCommand cmd4 = conn4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select * from productions";
            cmd4.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(cmd4);
            adapter4.Fill(dt4);
            dgv3.DataSource = dt4;
            conn4.Close();
        }

        private void btnBuy2_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgv3.SelectedRows[0].Cells[0].Value;

                conn4.Open();
                SqlCommand cmd4 = conn4.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = $"delete from productions where ID ='{id}'";
                cmd4.ExecuteNonQuery();
                conn4.Close();
                disp_data();
                MessageBox.Show("The sale has been successfully");

            }
            catch
            {
                MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            if (type.SelectedIndex != -1)
            {
                try
                {
                    var id = dgv3.SelectedRows[0].Cells[0].Value;

                    conn4.Open();
                    SqlCommand cmd4 = conn4.CreateCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "update productions set Type=N'" + type.Text + "',Quantity=N'" + txtQuantity2.Text + "',Time=N'" + date.Value + "',price=N'" + txtPrizes2.Text + "' where ID ='" + id + "'";
                    cmd4.ExecuteNonQuery();
                    conn4.Close();
                    disp_data();
                    MessageBox.Show("The Edit has been successfully");

                }
                catch
                {
                    MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            Lists p = new Lists();
            p.Show();
            this.Hide();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            conn4.Open();
            SqlCommand cmd4 = conn4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = $"select * from productions where Type like N'%{txtSearch2.Text}%'";
            cmd4.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(cmd4);
            adapter4.Fill(dt4);
            dgv3.DataSource = dt4;
            conn4.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
