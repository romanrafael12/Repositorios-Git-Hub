using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }

       



        #region Log in Button
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\RAC\Documents\Visual Studio 2019\LoginDB\LoginDB.mdf");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From tblLogin where username = '" + emlog.Text.Trim() + "' and password = '" + passlog.Text.Trim() + " ' ", con);
            DataTable tblLogin = new DataTable();
            sqa.Fill(tblLogin);

            if (tblLogin.Rows[0][0].ToString() == "1") //Al validar usuario, pasa al dashboard
            {

                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
                MessageBox.Show("Login Successful");
            }

            else

            {
                MessageBox.Show("Username/Password is incorrect. Please try again");
            }
        }
        #endregion

        private void emlog_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
             Register forma = new Register();
             forma.Show();           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Register forma = new Register();
            forma.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
