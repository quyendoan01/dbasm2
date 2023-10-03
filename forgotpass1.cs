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
    public partial class forgotpass1 : Form
    {
        public forgotpass1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtuname.Text) ||
                    string.IsNullOrWhiteSpace(txtuphone.Text))
            {
                MessageBox.Show("Username or UserPhone is empty!");
            }
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Users where UserName='" + txtuname.Text + "'AND UserPhone='" + txtuphone.Text + "' AND UserEmail = '" + txtuemail.Text + "'";

                    rdr = cmdd.ExecuteReader();
                    if (rdr.Read())
                    {
                        MessageBox.Show("Confirmed!");
                        this.Hide();
                        forgotpass2 forgotpass2 = new forgotpass2(txtuname.Text);
                        forgotpass2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Information does not exist");
                    }
                    conn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void forgotpass1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=TRUNGQUỲN\\SQLEXPRESS;database=BTECLibrary; User ID=sa;Password=123456");
            conn.Open();
        }
    }
}
