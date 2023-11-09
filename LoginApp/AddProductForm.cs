using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class AddProductForm : Form
    {
        ProductsData productsData = new ProductsData();

        private int userIdDB;

        public AddProductForm(int userId)
        {
            InitializeComponent();
            this.userIdDB = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IsProductNameValid())
            {
                int productId = productsData.newProduct(txtProductName.Text, "description", float.Parse(txtboxPrice.Text), int.Parse(textBoxQuantity.Text), userIdDB);

                MessageBox.Show($"Your product is added with ID {productId} ");
            }

        }
        private bool IsProductNameValid()
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please enter Product Name");
                return false;
            }
            else { return true; }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

