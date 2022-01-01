using System;
using System.Windows.Forms;

namespace Animal_Farm
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            panel_loading.Width += 18;
            if (panel_loading.Width > this.Width)
            {
                timer_loading.Stop();
                Login_frm2 frm2 = new Login_frm2();
                frm2.Show();
                this.Hide();
            }
        }
    }
}
