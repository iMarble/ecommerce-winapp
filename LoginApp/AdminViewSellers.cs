using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class AdminViewSellers : Form
    {
        public AdminViewSellers()
        {
            InitializeComponent();
        }

        private void AdminViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginAppDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.loginAppDataSet2.Users);

        }
    }
}
