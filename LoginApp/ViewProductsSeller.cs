using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class ViewProductsSeller : Form
    {
        ProductsData ProductsData = new ProductsData();
        private List<Product> products = new List<Product>();

        public ViewProductsSeller(int sellerId)
        {
            InitializeComponent();
            products = ProductsData.getProductBySellerID(sellerId);
        }

        private void ViewProductsSeller_Load(object sender, EventArgs e)
        {
            //products.Clear();
            foreach (var product in products)
            {
                comboBoxProductList.Items.Add(product.name);
            }
            /*comboBoxProductList.Items.Add("Bag");
            comboBoxProductList.Items.Add("Mobile Cover");
            comboBoxProductList.Items.Add("Shoes");*/
        }

        private void ViewProductsSeller_Close(object sender, EventArgs e)
        {
            MessageBox.Show("closed");
            comboBoxProductList.Items.Clear();
            products.Clear();
            ProductsData.clearData();
        }

        private void bTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = products.Find(x => x.name == comboBoxProductList.SelectedItem.ToString());
            textBoxName.Text = product.name;
            textBoxPrice.Text = product.price.ToString();
            textBoxQuantity.Text = product.stock.ToString();
        }
    }
}
