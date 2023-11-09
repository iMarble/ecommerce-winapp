using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class AdminViewOrders : Form
    {
        public AdminViewOrders()
        {
            InitializeComponent();
        }

        private void AdminViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginAppDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.loginAppDataSet1.Orders);
        }
    }
}
