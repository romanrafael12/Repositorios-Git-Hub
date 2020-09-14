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
        #region btnregistro

        private async void registerbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtem.Text))
            {
                MessageBox.Show("Please enter your email and password");
                txtem.Focus();
                return;

            }


            IUserRepository repository = new UserRepository();

            bool result = await repository.Insert(new User() { username = txtem.Text, password = txtpass.Text });

            if (result)
            {
                MessageBox.Show("You have successfully register");
            }
            else
            {
                MessageBox.Show("Error");

            }
            #endregion
        }
        #region close

        private void canlab_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Close();

        } 
        #endregion
    }
}
