using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Seller : Form
    {
        private string sellerNameDB;
        private string sellerIdDB;

        public Seller(string sellerName, string sellerId)
        {
            InitializeComponent();
            this.sellerNameDB = sellerName;
            this.sellerIdDB = sellerId;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            SellerName.Text = $"Logged In as: {sellerNameDB}";
            SellerId.Text = $"SellerID: {sellerIdDB}";
            SellerName.Visible = true;
            SellerId.Visible = true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new AddProductForm(int.Parse(sellerIdDB));
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRmvProduct_Click(object sender, EventArgs e)
        {
            Form frm = new DeleteProductSeller(int.Parse(sellerIdDB));
            frm.ShowDialog();
        }

        private void btnupdateProduxt_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateProductSeller(int.Parse(sellerIdDB));
            frm.ShowDialog();
        }

        private void btnviewProduct_Click(object sender, EventArgs e)
        {
            Form frm = new ViewProductsSeller(int.Parse(sellerIdDB));

            frm.ShowDialog();
        }
    }
}
