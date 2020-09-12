using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Dashboard forma = new Dashboard();
            // forma.Show();
            if (string.IsNullOrEmpty(passlog.Text))
            {
                MessageBox.Show("Please enter your email");
                emlog.Focus();
                return;

            }


           

            IuserRepository repository = new UserRepository();
            bool result = await repository.Insert(new user() { username = emlog.Text, passoword = passlog.Text });
            if (result)
                MessageBox.Show("You have successfully register");
            else
                MessageBox.Show("Error!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}
