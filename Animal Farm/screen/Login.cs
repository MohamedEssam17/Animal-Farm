using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Animal_Farm
{
    public partial class Login_frm2 : Form
    {
        SqlConnection conn1;
        public Login_frm2()
        {
            InitializeComponent();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_frm2_Load(object sender, EventArgs e)
        {
            conn1 = new SqlConnection(@"server=DESKTOP-NKRK2K3\SQLEXPRESS; database=farm;integrated security =true;");


        }



        private void btn_Login_Click(object sender, EventArgs e)
        {


            if (model.DB.isValidUser(txt1.Text, textpassword.Text, conn1))
            {

                MessageBox.Show("تم تسحيل الدخول");
                Lists frm3 = new Lists();
                this.Close();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("هذا المستخحدم غير موجود");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textpassword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '*';
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {


        }


    }
}
