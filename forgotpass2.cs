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
    public partial class forgotpass2 : Form
    {
        public forgotpass2()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uname;
        public forgotpass2(string uname1) : this ()
        {
            uname = uname1;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
            forgotpass1 forgotpass1 = new forgotpass1();
            forgotpass1.Show();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnewpass.Text) ||
                string.IsNullOrWhiteSpace(txtconfpass.Text))
            {
                MessageBox.Show("Please enter information!");
            }
            else if (txtnewpass.Text != txtconfpass.Text)
            {
                MessageBox.Show("Wrong confirm Password");
            }
            else if (MessageBox.Show("Do you want to change the Password", "ChangePassword",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from UserPass where UserName= '" + uname + "'";

                    rdr = cmdd.ExecuteReader();

                    if (rdr.Read())
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Update UserPass set UserPass = @upass where UserName=@uname";

                        cmd.Parameters.Add("@uname", SqlDbType.NChar, 20).Value = uname;
                        cmd.Parameters.Add("@upass", SqlDbType.NChar, 20).Value = txtnewpass.Text;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successful!", "Update");
                        studentlogin studentlogin = new studentlogin();
                        studentlogin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }


                conn.Close();
                conn.Open();
            }
        }

        private void txtverif_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtconfpass_TextChanged(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconfpass.Text)
            {
                lbcheckpass.Text = "Correct!";
                lbcheckpass.ForeColor = Color.Green;
            }
            else
            {
                lbcheckpass.Text = "Wrong!";
                lbcheckpass.ForeColor = Color.Red;
            }
        }

        private void forgotpass2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=TRUNGQUỲN\\SQLEXPRESS;database=BTECLibrary; User ID=sa;Password=123456");
            conn.Open();
        }

        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconfpass.Text)
            {
                lbcheckpass.Text = "Correct!";
                lbcheckpass.ForeColor = Color.Green;
            }
            else
            {
                lbcheckpass.Text = "Wrong!";
                lbcheckpass.ForeColor = Color.Red;
            }
        }
    }
}
