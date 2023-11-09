using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Navigation : Form
    {
        private string type;

        public Navigation()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            type = "admin";
            Form frm = new Login(type);
            frm.Show();
        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            type = "buyer";
            Form frm = new Login(type);
            frm.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            type = "seller";
            Form frm = new Login(type);
            frm.Show();
        }
    }
}
