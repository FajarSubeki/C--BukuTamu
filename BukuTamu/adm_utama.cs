using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class adm_utama : Form
    {
        public adm_utama()
        {
            InitializeComponent();
            SidePanel.Height = btDashboard.Height;
            SidePanel.Top = btDashboard.Top;
            dashboard1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btDashboard.Height;
            SidePanel.Top = btDashboard.Top;
            dashboard1.BringToFront();
        }

        private void btUmum_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btUmum.Height;
            SidePanel.Top = btUmum.Top;
            aD_Umum1.BringToFront();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                adm_login lg = new adm_login();
                lg.Show();
                this.Hide();
            }
        }

        private void btOrtu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btOrtu.Height;
            SidePanel.Top = btOrtu.Top;
            ad_ortu1.BringToFront();
        }

        private void btAlumni_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btAlumni.Height;
            SidePanel.Top = btAlumni.Top;
            ad_alumni1.BringToFront();
        }

        private void btPerusahaan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btPerusahaan.Height;
            SidePanel.Top = btPerusahaan.Top;
            ad_perusahaan1.BringToFront();
        }

        private void btKunjungan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btKunjungan.Height;
            SidePanel.Top = btKunjungan.Top;
            ad_kunjungan1.BringToFront();
        }

        private void btUndangan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btUndangan.Height;
            SidePanel.Top = btUndangan.Top;
            ad_undangan1.BringToFront();
        }

    }
}
