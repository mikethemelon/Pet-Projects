using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FileSystemWatcher
{
    public partial class Login : Form
    {
        int loginAttempts = 0;
        public Login()
        {
            InitializeComponent();
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

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void blogin_Click(object sender, EventArgs e)
        {
            string hoten = tuser.Text;
            string pass = tpass.Text;
            string hashcode = hashstring(pass, "SHA512");
            string regex = @"^[a-z]$";

            //Regex
            if (System.Text.RegularExpressions.Regex.IsMatch(hoten, regex))
            {
                tpasshash.Text = "Username khong hop le";
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.conectionstring;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //string sql = "Select username from users "+ "where username = '" + hoten + "' and password = '"+ hashcode + "'";

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
                    if (tuser.Text == "admin")
                    {
                        this.Hide();
                        MDIParent1 f = new MDIParent1();
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        MDIParent2 f = new MDIParent2();
                        f.ShowDialog();
                    }
                }
                
                else
                {
                    loginAttempts++;

                    if (loginAttempts >= 5) // Lock login after 5 attempts
                    {
                        MessageBox.Show("Qua nhieu lan dang nhap sai. Chuong trinh se tu dong thoat!");
                        this.Close();
                    }
                    tpasshash.Text = ("Username khong ton tai hay Password sai."+  "\n Ban con: " + (5 - loginAttempts).ToString() + " lan nhap con lai");
                    //tpasshash.Text = "Username khong ton tai hay Password sai";
                }
                conn.Close();
                conn.Dispose();
                conn = null;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
