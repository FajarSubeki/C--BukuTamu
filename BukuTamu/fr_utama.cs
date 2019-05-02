using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class fr_utama : Form
    {
        public fr_utama()
        {
            Thread T = new Thread(new ThreadStart(SplashScreen));
            T.Start();
            Thread.Sleep(1000);
            InitializeComponent();
            T.Abort();
            dashboardTM1.BringToFront();
        }

        public void SplashScreen()
        {
            //Application.Run(new fr_splash());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tPerusahaan1.BringToFront();
            slider.Left = btPerusahaan.Left;
            slider.Width = btPerusahaan.Width;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lJam.Text = DateTime.Now.ToLongTimeString();
            lHari.Text = DateTime.Now.ToLongDateString();

           
        }

        private void fr_utama_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Interval = 500;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                timer1.Start();
                Application.Exit();
            }
        }

        private void dashboardTM1_Load(object sender, EventArgs e)
        {

        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            dashboardTM1.BringToFront();
            slider.Left = btDashboard.Left;
            slider.Width = btDashboard.Width;
        }

        private void btUmum_Click(object sender, EventArgs e)
        {
            tUmum1.BringToFront();
            slider.Left = btUmum.Left;
            slider.Width = btUmum.Width;
        }

        private void tUmum1_Load(object sender, EventArgs e)
        {

        }

        private void btOrtu_Click(object sender, EventArgs e)
        {
            tOrtu1.BringToFront();
            slider.Left = btOrtu.Left;
            slider.Width = btOrtu.Width;
        }

        private void btAlumni_Click(object sender, EventArgs e)
        {
            tAlumni1.BringToFront();
            slider.Left = btAlumni.Left;
            slider.Width = btAlumni.Width;
        }

        private void btKunjungan_Click(object sender, EventArgs e)
        {
            tKunjungan1.BringToFront();
            slider.Left = btKunjungan.Left;
            slider.Width = btKunjungan.Width;
        }

        private void btUndangan_Click(object sender, EventArgs e)
        {
            undangan1.BringToFront();
            slider.Left = btUndangan.Left;
            slider.Width = btUndangan.Width;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            adm_login lg = new adm_login();
            lg.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Generate gg = new Generate();
            gg.Show();
            this.Hide();
        }   
    }
}
