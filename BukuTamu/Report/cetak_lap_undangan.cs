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
    public partial class cetak_lap_undangan : Form
    {

        private DataSet ds;
        private MySqlDataAdapter da;

        public cetak_lap_undangan()
        {
            InitializeComponent();
            cetak();
        }

        public void cetak()
        {
            MySqlConnection conn = koneksi.getKoneksi();
            {
                conn.Open();
                da = new MySqlDataAdapter("SELECT * FROM tb_undangan", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_undangan");
                lap_tamu_undangan undangan = new lap_tamu_undangan();
                undangan.SetDataSource(ds);
                CRV.ReportSource = undangan;
                CRV.Refresh();
            }
        }
    }
}
