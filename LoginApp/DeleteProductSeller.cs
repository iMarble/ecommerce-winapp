using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class DeleteProductSeller : Form
    {

        ProductsData ProductsData = new ProductsData();
        private List<Product> products;
        private int productId;

        public DeleteProductSeller(int sellerId)
        {
            InitializeComponent();
            products = ProductsData.getProductBySellerID(sellerId);
        }

        private void DeleteProductSeller_Load(object sender, EventArgs e)
        {

            foreach (var product in products)
            {
                comboBox1.Items.Add(product.name);
            }
        }



        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to sure to remove this product?", "Question:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductsData.deleteData(productId);

                MessageBox.Show("Okay Your product is Removed");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = products.Find(x => x.name == comboBox1.Text);
            productId = product.id;
        }

        private void DeleteProductSeller_Close(object sender, FormClosedEventArgs e)
        {
            ProductsData.clearData();
            //comboBox1.Items.Clear();
        }
    }
}
