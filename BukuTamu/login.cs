using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Media;

namespace BukuTamu
{
    public partial class login : Form
    {

        SoundPlayer player;

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public login()
        {
            player = new SoundPlayer();
            InitializeComponent();
        }

        public void refresh()
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            button1.Enabled = true;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void login_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            refresh();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();
                string type = result.BarcodeFormat.ToString();
                textBox1.Text = decoded;

                if (decoded == "230232jvm212oockknAv")
                {
                    timer1.Stop();
                    button1.Enabled = true;
                    MessageBox.Show("Berhasil Login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adm_utama ut = new adm_utama();
                    ut.Show();
                    this.Hide();
                    textBox1.Text = decoded;
                }
               
            }
            catch(Exception a)
            {
                
            }
        }

        private void comboBox1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            adm_login lg = new adm_login();
            lg.Show();
            this.Hide();
            FinalFrame.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            textBox1.Text = "";
        }


    }
}
