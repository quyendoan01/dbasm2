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
    public partial class userinfor : Form
    {
        public userinfor()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uname;
        public userinfor(string uname1) : this()
        {
            uname = uname1;
            lbuname.Text = uname;
        }

        private void brtagtodgv()
        {
            string sql = "select USTGBK.TagID, Tag.BorrowedDate, Tag.ReturnDate, Book.BookName " +
                "from USTGBK, Book, Tag, (select distinct USTGBK.TagID from USTGBK where USTGBK.UserID = 'US00001') as a " +
                "where Tag.TagID = a.TagID " +
                "and Book.BookID = USTGBK.BookID " +
                "and USTGBK.TagID = Tag.TagID";
            SqlCommand cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvtaginfor.DataSource = dt;
        }

        private void userinfor_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=TRUNGQUỲN\\SQLEXPRESS;database=BTECLibrary; User ID=sa;Password=123456");
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from Users where UserName = '" + lbuname.Text + "'", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            lbuid.Text = myTable.Rows[0]["UserID"].ToString();
            lbuphone.Text = myTable.Rows[0]["UserPhone"].ToString();
            lbuemail.Text = myTable.Rows[0]["UserEmail"].ToString();

            brtagtodgv();
        }

        private void lbchangeemail_Click(object sender, EventArgs e)
        {
            lbnewemail.Show();
            txtnewemail.Show();
            btnokemail.Show();
            btncalemail.Show();
        }

        private void lbchangephone_Click(object sender, EventArgs e)
        {
            lbnewphone.Show();
            txtnewphone.Show();
            btnokphone.Show();
            btncalphone.Show();
        }

        private void lbchangepass_Click(object sender, EventArgs e)
        {
            lboldpass.Show();
            lbnewpass.Show();
            lbcnewpass.Show();
            txtoldpass.Show();
            txtnewpass.Show();
            txtcnewpass.Show();
            btnoknewpass.Show();
            btncalnewpass.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
        }

        private void btnokemail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the Email?", "ChangeEmail",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbuemail.Text = txtnewemail.Text;

                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update Users set UserEmail = @useremail where UserID=@userid";
                    
                    cmd.Parameters.Add("@userid", SqlDbType.NChar, 7).Value = lbuid.Text;
                    cmd.Parameters.Add("@useremail", SqlDbType.NChar, 20).Value = lbuemail.Text;
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful!", "Update");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            lbnewemail.Hide();
            txtnewemail.Hide();
            btnokemail.Hide();
            btncalemail.Hide();
        }

        private void btncalemail_Click(object sender, EventArgs e)
        {
            lbnewemail.Hide();
            txtnewemail.Hide();
            btnokemail.Hide();
            btncalemail.Hide();
        }

        private void btnokphone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the Phone?", "ChangePhone",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbuphone.Text = txtnewphone.Text;

                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update Users set UserPhone = @userphone where UserID=@userid";

                    cmd.Parameters.Add("@userid", SqlDbType.NChar, 7).Value = lbuid.Text;
                    cmd.Parameters.Add("@userphone", SqlDbType.NChar, 20).Value = lbuphone.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful!", "Update");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            lbnewphone.Hide();
            txtnewphone.Hide();
            btnokphone.Hide();
            btncalphone.Hide();
        }

        private void btncalphone_Click(object sender, EventArgs e)
        {
            lbnewphone.Hide();
            txtnewphone.Hide();
            btnokphone.Hide();
            btncalphone.Hide();
        }

        private void btnoknewpass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtoldpass.Text) || string.IsNullOrWhiteSpace(txtnewpass.Text) || string.IsNullOrWhiteSpace(txtcnewpass.Text))
            {
                MessageBox.Show("Please enter information!");
            }
            else if (txtnewpass.Text != txtcnewpass.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else if (MessageBox.Show("Do you want to change the Password?", "ChangePassword",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmdd = new SqlCommand();
                cmdd.Connection = conn;
                cmdd.CommandText = "select * from UserPass where UserName= '"+lbuname.Text +"'and UserPass='" + txtoldpass.Text + "'";

                rdr = cmdd.ExecuteReader();

                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update UserPass set UserPass = @userpass where UserName=@username";

                    cmd.Parameters.Add("@username", SqlDbType.NChar, 20).Value = lbuname.Text;
                    cmd.Parameters.Add("@userpass", SqlDbType.NChar, 20).Value = txtnewpass.Text;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful!", "Update");
                }
                else
                {
                    MessageBox.Show("Wrong Old Password");
                }
                conn.Close();
                conn.Open();
            }
            else
            {

            lboldpass.Hide();
            lbnewpass.Hide();
            lbcnewpass.Hide();
            txtoldpass.Hide();
            txtnewpass.Hide();
            txtcnewpass.Hide();
            btnoknewpass.Hide();
            btncalnewpass.Hide();
            }
        }

        private void btncalnewpass_Click(object sender, EventArgs e)
        {
            lboldpass.Hide();
            lbnewpass.Hide();
            lbcnewpass.Hide();
            txtoldpass.Hide();
            txtnewpass.Hide();
            txtcnewpass.Hide();
            btnoknewpass.Hide();
            btncalnewpass.Hide();
        }
    }
}
