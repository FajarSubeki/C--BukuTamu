using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BukuTamu
{
    public partial class adm_login : Form
    {
        public adm_login()
        {
            InitializeComponent();
        }

       

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private Boolean Login(String username, String password)
        {
            string host = "localhost";
            string user = "root";
            string pass = "";
            string DB = "db_guestbook";
            string con = "server = " + host + ";database = " + DB + ";username = " + user + ";password = " + pass + ";";

            username = username.ToUpper();
            password = password.ToUpper();

            MySqlConnection koneksi = new MySqlConnection(con);

            koneksi.Open();
            MySqlCommand dbcmd = koneksi.CreateCommand();
            string sql = "SELECT username, password FROM tb_petugas";
            dbcmd.CommandText = sql;
            MySqlDataReader reader = dbcmd.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString().ToUpper() == username) && (reader.GetString(1).ToString().ToUpper() == password))
                {
                    return true;
                }
            }
            koneksi.Close();
            return false;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Masih ada data yang kosong !!!");
            }
            else if (Login(tbUsername.Text, tbPassword.Text) == true)
            {
                MessageBox.Show("Login Berhasil", "Informasi");

                adm_utama tm = new adm_utama();
                tm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Username dan Password SALAH !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Text = "";
                tbPassword.Text = "";
                tbUsername.Focus();
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                fr_utama ut = new fr_utama();
                ut.Show();
                this.Hide();
            }
            
         
        }

        private void l_qr_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

    }
}
