namespace BukuTamu
{
    partial class AD_Umum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.tbCari = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCetak = new System.Windows.Forms.Button();
            this.tbHp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbKeperluan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbNama = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Tamu Umum";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(17, 142);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(746, 228);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btHapus
            // 
            this.btHapus.BackColor = System.Drawing.Color.Red;
            this.btHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapus.ForeColor = System.Drawing.Color.White;
            this.btHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHapus.Location = new System.Drawing.Point(642, 376);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(121, 40);
            this.btHapus.TabIndex = 30;
            this.btHapus.Text = "Hapus Tamu";
            this.btHapus.UseVisualStyleBackColor = false;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(654, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID Tamu : ";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.Orange;
            this.l_id.Location = new System.Drawing.Point(745, 6);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(18, 23);
            this.l_id.TabIndex = 32;
            this.l_id.Text = "-";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.btRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.Location = new System.Drawing.Point(532, 376);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(104, 40);
            this.btRefresh.TabIndex = 46;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // tbCari
            // 
            this.tbCari.BorderColorFocused = System.Drawing.Color.Orange;
            this.tbCari.BorderColorIdle = System.Drawing.Color.Orange;
            this.tbCari.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.tbCari.BorderThickness = 3;
            this.tbCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCari.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCari.ForeColor = System.Drawing.Color.Black;
            this.tbCari.isPassword = false;
            this.tbCari.Location = new System.Drawing.Point(75, 384);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(277, 32);
            this.tbCari.TabIndex = 47;
            this.tbCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCari_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(13, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cari : ";
            // 
            // btCetak
            // 
            this.btCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCetak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCetak.ForeColor = System.Drawing.Color.White;
            this.btCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCetak.Location = new System.Drawing.Point(388, 376);
            this.btCetak.Name = "btCetak";
            this.btCetak.Size = new System.Drawing.Size(138, 40);
            this.btCetak.TabIndex = 49;
            this.btCetak.Text = "Cetak Laporan";
            this.btCetak.UseVisualStyleBackColor = false;
            this.btCetak.Click += new System.EventHandler(this.btCetak_Click);
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
            this.tbHp.Location = new System.Drawing.Point(319, 34);
            this.tbHp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(275, 39);
            this.tbHp.TabIndex = 52;
            this.tbHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.tbKeperluan.Location = new System.Drawing.Point(17, 83);
            this.tbKeperluan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbKeperluan.Name = "tbKeperluan";
            this.tbKeperluan.Size = new System.Drawing.Size(276, 42);
            this.tbKeperluan.TabIndex = 51;
            this.tbKeperluan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNama
            // 
            this.tbNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNama.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.HintText = "Nama  Anda";
            this.tbNama.isPassword = false;
            this.tbNama.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.LineThickness = 4;
            this.tbNama.Location = new System.Drawing.Point(17, 34);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(276, 39);
            this.tbNama.TabIndex = 50;
            this.tbNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(319, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 53;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AD_Umum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.tbKeperluan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btCetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "AD_Umum";
            this.Size = new System.Drawing.Size(776, 427);
            this.Load += new System.EventHandler(this.AD_Umum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Button btRefresh;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCetak;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbHp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbKeperluan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNama;
        private System.Windows.Forms.Button button1;

    }
}
