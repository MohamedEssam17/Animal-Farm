using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Animal_Farm.screen
{
    public partial class LiveStock_Farm : Form
    {
        SqlConnection conn2 = new SqlConnection(@"server=DESKTOP-NKRK2K3\SQLEXPRESS; database=farm;integrated security =true;");

        public LiveStock_Farm()
        {
            InitializeComponent();
            dgv1.MultiSelect = false;
        }

        private void LiveStock_Farm_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (name.SelectedIndex != -1)
            {
                conn2.Open();
                SqlCommand cmd2 = conn2.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into livestock values(N'" + name.Text + "',N'" + txtKind.Text + "',N'" + txtWeight.Text + "',N'" + txtPrizes.Text + "')";
                cmd2.ExecuteNonQuery();
                conn2.Close();
                name.Text = "";
                name.SelectedIndex = -1;
                txtKind.Text = "";
                txtPrizes.Text = "";
                txtWeight.Text = "";

                disp_data();
                MessageBox.Show("record inserted successfully");
            }
        }
        public void disp_data()
        {
            conn2.Open();
            SqlCommand cmd2 = conn2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from livestock";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(dt2);
            dt2.Columns[0].ColumnName = "Animal Id";
            dgv1.DataSource = dt2;
            conn2.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgv1.SelectedRows[0].Cells[0].Value;

                conn2.Open();
                SqlCommand cmd2 = conn2.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = $"delete from livestock where ID ='{id}'";
                cmd2.ExecuteNonQuery();
                conn2.Close();
                disp_data();
                MessageBox.Show("The sale has been successfully");

            }
            catch
            {
                MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Edit1animal_Click(object sender, EventArgs e)
        {
            if (name.SelectedIndex != -1)
            {
                try
                {
                    var id = dgv1.SelectedRows[0].Cells[0].Value;

                    conn2.Open();
                    SqlCommand cmd2 = conn2.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update livestock set name=N'" + name.Text + "',kind=N'" + txtKind.Text + "',weight=N'" + txtWeight.Text + "',price=N'" + txtPrizes.Text + "' where ID ='" + id + "'";
                    cmd2.ExecuteNonQuery();
                    conn2.Close();
                    disp_data();
                    MessageBox.Show("The Edit has been successfully");

                }
                catch
                {
                    MessageBox.Show("you should select a row for this process", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Lists u = new Lists();
            u.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn2.Open();
            SqlCommand cmd2 = conn2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = $"select * from livestock where name like N'%{txtSearch.Text}%'";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(dt2);
            dgv1.DataSource = dt2;
            conn2.Close();
            // var search = txtSearch.Text;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
