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
    public partial class cetak_lap_tamu_umum : Form
    {

        private DataSet ds;
        private MySqlDataAdapter da;

        public cetak_lap_tamu_umum()
        {
            InitializeComponent();
            cetak();
        }

        public void cetak()
        {
            MySqlConnection conn = koneksi.getKoneksi();
            {
                conn.Open();
                da = new MySqlDataAdapter("SELECT * FROM tb_tamu_umum ORDER BY waktu", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_tamu_umum");
                lap_tamu_umum umum = new lap_tamu_umum();
                umum.SetDataSource(ds);
                CRV.ReportSource = umum;
                CRV.Refresh();
            }
        }

        private void CRV_Load(object sender, EventArgs e)
        {

        }
    }
}
