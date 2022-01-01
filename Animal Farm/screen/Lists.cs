using Animal_Farm.screen;
using System;
using System.Windows.Forms;

namespace Animal_Farm
{
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            productions l3 = new productions();
            l3.Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            LiveStock_Farm l1 = new LiveStock_Farm();
            l1.Show();
            this.Hide();


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            new livestockfeeds().Show();

            this.Hide();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_frm2().Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new feeding().Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            new trader().Show();
            this.Hide();
        }

        private void btnn6_Click(object sender, EventArgs e)
        {
            new sell().Show();
          
        }
    }
}
