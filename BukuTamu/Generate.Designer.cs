namespace BukuTamu
{
    partial class Generate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSaveQRCode = new System.Windows.Forms.Button();
            this.btnSaveBarcode = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(24, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(448, 174);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(65, 245);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(182, 29);
            this.txtBarcode.TabIndex = 2;
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(265, 245);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(95, 28);
            this.btnBarcode.TabIndex = 3;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.Location = new System.Drawing.Point(265, 288);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(95, 28);
            this.btnQRCode.TabIndex = 6;
            this.btnQRCode.Text = "QRCode";
            this.btnQRCode.UseVisualStyleBackColor = true;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(65, 288);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(182, 29);
            this.txtQRCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "QRCode";
            // 
            // btSaveQRCode
            // 
            this.btSaveQRCode.Location = new System.Drawing.Point(377, 288);
            this.btSaveQRCode.Name = "btSaveQRCode";
            this.btSaveQRCode.Size = new System.Drawing.Size(95, 28);
            this.btSaveQRCode.TabIndex = 7;
            this.btSaveQRCode.Text = "Save QRCode";
            this.btSaveQRCode.UseVisualStyleBackColor = true;
            this.btSaveQRCode.Click += new System.EventHandler(this.btSaveQRCode_Click);
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.Location = new System.Drawing.Point(377, 245);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.Size = new System.Drawing.Size(95, 28);
            this.btnSaveBarcode.TabIndex = 8;
            this.btnSaveBarcode.Text = "Save Barcode";
            this.btnSaveBarcode.UseVisualStyleBackColor = true;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // b_exit
            // 
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Image = ((System.Drawing.Image)(resources.GetObject("b_exit.Image")));
            this.b_exit.Location = new System.Drawing.Point(458, 5);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(29, 27);
            this.b_exit.TabIndex = 9;
            this.b_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 38);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Generate Barcode and QRCode";
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveBarcode);
            this.Controls.Add(this.btSaveQRCode);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSaveQRCode;
        private System.Windows.Forms.Button btnSaveBarcode;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}