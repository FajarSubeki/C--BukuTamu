namespace BukuTamu
{
    partial class adm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adm_login));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.l_qr = new System.Windows.Forms.Label();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.b_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuThinButton21 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Orange;
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(309, 570);
            this.panelLeft.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelola Data Tamu \r\n  Dengan Efisien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "MariGuest v1.0 Beta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.l_qr);
            this.panelRight.Controls.Add(this.tbPassword);
            this.panelRight.Controls.Add(this.tbUsername);
            this.panelRight.Controls.Add(this.b_exit);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.bunifuCheckbox1);
            this.panelRight.Controls.Add(this.bunifuThinButton21);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRight.Location = new System.Drawing.Point(309, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(319, 570);
            this.panelRight.TabIndex = 1;
            // 
            // l_qr
            // 
            this.l_qr.AutoSize = true;
            this.l_qr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_qr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_qr.ForeColor = System.Drawing.Color.Black;
            this.l_qr.Location = new System.Drawing.Point(77, 399);
            this.l_qr.Name = "l_qr";
            this.l_qr.Size = new System.Drawing.Size(173, 21);
            this.l_qr.TabIndex = 37;
            this.l_qr.Text = "Login With QrCode !!!";
            this.l_qr.Click += new System.EventHandler(this.l_qr_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HintForeColor = System.Drawing.Color.Black;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = true;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.Orange;
            this.tbPassword.LineIdleColor = System.Drawing.Color.Orange;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.tbPassword.LineThickness = 4;
            this.tbPassword.Location = new System.Drawing.Point(28, 231);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(257, 43);
            this.tbPassword.TabIndex = 36;
            this.tbPassword.Text = "********";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.HintForeColor = System.Drawing.Color.Black;
            this.tbUsername.HintText = "Username Anda";
            this.tbUsername.isPassword = false;
            this.tbUsername.LineFocusedColor = System.Drawing.Color.Orange;
            this.tbUsername.LineIdleColor = System.Drawing.Color.Orange;
            this.tbUsername.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.tbUsername.LineThickness = 4;
            this.tbUsername.Location = new System.Drawing.Point(29, 161);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(257, 43);
            this.tbUsername.TabIndex = 35;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // b_exit
            // 
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Image = ((System.Drawing.Image)(resources.GetObject("b_exit.Image")));
            this.b_exit.Location = new System.Drawing.Point(283, 2);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(29, 27);
            this.b_exit.TabIndex = 11;
            this.b_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(55, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "I Agree Terms and Conditions";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Orange;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Orange;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(29, 291);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 9;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(28, 346);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(263, 41);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.Text = "Sign In";
            this.bunifuThinButton21.UseVisualStyleBackColor = false;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(25, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sign In";
            // 
            // adm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(628, 570);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adm_login";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Button bunifuThinButton21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_exit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        private System.Windows.Forms.Label l_qr;

    }
}