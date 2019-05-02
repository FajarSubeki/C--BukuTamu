using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace BukuTamu
{
    public partial class AD_Umum : UserControl
    {

        static MySqlConnection conn;
        static MySqlDataAdapter sdaUser;
        static DataSet dsUser;

        public AD_Umum()
        {
            InitializeComponent();
            queryTamu();
            photo();
            button1.Visible = false;
        }



        public void cari()
        {
            queryCari();
        }

        public void queryCari()
        {
            string query = "SELECT id_tamu_umum, nama_tamu_umum, keperluan, ttd, no_hp, waktu, foto FROM tb_tamu_umum WHERE " +
                                      " id_tamu_umum LIKE '%" + tbCari.Text + "%'" +
                                      " OR nama_tamu_umum LIKE '%" + tbCari.Text + "%'" +
                                      " OR keperluan LIKE '%" + tbCari.Text + "%'" +
                                      " OR no_hp LIKE '%" + tbCari.Text + "%'" +
                                      " OR waktu LIKE '%" + tbCari.Text + "%'" +
                                      " ORDER BY waktu DESC";
            tampilTamu(query, "tb_tamu_umum", dataGridView1);
            try
            {
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Information");
            }
        }

        public void queryTamu()
        {
            string query = "SELECT * FROM tb_tamu_umum ORDER BY waktu DESC";
            tampilTamu(query, "tb_tamu_umum", dataGridView1);
        }

        public static DataSet DataGrid(String query, String table)
        {
            conn = koneksi.getKoneksi();
            sdaUser = new MySqlDataAdapter(query, conn);
            dsUser = new DataSet();

            try
            {
                conn.Open();
                sdaUser.Fill(dsUser, table);
                return dsUser;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void tampilTamu(string query, string table, DataGridView DG)
        {
            try
            {
                dataGridView1.DataSource = DataGrid(query, table);
                

                DG.DataMember = table;
                DG.Columns[0].HeaderText = "ID TAMU";
                DG.Columns[0].Width = 50;
                //DG.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DG.Columns[1].HeaderText = "NAMA TAMU";
                DG.Columns[1].Width = 145;
                DG.Columns[2].HeaderText = "KEPERLUAN";
                DG.Columns[2].Width = 160;
                DG.Columns[3].HeaderText = "TANDA TANGAN";
                DG.Columns[3].Width = 170;
                DG.Columns[4].HeaderText = "NO HP";
                DG.Columns[4].Width = 95;
                DG.Columns[5].HeaderText = "WAKTU";
                DG.Columns[5].Width = 120;
                DG.Columns[6].HeaderText = "FOTO";
                DG.Columns[6].Width = 170;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (l_id.Text == "-")
            {
                MessageBox.Show("Silahkan pilih data untuk dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah Anda yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        MySqlConnection conn = koneksi.getKoneksi();
                        MySqlCommand command = conn.CreateCommand();
                        command.CommandText = "DELETE FROM tb_tamu_umum WHERE id_tamu_umum='" + l_id.Text + "'";
                        MySqlDataReader reader;
                        conn.Open();
                        reader = command.ExecuteReader();
                        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        l_id.Text = "-";
                        queryTamu();

                        conn.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Terjadi Kesalahan Query");
                    }
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button1.Visible = true;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                l_id.Text = row.Cells["id_tamu_umum"].Value.ToString();
                tbNama.Text = row.Cells["nama_tamu_umum"].Value.ToString();
                tbKeperluan.Text = row.Cells["keperluan"].Value.ToString();
                tbHp.Text = row.Cells["no_hp"].Value.ToString();
            }
            catch (Exception a)
            {

            }
        }

        private void tbCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            cari();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            queryTamu();
            l_id.Text = "-";
            reset();
            button1.Visible = false;
        }

        private void tbCari_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            cari();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AD_Umum_Load(object sender, EventArgs e)
        {
            photo();
        }

        public void photo()
        {
            dataGridView1.RowTemplate.Height = 150;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewImageColumn imageColumns = new DataGridViewImageColumn();
            imageColumns.ImageLayout = DataGridViewImageCellLayout.Stretch;
            sdaUser.Dispose();
        }

        private void btCetak_Click(object sender, EventArgs e)
        {
            Report.cetak_lap_tamu_umum umum = new Report.cetak_lap_tamu_umum();
            umum.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Interaction.InputBox("Message", "Title", "Default Value", -1, -1);
            Interaction.InputBox("Message", "Title", "Default Values", -1, -1);
        }

        public void reset()
        {
            tbNama.Text = "";
            tbKeperluan.Text = "";
            tbHp.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (l_id.Text != "" && tbNama.Text != "" && tbHp.Text != "" && tbKeperluan.Text != "")
            {
                try
                {
                    MySqlConnection conn = koneksi.getKoneksi();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "UPDATE tb_tamu_umum SET nama_tamu_umum = '" + tbNama.Text + "', keperluan = '" + tbKeperluan.Text + "', no_hp  = '" + tbHp.Text + "' WHERE id_tamu_umum = '" + l_id.Text + "'";

                    conn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Data Berhasil diubah ", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    queryTamu();
                    while (reader.Read())
                    {

                    }
                    reset();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Terjadi kesalahan Query");
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih data untuk diubah!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
