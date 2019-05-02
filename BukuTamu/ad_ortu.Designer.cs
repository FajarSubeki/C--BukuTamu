namespace BukuTamu
{
    partial class ad_ortu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCari = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data Tamu Orang Tua";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(746, 335);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.Orange;
            this.l_id.Location = new System.Drawing.Point(744, 10);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(18, 23);
            this.l_id.TabIndex = 47;
            this.l_id.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(654, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID Tamu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(10, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cari : ";
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
            this.tbCari.Location = new System.Drawing.Point(72, 387);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(257, 32);
            this.tbCari.TabIndex = 51;
            this.tbCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCari_KeyPress);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.btRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.Location = new System.Drawing.Point(512, 382);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(121, 40);
            this.btRefresh.TabIndex = 50;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btHapus
            // 
            this.btHapus.BackColor = System.Drawing.Color.Red;
            this.btHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapus.ForeColor = System.Drawing.Color.White;
            this.btHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHapus.Location = new System.Drawing.Point(639, 382);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(121, 40);
            this.btHapus.TabIndex = 49;
            this.btHapus.Text = "Hapus Tamu";
            this.btHapus.UseVisualStyleBackColor = false;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btCetak
            // 
            this.btCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCetak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCetak.ForeColor = System.Drawing.Color.White;
            this.btCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCetak.Location = new System.Drawing.Point(368, 381);
            this.btCetak.Name = "btCetak";
            this.btCetak.Size = new System.Drawing.Size(138, 40);
            this.btCetak.TabIndex = 53;
            this.btCetak.Text = "Cetak Laporan";
            this.btCetak.UseVisualStyleBackColor = false;
            this.btCetak.Click += new System.EventHandler(this.btCetak_Click);
            // 
            // ad_ortu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ad_ortu";
            this.Size = new System.Drawing.Size(778, 427);
            this.Load += new System.EventHandler(this.ad_ortu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCari;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btCetak;
    }
}
