using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class BuyerCheckout : Form
    {
        private string productName;
        private float productPrice;
        private int productQuantity;
        private float totalPrice;

        OrdersData ordersData = new OrdersData();

        private int BuyerIdDB;

        public BuyerCheckout(string productName, float price, int quantity, int buyerIdDB)
        {
            InitializeComponent();
            this.productName = productName;
            this.productPrice = price;
            this.productQuantity = quantity;
            this.totalPrice = price * quantity;
            BuyerIdDB = buyerIdDB;
        }

        private void BuyerCheckout_Load(object sender, EventArgs e)
        {
            lblName.Text = productName;
            lblPrice.Text = productPrice.ToString();
            lblQuantity.Text = productQuantity.ToString();
            lblAmnt.Text = totalPrice.ToString();

            comboBoxPayment.Items.Add("Credit Card");
            comboBoxPayment.Items.Add("Cash On Delievery");
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int orderId = ordersData.newOrder(BuyerIdDB, productName, txtBoxName.Text, txtBoxAddress.Text, txtBoxPhone.Text, comboBoxPayment.SelectedItem.ToString(), totalPrice, productQuantity, 0);

            MessageBox.Show($"Order Placed!! Order Id: {orderId}");
        }
    }
}
