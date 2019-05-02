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
    public partial class Generate : Form
    {
        public Generate()
        {
            InitializeComponent();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
            {
                MessageBox.Show("Isi QRCode !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
            }
            else
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox.Image = barcode.Draw(txtBarcode.Text, 50);
            }
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            if (txtQRCode.Text == "")
            {
                MessageBox.Show("Isi QRCode !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQRCode.Focus();
            }
            else
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox.Image = qrcode.Draw(txtQRCode.Text, 200);
            }
        }

        private void btSaveQRCode_Click(object sender, EventArgs e)
        {
            if (txtQRCode.Text == "")
            {
                MessageBox.Show("Isi QRCode !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQRCode.Focus();
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "PNG|*.png|JPEG|*.jpeg";
                if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox.Image.Save(s.FileName);
                    MessageBox.Show("Berhasil Menyimpan QRCode", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
            {
                MessageBox.Show("Isi Barcode !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "PNG|*.png|JPEG|*.jpeg";
                if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox.Image.Save(s.FileName);
                    MessageBox.Show("Berhasil Menyimpan Barcode", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            fr_utama ut = new fr_utama();
            ut.Show();
            this.Hide();
        }
    }
}
