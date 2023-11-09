using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class newUser : Form
    {
        UsersData usersData = new UsersData();

        public newUser()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (usersData.getUserName(txtUsername.Text) != null)
            {
                txtUsername.BorderStyle = BorderStyle.Fixed3D;
                txtUsername.ForeColor = Color.Red;
                lblName.Text = "This Username is already Taken!";
                lblName.Visible = true;
            }
            else
            {
                txtUsername.ForeColor = Color.Green;
                lblName.Visible = false;
            }
        }

        private void newUser_Load(object sender, EventArgs e)
        {
            lblName.Visible = false;
            txtUserpass.UseSystemPasswordChar = true;
        }

        private void clearForm()
        {
            txtUsername.Clear();
            txtUserpass.Clear();
            radioButton1.Checked = true;
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string role = "buyer"; //setting default account to buyer

            if (radioButton1.Checked)
            {
                role = "buyer";
            }

            else if (radioButton2.Checked)
            {
                role = "seller";
            }

            MessageBox.Show($"New account created with userId: {usersData.newAccount(txtUsername.Text, txtUserpass.Text, role)}");

            this.clearForm();
        }
    }
}
