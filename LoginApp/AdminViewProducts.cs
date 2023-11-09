using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class AdminViewProducts : Form
    {
        public AdminViewProducts()
        {
            InitializeComponent();
        }

        private void AdminViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginAppDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.loginAppDataSet.Products);

        }

    }
}
