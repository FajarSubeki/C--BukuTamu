namespace BukuTamu
{
    partial class fr_utama
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_utama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lHari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lJam = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.b_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.slider = new System.Windows.Forms.PictureBox();
            this.btDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btUmum = new System.Windows.Forms.Button();
            this.btOrtu = new System.Windows.Forms.Button();
            this.btAlumni = new System.Windows.Forms.Button();
            this.btPerusahaan = new System.Windows.Forms.Button();
            this.btKunjungan = new System.Windows.Forms.Button();
            this.btUndangan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.undangan1 = new BukuTamu.UserControls.Undangan();
            this.tKunjungan1 = new BukuTamu.UserControls.tKunjungan();
            this.tPerusahaan1 = new BukuTamu.UserControls.tPerusahaan();
            this.tAlumni1 = new BukuTamu.UserControls.tAlumni();
            this.tOrtu1 = new BukuTamu.UserControls.tOrtu();
            this.tUmum1 = new BukuTamu.UserControls.tUmum();
            this.dashboardTM1 = new BukuTamu.UserControls.DashboardTM();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.lHari);
            this.panel1.Controls.Add(this.lJam);
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 33);
            this.panel1.TabIndex = 1;
            // 
            // lHari
            // 
            this.lHari.AutoSize = true;
            this.lHari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHari.ForeColor = System.Drawing.Color.White;
            this.lHari.Location = new System.Drawing.Point(107, 5);
            this.lHari.Name = "lHari";
            this.lHari.Size = new System.Drawing.Size(113, 19);
            this.lHari.TabIndex = 8;
            this.lHari.Text = "Hari, Tanggal";
            this.lHari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lJam
            // 
            this.lJam.AutoSize = true;
            this.lJam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJam.ForeColor = System.Drawing.Color.White;
            this.lJam.Location = new System.Drawing.Point(12, 6);
            this.lJam.Name = "lJam";
            this.lJam.Size = new System.Drawing.Size(44, 19);
            this.lJam.TabIndex = 7;
            this.lJam.Text = "Jam";
            this.lJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_exit
            // 
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Image = ((System.Drawing.Image)(resources.GetObject("b_exit.Image")));
            this.b_exit.Location = new System.Drawing.Point(911, 2);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(29, 27);
            this.b_exit.TabIndex = 3;
            this.b_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.slider);
            this.panel3.Controls.Add(this.btDashboard);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btUmum);
            this.panel3.Controls.Add(this.btOrtu);
            this.panel3.Controls.Add(this.btAlumni);
            this.panel3.Controls.Add(this.btPerusahaan);
            this.panel3.Controls.Add(this.btKunjungan);
            this.panel3.Controls.Add(this.btUndangan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 57);
            this.panel3.TabIndex = 3;
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Orange;
            this.slider.Location = new System.Drawing.Point(215, 50);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(110, 7);
            this.slider.TabIndex = 11;
            this.slider.TabStop = false;
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDashboard.FlatAppearance.BorderSize = 0;
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.White;
            this.btDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDashboard.Location = new System.Drawing.Point(215, 0);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(110, 54);
            this.btDashboard.TabIndex = 10;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.UseVisualStyleBackColor = false;
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "MariGuest";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btUmum
            // 
            this.btUmum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.btUmum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUmum.FlatAppearance.BorderSize = 0;
            this.btUmum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUmum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUmum.ForeColor = System.Drawing.Color.White;
            this.btUmum.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUmum.Location = new System.Drawing.Point(318, 0);
            this.btUmum.Name = "btUmum";
            this.btUmum.Size = new System.Drawing.Size(110, 54);
            this.btUmum.TabIndex = 8;
            this.btUmum.Text = "Umum";
            this.btUmum.UseVisualStyleBackColor = false;
            this.btUmum.Click += new System.EventHandler(this.btUmum_Click);
            // 
            // btOrtu
            // 
            this.btOrtu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOrtu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrtu.FlatAppearance.BorderSize = 0;
            this.btOrtu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrtu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrtu.ForeColor = System.Drawing.Color.White;
            this.btOrtu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOrtu.Location = new System.Drawing.Point(423, 0);
            this.btOrtu.Name = "btOrtu";
            this.btOrtu.Size = new System.Drawing.Size(110, 54);
            this.btOrtu.TabIndex = 7;
            this.btOrtu.Text = "Orang Tua";
            this.btOrtu.UseVisualStyleBackColor = false;
            this.btOrtu.Click += new System.EventHandler(this.btOrtu_Click);
            // 
            // btAlumni
            // 
            this.btAlumni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.btAlumni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlumni.FlatAppearance.BorderSize = 0;
            this.btAlumni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlumni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlumni.ForeColor = System.Drawing.Color.White;
            this.btAlumni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlumni.Location = new System.Drawing.Point(528, 0);
            this.btAlumni.Name = "btAlumni";
            this.btAlumni.Size = new System.Drawing.Size(110, 54);
            this.btAlumni.TabIndex = 6;
            this.btAlumni.Text = "Alumni";
            this.btAlumni.UseVisualStyleBackColor = false;
            this.btAlumni.Click += new System.EventHandler(this.btAlumni_Click);
            // 
            // btPerusahaan
            // 
            this.btPerusahaan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btPerusahaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPerusahaan.FlatAppearance.BorderSize = 0;
            this.btPerusahaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerusahaan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerusahaan.ForeColor = System.Drawing.Color.White;
            this.btPerusahaan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPerusahaan.Location = new System.Drawing.Point(635, 0);
            this.btPerusahaan.Name = "btPerusahaan";
            this.btPerusahaan.Size = new System.Drawing.Size(110, 54);
            this.btPerusahaan.TabIndex = 5;
            this.btPerusahaan.Text = "Perusahaan";
            this.btPerusahaan.UseVisualStyleBackColor = false;
            this.btPerusahaan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btKunjungan
            // 
            this.btKunjungan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.btKunjungan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKunjungan.FlatAppearance.BorderSize = 0;
            this.btKunjungan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKunjungan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKunjungan.ForeColor = System.Drawing.Color.White;
            this.btKunjungan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btKunjungan.Location = new System.Drawing.Point(737, 0);
            this.btKunjungan.Name = "btKunjungan";
            this.btKunjungan.Size = new System.Drawing.Size(110, 54);
            this.btKunjungan.TabIndex = 4;
            this.btKunjungan.Text = "Kunjungan";
            this.btKunjungan.UseVisualStyleBackColor = false;
            this.btKunjungan.Click += new System.EventHandler(this.btKunjungan_Click);
            // 
            // btUndangan
            // 
            this.btUndangan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btUndangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUndangan.FlatAppearance.BorderSize = 0;
            this.btUndangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUndangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndangan.ForeColor = System.Drawing.Color.White;
            this.btUndangan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUndangan.Location = new System.Drawing.Point(842, 0);
            this.btUndangan.Name = "btUndangan";
            this.btUndangan.Size = new System.Drawing.Size(109, 54);
            this.btUndangan.TabIndex = 3;
            this.btUndangan.Text = "Undangan";
            this.btUndangan.UseVisualStyleBackColor = false;
            this.btUndangan.Click += new System.EventHandler(this.btUndangan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 36);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(367, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(211, 19);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "MariGuest v1.0 Beta ©2018";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(10, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 36);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(900, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 36);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.undangan1);
            this.panelContainer.Controls.Add(this.tKunjungan1);
            this.panelContainer.Controls.Add(this.tPerusahaan1);
            this.panelContainer.Controls.Add(this.tAlumni1);
            this.panelContainer.Controls.Add(this.tOrtu1);
            this.panelContainer.Controls.Add(this.tUmum1);
            this.panelContainer.Controls.Add(this.dashboardTM1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 111);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(951, 259);
            this.panelContainer.TabIndex = 10;
            // 
            // undangan1
            // 
            this.undangan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undangan1.Location = new System.Drawing.Point(0, 0);
            this.undangan1.Name = "undangan1";
            this.undangan1.Size = new System.Drawing.Size(951, 259);
            this.undangan1.TabIndex = 6;
            // 
            // tKunjungan1
            // 
            this.tKunjungan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tKunjungan1.Location = new System.Drawing.Point(0, 0);
            this.tKunjungan1.Name = "tKunjungan1";
            this.tKunjungan1.Size = new System.Drawing.Size(951, 259);
            this.tKunjungan1.TabIndex = 5;
            // 
            // tPerusahaan1
            // 
            this.tPerusahaan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPerusahaan1.Location = new System.Drawing.Point(0, 0);
            this.tPerusahaan1.Name = "tPerusahaan1";
            this.tPerusahaan1.Size = new System.Drawing.Size(951, 259);
            this.tPerusahaan1.TabIndex = 4;
            // 
            // tAlumni1
            // 
            this.tAlumni1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAlumni1.Location = new System.Drawing.Point(0, 0);
            this.tAlumni1.Name = "tAlumni1";
            this.tAlumni1.Size = new System.Drawing.Size(951, 259);
            this.tAlumni1.TabIndex = 3;
            // 
            // tOrtu1
            // 
            this.tOrtu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tOrtu1.Location = new System.Drawing.Point(0, 0);
            this.tOrtu1.Name = "tOrtu1";
            this.tOrtu1.Size = new System.Drawing.Size(951, 259);
            this.tOrtu1.TabIndex = 2;
            // 
            // tUmum1
            // 
            this.tUmum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tUmum1.Location = new System.Drawing.Point(0, 0);
            this.tUmum1.Name = "tUmum1";
            this.tUmum1.Size = new System.Drawing.Size(951, 259);
            this.tUmum1.TabIndex = 1;
            this.tUmum1.Load += new System.EventHandler(this.tUmum1_Load);
            // 
            // dashboardTM1
            // 
            this.dashboardTM1.BackColor = System.Drawing.Color.White;
            this.dashboardTM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardTM1.Location = new System.Drawing.Point(0, 0);
            this.dashboardTM1.Name = "dashboardTM1";
            this.dashboardTM1.Size = new System.Drawing.Size(951, 259);
            this.dashboardTM1.TabIndex = 0;
            this.dashboardTM1.Load += new System.EventHandler(this.dashboardTM1_Load);
            // 
            // fr_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 406);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fr_utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_utama";
            this.Load += new System.EventHandler(this.fr_utama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btUndangan;
        private System.Windows.Forms.Button btPerusahaan;
        private System.Windows.Forms.Button btKunjungan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btUmum;
        private System.Windows.Forms.Button btOrtu;
        private System.Windows.Forms.Button btAlumni;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private Bunifu.Framework.UI.BunifuCustomLabel lHari;
        private Bunifu.Framework.UI.BunifuCustomLabel lJam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private UserControls.DashboardTM dashboardTM1;
        private UserControls.tUmum tUmum1;
        private UserControls.tOrtu tOrtu1;
        private UserControls.tAlumni tAlumni1;
        private UserControls.Undangan undangan1;
        private UserControls.tKunjungan tKunjungan1;
        private UserControls.tPerusahaan tPerusahaan1;
        private System.Windows.Forms.PictureBox slider;
    }
}