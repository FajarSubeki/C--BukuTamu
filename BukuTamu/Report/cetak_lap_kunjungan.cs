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
using CrystalDecisions.CrystalReports.Engine;

namespace BukuTamu.Report
{
    public partial class cetak_lap_kunjungan : Form
    {

        private DataSet ds;
        private MySqlDataAdapter da;

        public cetak_lap_kunjungan()
        {
            InitializeComponent();
            cetak();
        }

        public void cetak()
        {
            MySqlConnection conn = koneksi.getKoneksi();
            {
                conn.Open();
                da = new MySqlDataAdapter("SELECT * FROM tb_kunjungan ORDER BY waktu", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_kunjungan");
                lap_tamu_kunjungan kunjungan = new lap_tamu_kunjungan();
                kunjungan.SetDataSource(ds);
                CRV.ReportSource = kunjungan;
                CRV.Refresh();
            }
        }
    }
}
