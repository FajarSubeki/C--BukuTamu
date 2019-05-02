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
    public partial class cetak_lap_tamu_ortu : Form
    {

        private DataSet ds;
        private MySqlDataAdapter da;

        public cetak_lap_tamu_ortu()
        {
            InitializeComponent();
            cetak();
        }

        public void cetak()
        {
            MySqlConnection conn = koneksi.getKoneksi();
            {
                conn.Open();
                da = new MySqlDataAdapter("SELECT * FROM tb_ortu ORDER BY waktu", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_ortu");
                lap_tamu_ortu ortu = new lap_tamu_ortu();
                ortu.SetDataSource(ds);
                CRV.ReportSource = ortu;
                CRV.Refresh();
            }
        }
    }
}
