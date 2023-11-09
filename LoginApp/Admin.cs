using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnViewProdcuts_Click(object sender, EventArgs e)
        {
            Form frm = new AdminViewProducts();
            frm.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            Form frm = new AdminViewOrders();
            frm.Show();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            Form frm = new AdminViewSellers();
            frm.Show();
        }
    }
}
