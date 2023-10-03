using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Asm2DB
{
    public partial class studentlogin : Form
    {
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void studentlogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=TRUNGQUỲN\\SQLEXPRESS;database=BTECLibrary; User ID=sa;Password=123456");
            
        }
        public studentlogin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void lbforgotpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotpass1 forgotpass1 = new forgotpass1();
            forgotpass1.Show();
        }

        private void lbregister_Click(object sender, EventArgs e)
        {
            register1 register1 = new register1();
            register1.Show();
        }

        public void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtaccount1.Text) || string.IsNullOrWhiteSpace(txtpassword1.Text))
            {
                MessageBox.Show("Username or password is empty!");
            }
            else
            {
                cmdd = new SqlCommand();
                conn.Open();
                cmdd.Connection = conn;
                cmdd.CommandText = "select * from UserPass where UserName='" + txtaccount1.Text + "'AND UserPass='" + txtpassword1.Text + "'";

                rdr = cmdd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Login succesful!");
                    this.Hide();
                    usinterf usinterf = new usinterf(txtaccount1.Text);
                    usinterf.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Account or Password");
                }
                conn.Close();
            }
                
        }

        private void txtaccount1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
