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
    public partial class NewPass : Form
    {
        public NewPass()
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
        private void bsave_Click(object sender, EventArgs e)
        {
            string oldpass = toldpass.Text;
            string newpass = tnewpass.Text;

            string hashcode1 = hashstring(oldpass, "SHA512");
            string hashcode2 = hashstring(newpass, "SHA512");
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.conectionstring;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.Parameters.Add(new SqlParameter("@hashcode", hashcode1));
            string sql = "Select username from users where password= @hashcode";

            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();

            conn.Close();
            conn.Open();
            sql = "update users set password = REPLACE" + "(password, '" + hashcode1 + "', '" + hashcode2 + "');";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = sql;
            cmd2.ExecuteNonQuery();
            toldpass.Text = "";
            tpasshash.Text = "Doi mat khau thanh cong";

        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

