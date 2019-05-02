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
    public partial class tUmum : UserControl
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
        string s = "tamugbr";
        int i = 1;

        public tUmum()
        {
            InitializeComponent();

            g = pictureBox5.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            p.Width = 4;
            surface = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            graph = Graphics.FromImage(surface);
            pictureBox5.BackgroundImage = surface;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;

            btTakePhoto.Visible = false;
            btUlangi.Visible = false;
            btnStop.Visible = false;
            btResetTtd.Visible = false;
        }
        
        private void tUmum_Load(object sender, EventArgs e)
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
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        public byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            surface.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


        private void btSelesai_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Yakin ingin mendaftar? Perhatikan kembali data yang telah diinput sudah diisi dengan benar !!!", "Harap isi data dengan benar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Ambil Foto Dulu !!! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbNama.Text != "" && tbKeperluan.Text != "" && tbHp.Text != "")
                {
                    try
                    {

                        MySqlConnection conn = koneksi.getKoneksi();
                        MySqlCommand command = conn.CreateCommand();

                        MemoryStream ms = new MemoryStream();
                        MemoryStream foto2 = new MemoryStream();
                        pictureBox1.Image.Save(foto2, System.Drawing.Imaging.ImageFormat.Png);

                        surface.Save(ms, System.Drawing.Imaging.ImageFormat.Png);


                        byte[] ttd = ms.ToArray();
                        byte[] foto = foto2.ToArray();

                        command.CommandText = "INSERT INTO tb_tamu_umum(nama_tamu_umum, keperluan, ttd, no_hp, foto) VALUE (@nama, @keperluan, @ttd, @nohp, @foto)";
                        conn.Open();

                        command.Parameters.Add("@nama", MySqlDbType.VarChar, 100);
                        command.Parameters.Add("@keperluan", MySqlDbType.Text);
                        command.Parameters.Add("@ttd", MySqlDbType.Blob);
                        command.Parameters.Add("@nohp", MySqlDbType.VarChar, 12);
                        command.Parameters.Add("@foto", MySqlDbType.LongBlob);

                        command.Parameters["@nama"].Value = tbNama.Text;
                        command.Parameters["@keperluan"].Value = tbKeperluan.Text;
                        command.Parameters["@ttd"].Value = ttd;
                        command.Parameters["@nohp"].Value = tbHp.Text;
                        command.Parameters["@foto"].Value = foto;

                        MySqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Berhasil Mengisi Form Tamu Umum", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbNama.Text = "";
                        tbKeperluan.Text = "";
                        tbHp.Text = "";
                        pictureBox1.Image = null;

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
                else if (string.IsNullOrWhiteSpace(tbNama.Text) && string.IsNullOrWhiteSpace(tbKeperluan.Text) && string.IsNullOrWhiteSpace(tbHp.Text))
                {
                    MessageBox.Show("Harap Lengkapi Data !!! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNama.Focus();
                }
            }
           
        }

       

        private void tbHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
            && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress   
                MessageBox.Show("Masukan Digit Angka !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            tbNama.Text = "";
            tbKeperluan.Text = "";
            tbHp.Text = "";
            pictureBox1.Image = null;
            FinalFrame.Stop();

            
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        private void tbHp_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Ambil Foto Dulu !!! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox1.Image = (Bitmap)pictureBox1.Image.Clone();
                FinalFrame.Stop();
                btUlangi.Visible = true;  
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btTakePhoto.Visible = true;
            btnStop.Visible = true;
            
        }

        private void btUlangi_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            FinalFrame.Start();
        }

        private void btColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void pictureBox5_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                graph.DrawLine(p, old, current);
                old = current;
                pictureBox5.Invalidate();
                btResetTtd.Visible = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                current = e.Location;
                graph.DrawLine(pe, old, current);
                pictureBox5.Invalidate();
            }
        }

        private void pictureBox5_MouseDown_1(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void btSaveSign_Click_1(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"E:\Kodingan\C#\BukuTamu\BukuTamu\bin\Debug\images");
            string path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
            surface.Save(path + "\\img\\" + s + ".png");
            s = "tamugbr" + i;
            i++;
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Red);
            p.Width = 5.0f;
            gr.DrawLine(p, old, current);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
            pictureBox1.Image = null;
        }

        private void tUmum_DockChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btResetTtd_Click_1(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            pictureBox5.Invalidate();
        }

    }
}
