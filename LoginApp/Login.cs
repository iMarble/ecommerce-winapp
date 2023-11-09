using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Login : Form
    {
        private string type;
        UsersData usersData = new UsersData();

        public Login(string type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxUserpass.UseSystemPasswordChar = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (usersData.authUser(txtboxUsername.Text, txtboxUserpass.Text))
            {
                //MessageBox.Show("Logged In!");
                object[] data = usersData.getUserType(txtboxUsername.Text, type);
                try
                {
                    switch (usersData.getUserType(txtboxUsername.Text, type)[3])
                    {
                        case "buyer":
                            Form frm = new Buyer(data[1].ToString(), data[0].ToString());
                            frm.Show();
                            break;

                        case "seller":
                            Form frm1 = new Seller(data[1].ToString(), data[0].ToString());
                            frm1.Show();
                            break;

                        case "admin":
                            Form frm2 = new Admin();
                            frm2.Show();
                            break;
                    }

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show($"No way you are not {type}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect User Pass!");
            }

            //MessageBox.Show($"{usersData.getUserType(txtboxUsername.Text)}");
        }

        private void btnSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignUp_Click(sender, e);
            }
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            Form frm = new newUser();
            frm.Show();

        }
    }
}
