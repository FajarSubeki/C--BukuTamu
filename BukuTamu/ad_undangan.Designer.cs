namespace BukuTamu
{
    partial class ad_undangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCari = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Data Tamu Undangan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(746, 335);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.Orange;
            this.l_id.Location = new System.Drawing.Point(751, 7);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(18, 23);
            this.l_id.TabIndex = 59;
            this.l_id.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(660, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID Tamu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(14, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 71;
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
            this.tbCari.Location = new System.Drawing.Point(77, 380);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(275, 37);
            this.tbCari.TabIndex = 70;
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
            this.btRefresh.Location = new System.Drawing.Point(516, 378);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(121, 40);
            this.btRefresh.TabIndex = 69;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(643, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 68;
            this.button1.Text = "Hapus Tamu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(656, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "ID Tamu : ";
            // 
            // btCetak
            // 
            this.btCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCetak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCetak.ForeColor = System.Drawing.Color.White;
            this.btCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCetak.Location = new System.Drawing.Point(372, 375);
            this.btCetak.Name = "btCetak";
            this.btCetak.Size = new System.Drawing.Size(138, 40);
            this.btCetak.TabIndex = 72;
            this.btCetak.Text = "Cetak Laporan";
            this.btCetak.UseVisualStyleBackColor = false;
            this.btCetak.Click += new System.EventHandler(this.btCetak_Click);
            // 
            // ad_undangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ad_undangan";
            this.Size = new System.Drawing.Size(778, 427);
            this.Load += new System.EventHandler(this.ad_undangan_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCetak;
    }
}
