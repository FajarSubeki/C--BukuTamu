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
using System.Drawing.Imaging;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace BukuTamu.UserControls
{
    public partial class tPerusahaan : UserControl
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Pen pe = new Pen(Color.White, 5);
        public Graphics g;
        public int width;
        Bitmap surface;
        Graphics graph;

        public tPerusahaan()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            p.Width = 4;
            surface = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(surface);
            pictureBox1.BackgroundImage = surface;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;

            btTakePhoto.Visible = false;
            btUlangi.Visible = false;
            btnStop.Visible = false;
            btResetTtd.Visible = false;
        }

        public void reset()
        {
            tbNama.Text = "";
            tbInstansi.Text = "";
            tbHp.Text = "";
            tbEmail.Text = "";
            tbJumlah.Text = "";
            pictureBox1.Image = null;
            pictureBox7.Image = null;
            pictureBox1.Invalidate();
        }


        private void tbHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
               && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress   
                MessageBox.Show("Masukan angka saja !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
               && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress   
                MessageBox.Show("Masukan angka saja !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSelesai_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin ingin mendaftar? Perhatikan kembali data yang telah diinput sudah diisi dengan benar !!!", "Harap isi data dengan benar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (pictureBox1.Image == null && pictureBox7.Image == null)
                {
                    MessageBox.Show("Ambil Foto Dulu !!! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (tbNama.Text != "" && tbInstansi.Text != "" && tbEmail.Text != "" && tbHp.Text != "" && tbJumlah.Text != "")
                    {
                        try
                        {
                            MySqlConnection conn = koneksi.getKoneksi();
                            MySqlCommand command = conn.CreateCommand();

                            MemoryStream ms = new MemoryStream();
                            MemoryStream foto2 = new MemoryStream();

                            pictureBox7.Image.Save(foto2, System.Drawing.Imaging.ImageFormat.Png);
                            surface.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                            byte[] ttd = ms.ToArray();
                            byte[] foto = foto2.ToArray();

                            command.CommandText = "INSERT INTO tb_perusahaan(nama_perusahaan, instansi, email, no_hp, ttd, jumlah_tamu, foto) VALUE (@nama, @instansi, @email, @no_hp, @ttd, @jumlah, @foto)";
                            conn.Open();

                            command.Parameters.Add("@nama", MySqlDbType.VarChar, 100);
                            command.Parameters.Add("@instansi", MySqlDbType.VarChar, 100);
                            command.Parameters.Add("@email", MySqlDbType.VarChar, 50);
                            command.Parameters.Add("@no_hp", MySqlDbType.VarChar, 12);
                            command.Parameters.Add("@ttd", MySqlDbType.LongBlob);
                            command.Parameters.Add("@jumlah", MySqlDbType.Int16, 4);
                            command.Parameters.Add("@foto", MySqlDbType.LongBlob);

                            command.Parameters["@nama"].Value = tbNama.Text;
                            command.Parameters["@instansi"].Value = tbInstansi.Text;
                            command.Parameters["@email"].Value = tbEmail.Text;
                            command.Parameters["@no_hp"].Value = tbHp.Text;
                            command.Parameters["@ttd"].Value = ttd;
                            command.Parameters["@jumlah"].Value = tbJumlah.Text;
                            command.Parameters["@foto"].Value = foto;

                            MySqlDataReader reader = command.ExecuteReader();
                            MessageBox.Show("Berhasil Mengisi Form Tamu Perusahaan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            reset();

                            graph.Clear(Color.White);
                            pictureBox5.Invalidate();

                            btTakePhoto.Visible = false;
                            btUlangi.Visible = false;
                            btnStop.Visible = false;
                            btResetTtd.Visible = false;

                            conn.Close();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Terjadi Kesalahan Query");
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(tbNama.Text) && string.IsNullOrWhiteSpace(tbInstansi.Text) && string.IsNullOrWhiteSpace(tbEmail.Text) && string.IsNullOrWhiteSpace(tbHp.Text) && string.IsNullOrWhiteSpace(tbJumlah.Text))
                    {
                        MessageBox.Show("Harap Lengkapi Data !!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            reset();   
        }

        private void tPerusahaan_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox7.Image = (Image)eventArgs.Frame.Clone();
        }

        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image == null)
            {
                MessageBox.Show("Ambil Foto Dulu !!! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox7.Image = (Bitmap)pictureBox7.Image.Clone();
                FinalFrame.Stop();
                btUlangi.Visible = true;
                btnStop.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btTakePhoto.Visible = true;
        }

        private void btUlangi_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = null;
            pictureBox7.Invalidate();
            FinalFrame.Start();
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                graph.DrawLine(p, old, current);
                old = current;
                pictureBox1.Invalidate();

                btResetTtd.Visible = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                current = e.Location;
                graph.DrawLine(pe, old, current);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Red);
            p.Width = 5.0f;
            gr.DrawLine(p, old, current);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
            pictureBox7.Image = null;

        }

        private void btResetTtd_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            pictureBox1.Invalidate();
        }
    }
}
