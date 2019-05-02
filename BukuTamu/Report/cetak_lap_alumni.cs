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
    public partial class cetak_lap_alumni : Form
    {

        private DataSet ds;
        private MySqlDataAdapter da;

        public cetak_lap_alumni()
        {
            InitializeComponent();
            cetak();
        }

        public void cetak()
        {
            MySqlConnection conn = koneksi.getKoneksi();
            {
                conn.Open();
                da = new MySqlDataAdapter("SELECT * FROM tb_alumni ORDER BY waktu", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_alumni");
                lap_tamu_alumni alumni = new lap_tamu_alumni();
                alumni.SetDataSource(ds);
                CRV.ReportSource = alumni;
                CRV.Refresh();
            }
        }
    }
}
