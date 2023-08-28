using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text.RegularExpressions; //Regex extension

namespace FileSystemWatcher
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private string hashstring(string pass, string algo)
        {
            string hashcode = "";
            byte[] x_message_data = Encoding.Default.GetBytes(pass);
            HashAlgorithm x_hash_alg = HashAlgorithm.Create("SHA512");
            byte[] x_hash_code = x_hash_alg.ComputeHash(x_message_data);
            hashcode = BitConverter.ToString(x_hash_code);
            return hashcode;
        }

        private void bgen_Click(object sender, EventArgs e)
        {
            string mess = tpass.Text;
            tpasshash.Text = hashstring(mess, "SHA512");
        }

        private void cshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cshow.Checked)
            {
                tpass.PasswordChar = '\0';
            }
            else
            {
                tpass.PasswordChar = '*';
            }
            tpass.Refresh();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            string hoten = tuser.Text;
            string pass = tpass.Text;
            string email = temail.Text;
            string regex = @"^[a-z]$";
            if (System.Text.RegularExpressions.Regex.IsMatch(hoten, regex))
            {
                tpasshash.Text = "username khong hop le";

            }
            else
            {

                string hashcode = hashstring(pass, "SHA512");

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.conectionstring;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //string sql = "Select username from users where username = '" + hoten + "'"; //Thay the "user bang ten table

                //regex
                //string sql = "Select username from users where username = '" + hoten +"'AND pass='" +hashcode + "'";
                cmd.Parameters.Add(new SqlParameter("@hoten", tuser.Text));
                cmd.Parameters.Add(new SqlParameter("@hashcode", hashcode));
                string sql = "Select username from users where username= @hoten AND password= @hashcode";

                //
                cmd.CommandText = sql;
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    tpasshash.Text = "username da dang ky. Xin nhap user khac";
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    sql = "insert into users (username, password, email) values " + "(N'" + hoten + "','" + hashcode + "','" + email + "')";
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = sql;
                    cmd2.ExecuteNonQuery();
                    tuser.Text = "";
                    tpass.Text = "";
                    temail.Text = "";
                    tpasshash.Text = "Username dang ky thanh cong";
                }
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
