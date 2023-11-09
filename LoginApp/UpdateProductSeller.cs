using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class UpdateProductSeller : Form
    {
        ProductsData productsData = new ProductsData();
        private List<Product> products;
        private int selectedId;

        public UpdateProductSeller(int sellerId)
        {
            InitializeComponent();
            products = productsData.getProductBySellerID(sellerId);
        }

        private void bTnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void UpdateProductSeller_Load(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                comboBox1.Items.Add(p.name);
            }
        }

        private void UpdateProductSeller_Close(object sender, EventArgs e)
        {
            productsData.clearData();
        }

        private void update(string newName)
        {
            productsData.updateData(selectedId, name: newName);
        }

        private void update(float newPrice)
        {
            productsData.updateData(selectedId, price: newPrice);
        }

        private void update(int newStock)
        {
            productsData.updateData(selectedId, stock: newStock);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = products.Find(x => x.name == comboBox1.Text).id;
        }

        private void bTnUpdate_Click(object sender, EventArgs e)
        {
            string output = "Updated ";

            if (chkBoxName.Checked)
            {
                output += " Name";
                update(textBoxName.Text);
            }
            if (chckBoxPrice.Checked)
            {
                output += " ,Price";
                update(float.Parse(textBoxPrice.Text));
            }

            if (chckBoxStock.Checked)
            {
                output += " ,stock.";
                update(int.Parse(textBoxQuantity.Text));
            }

            MessageBox.Show(output);
        }
    }
}
