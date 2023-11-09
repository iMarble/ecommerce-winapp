using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Buyer : Form
    {
        private string BuyerNameDB;
        private string BuyerIDDB;

        ProductsData ProductsData = new ProductsData();
        private List<Product> products = new List<Product>();

        public Buyer(string BuyerName, string BuyerID)
        {
            InitializeComponent();
            products = ProductsData.getAllProducts();

            this.BuyerNameDB = BuyerName;
            this.BuyerIDDB = BuyerID;
        }

        private void Buyer_Load(object sender, EventArgs e)
        {
            foreach (var product in products)
            {
                comboBoxItems.Items.Add(product.name);
                lblWelcome.Text = $"Welcome! {BuyerNameDB}";
            }
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = products.Find(x => x.name == comboBoxItems.SelectedItem.ToString());
            txtBoxPrice.Text = product.price.ToString();
            txtProductStock.Text = product.stock.ToString();
            numSelectAmount.Maximum = product.stock;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the system");
            if (iExit == DialogResult.OK)
            {
                Application.Exit();
            }
        }



        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Form checkout = new BuyerCheckout(comboBoxItems.SelectedItem.ToString(), float.Parse(txtBoxPrice.Text), int.Parse(numSelectAmount.Value.ToString()), int.Parse(BuyerIDDB));
            checkout.Show();
        }
    }
}
