namespace BukuTamu.UserControls
{
    partial class tAlumni
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tAlumni));
            this.btReset = new System.Windows.Forms.Button();
            this.drJurusan = new Bunifu.Framework.UI.BunifuDropdown();
            this.drTahunLulus = new Bunifu.Framework.UI.BunifuDropdown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbNama = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbHp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tbKeperluan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btSelesai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btUlangi = new System.Windows.Forms.Button();
            this.btTakePhoto = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btResetTtd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Red;
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReset.Location = new System.Drawing.Point(237, 220);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(103, 36);
            this.btReset.TabIndex = 30;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // drJurusan
            // 
            this.drJurusan.BackColor = System.Drawing.Color.Transparent;
            this.drJurusan.BorderRadius = 10;
            this.drJurusan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drJurusan.DisabledColor = System.Drawing.Color.Gray;
            this.drJurusan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drJurusan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drJurusan.Items = new string[] {
        "Jurusan Anda",
        "APK",
        "RPL",
        "MMD",
        "TKJ",
        "PMN",
        "TBG",
        "APH"};
            this.drJurusan.Location = new System.Drawing.Point(61, 94);
            this.drJurusan.Margin = new System.Windows.Forms.Padding(8);
            this.drJurusan.Name = "drJurusan";
            this.drJurusan.NomalColor = System.Drawing.Color.LightGray;
            this.drJurusan.onHoverColor = System.Drawing.Color.LightGray;
            this.drJurusan.selectedIndex = 0;
            this.drJurusan.Size = new System.Drawing.Size(279, 34);
            this.drJurusan.TabIndex = 31;
            // 
            // drTahunLulus
            // 
            this.drTahunLulus.BackColor = System.Drawing.Color.Transparent;
            this.drTahunLulus.BorderRadius = 10;
            this.drTahunLulus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drTahunLulus.DisabledColor = System.Drawing.Color.Gray;
            this.drTahunLulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drTahunLulus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drTahunLulus.Items = new string[] {
        "Tahun Lulus Anda",
        "1996",
        "1997",
        "1998",
        "1999",
        "2000",
        "2001",
        "2002",
        "2003",
        "2004",
        "2005",
        "2006",
        "2007",
        "2008",
        "2009",
        "2010",
        "2011",
        "2012",
        "2013",
        "2014",
        "2015",
        "2016",
        "2017",
        "2018"};
            this.drTahunLulus.Location = new System.Drawing.Point(61, 48);
            this.drTahunLulus.Margin = new System.Windows.Forms.Padding(8);
            this.drTahunLulus.Name = "drTahunLulus";
            this.drTahunLulus.NomalColor = System.Drawing.Color.LightGray;
            this.drTahunLulus.onHoverColor = System.Drawing.Color.LightGray;
            this.drTahunLulus.selectedIndex = 0;
            this.drTahunLulus.Size = new System.Drawing.Size(279, 35);
            this.drTahunLulus.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // tbNama
            // 
            this.tbNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNama.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.HintText = "Nama Alumni";
            this.tbNama.isPassword = false;
            this.tbNama.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.LineThickness = 4;
            this.tbNama.Location = new System.Drawing.Point(61, 0);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(279, 38);
            this.tbNama.TabIndex = 34;
            this.tbNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(20, 137);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // tbHp
            // 
            this.tbHp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHp.HintText = "No Hp";
            this.tbHp.isPassword = false;
            this.tbHp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHp.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHp.LineThickness = 4;
            this.tbHp.Location = new System.Drawing.Point(61, 133);
            this.tbHp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(279, 39);
            this.tbHp.TabIndex = 38;
            this.tbHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHp_KeyPress);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(352, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            // 
            // tbKeperluan
            // 
            this.tbKeperluan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKeperluan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeperluan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKeperluan.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKeperluan.HintText = "Keperluan";
            this.tbKeperluan.isPassword = false;
            this.tbKeperluan.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKeperluan.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKeperluan.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKeperluan.LineThickness = 4;
            this.tbKeperluan.Location = new System.Drawing.Point(392, 5);
            this.tbKeperluan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbKeperluan.Name = "tbKeperluan";
            this.tbKeperluan.Size = new System.Drawing.Size(279, 39);
            this.tbKeperluan.TabIndex = 42;
            this.tbKeperluan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbKeperluan.OnValueChanged += new System.EventHandler(this.tbKeperluan_OnValueChanged);
            // 
            // btSelesai
            // 
            this.btSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.btSelesai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelesai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelesai.ForeColor = System.Drawing.Color.White;
            this.btSelesai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSelesai.Location = new System.Drawing.Point(128, 220);
            this.btSelesai.Name = "btSelesai";
            this.btSelesai.Size = new System.Drawing.Size(103, 36);
            this.btSelesai.TabIndex = 44;
            this.btSelesai.Text = "Selesai";
            this.btSelesai.UseVisualStyleBackColor = false;
            this.btSelesai.Click += new System.EventHandler(this.btSelesai_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tanda Tangan Anda !!!";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(687, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(248, 220);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 49;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btUlangi
            // 
            this.btUlangi.BackColor = System.Drawing.Color.Red;
            this.btUlangi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlangi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUlangi.ForeColor = System.Drawing.Color.White;
            this.btUlangi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUlangi.Location = new System.Drawing.Point(677, 224);
            this.btUlangi.Name = "btUlangi";
            this.btUlangi.Size = new System.Drawing.Size(90, 32);
            this.btUlangi.TabIndex = 52;
            this.btUlangi.Text = "Ulangi Foto";
            this.btUlangi.UseVisualStyleBackColor = false;
            this.btUlangi.Click += new System.EventHandler(this.btUlangi_Click);
            // 
            // btTakePhoto
            // 
            this.btTakePhoto.BackColor = System.Drawing.Color.Orange;
            this.btTakePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTakePhoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTakePhoto.ForeColor = System.Drawing.Color.White;
            this.btTakePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTakePhoto.Location = new System.Drawing.Point(840, 223);
            this.btTakePhoto.Name = "btTakePhoto";
            this.btTakePhoto.Size = new System.Drawing.Size(101, 32);
            this.btTakePhoto.TabIndex = 51;
            this.btTakePhoto.Text = "Ambil Photo";
            this.btTakePhoto.UseVisualStyleBackColor = false;
            this.btTakePhoto.Click += new System.EventHandler(this.btTakePhoto_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(20, 178);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintText = "Email";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.LineThickness = 4;
            this.tbEmail.Location = new System.Drawing.Point(61, 175);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(279, 42);
            this.tbEmail.TabIndex = 53;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(547, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 55;
            this.button1.Text = "Pilih Warna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(941, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(10, 24);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 125);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.Location = new System.Drawing.Point(760, 224);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 32);
            this.btnStop.TabIndex = 58;
            this.btnStop.Text = "Stop Foto";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btResetTtd
            // 
            this.btResetTtd.BackColor = System.Drawing.Color.Red;
            this.btResetTtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResetTtd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetTtd.ForeColor = System.Drawing.Color.White;
            this.btResetTtd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResetTtd.Location = new System.Drawing.Point(451, 223);
            this.btResetTtd.Name = "btResetTtd";
            this.btResetTtd.Size = new System.Drawing.Size(90, 32);
            this.btResetTtd.TabIndex = 100;
            this.btResetTtd.Text = "Reset";
            this.btResetTtd.UseVisualStyleBackColor = false;
            this.btResetTtd.Click += new System.EventHandler(this.btResetTtd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(352, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 142);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // tAlumni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btResetTtd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btUlangi);
            this.Controls.Add(this.btTakePhoto);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSelesai);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.tbKeperluan);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.drTahunLulus);
            this.Controls.Add(this.drJurusan);
            this.Controls.Add(this.btReset);
            this.Name = "tAlumni";
            this.Size = new System.Drawing.Size(951, 259);
            this.Load += new System.EventHandler(this.tAlumni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private Bunifu.Framework.UI.BunifuDropdown drJurusan;
        private Bunifu.Framework.UI.BunifuDropdown drTahunLulus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNama;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbHp;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbKeperluan;
        private System.Windows.Forms.Button btSelesai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btUlangi;
        private System.Windows.Forms.Button btTakePhoto;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btResetTtd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
