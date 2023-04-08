namespace FormAtm
{
    partial class AtmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButonKartCıkar = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButonKarttak = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btngiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButonKartCıkar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButonKarttak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifrenizi Girin";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtSifre.HintText = "";
            this.txtSifre.isPassword = true;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.Yellow;
            this.txtSifre.LineIdleColor = System.Drawing.Color.Black;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.MediumSpringGreen;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(244, 161);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(370, 44);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.Text = "Şifre/Password";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.OnValueChanged += new System.EventHandler(this.txtSifre_OnValueChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.ButonKartCıkar);
            this.bunifuGradientPanel1.Controls.Add(this.ButonKarttak);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(105, 310);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormAtm.Properties.Resources._360_F_105687242_Emq31t55LuKHi3KNywD98Tfhf0PNlCEq1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ButonKartCıkar
            // 
            this.ButonKartCıkar.BackColor = System.Drawing.Color.White;
            this.ButonKartCıkar.Image = ((System.Drawing.Image)(resources.GetObject("ButonKartCıkar.Image")));
            this.ButonKartCıkar.ImageActive = null;
            this.ButonKartCıkar.Location = new System.Drawing.Point(3, 246);
            this.ButonKartCıkar.Name = "ButonKartCıkar";
            this.ButonKartCıkar.Size = new System.Drawing.Size(94, 61);
            this.ButonKartCıkar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButonKartCıkar.TabIndex = 7;
            this.ButonKartCıkar.TabStop = false;
            this.ButonKartCıkar.Zoom = 10;
            this.ButonKartCıkar.Click += new System.EventHandler(this.ButonKartCıkar_Click);
            // 
            // ButonKarttak
            // 
            this.ButonKarttak.BackColor = System.Drawing.Color.White;
            this.ButonKarttak.Image = ((System.Drawing.Image)(resources.GetObject("ButonKarttak.Image")));
            this.ButonKarttak.ImageActive = null;
            this.ButonKarttak.Location = new System.Drawing.Point(3, 3);
            this.ButonKarttak.Name = "ButonKarttak";
            this.ButonKarttak.Size = new System.Drawing.Size(94, 61);
            this.ButonKarttak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButonKarttak.TabIndex = 0;
            this.ButonKarttak.TabStop = false;
            this.ButonKarttak.Zoom = 10;
            this.ButonKarttak.Click += new System.EventHandler(this.ButonKarttak_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormAtm.Properties.Resources.internet_lock_locked_padlock_password_secure_security_icon_127100;
            this.pictureBox2.Location = new System.Drawing.Point(179, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btngiris
            // 
            this.btngiris.ActiveBorderThickness = 1;
            this.btngiris.ActiveCornerRadius = 20;
            this.btngiris.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btngiris.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btngiris.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btngiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btngiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngiris.BackgroundImage")));
            this.btngiris.ButtonText = "Giriş Yap";
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.btngiris.IdleBorderThickness = 1;
            this.btngiris.IdleCornerRadius = 20;
            this.btngiris.IdleFillColor = System.Drawing.Color.Transparent;
            this.btngiris.IdleForecolor = System.Drawing.Color.White;
            this.btngiris.IdleLineColor = System.Drawing.Color.Green;
            this.btngiris.Location = new System.Drawing.Point(247, 214);
            this.btngiris.Margin = new System.Windows.Forms.Padding(5);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(206, 41);
            this.btngiris.TabIndex = 5;
            this.btngiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Wheat;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(104, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 20;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(690, 61);
            this.bunifuGradientPanel2.TabIndex = 8;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(60, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(571, 43);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Aşağıdaki Panelden Giriş Yapınız";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // AtmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 307);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BANKAMATİK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButonKartCıkar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButonKarttak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSifre;
        private Bunifu.Framework.UI.BunifuThinButton2 btngiris;
        private Bunifu.Framework.UI.BunifuImageButton ButonKartCıkar;
        private Bunifu.Framework.UI.BunifuImageButton ButonKarttak;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;



    }
}

