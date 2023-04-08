namespace FormAtm
{
    partial class parayatır
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parayatır));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnayla = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBankadakiPara = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblyatır = new System.Windows.Forms.Label();
            this.txtyatır = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankadakiPara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btnOnayla);
            this.bunifuGradientPanel1.Controls.Add(this.btnBankadakiPara);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lblyatır);
            this.bunifuGradientPanel1.Controls.Add(this.txtyatır);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(409, 184);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yatırılıcak Limit:8500TL";
            // 
            // btnOnayla
            // 
            this.btnOnayla.ActiveBorderThickness = 1;
            this.btnOnayla.ActiveCornerRadius = 20;
            this.btnOnayla.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnOnayla.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnOnayla.ActiveLineColor = System.Drawing.Color.CadetBlue;
            this.btnOnayla.BackColor = System.Drawing.SystemColors.Control;
            this.btnOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnayla.BackgroundImage")));
            this.btnOnayla.ButtonText = "Onaylıyorum";
            this.btnOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnayla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnOnayla.IdleBorderThickness = 1;
            this.btnOnayla.IdleCornerRadius = 20;
            this.btnOnayla.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnOnayla.IdleForecolor = System.Drawing.Color.LavenderBlush;
            this.btnOnayla.IdleLineColor = System.Drawing.Color.LavenderBlush;
            this.btnOnayla.Location = new System.Drawing.Point(65, 106);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(5);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(181, 41);
            this.btnOnayla.TabIndex = 10;
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnBankadakiPara
            // 
            this.btnBankadakiPara.BackColor = System.Drawing.Color.Transparent;
            this.btnBankadakiPara.Image = ((System.Drawing.Image)(resources.GetObject("btnBankadakiPara.Image")));
            this.btnBankadakiPara.ImageActive = null;
            this.btnBankadakiPara.Location = new System.Drawing.Point(320, 104);
            this.btnBankadakiPara.Name = "btnBankadakiPara";
            this.btnBankadakiPara.Size = new System.Drawing.Size(75, 65);
            this.btnBankadakiPara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBankadakiPara.TabIndex = 9;
            this.btnBankadakiPara.TabStop = false;
            this.btnBankadakiPara.Zoom = 5;
            this.btnBankadakiPara.Click += new System.EventHandler(this.btnBankadakiPara_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FormAtm.Properties.Resources.deposit_no_corruption_icon_226103;
            this.pictureBox1.Location = new System.Drawing.Point(3, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblyatır
            // 
            this.lblyatır.AutoSize = true;
            this.lblyatır.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyatır.Location = new System.Drawing.Point(61, 28);
            this.lblyatır.Name = "lblyatır";
            this.lblyatır.Size = new System.Drawing.Size(311, 21);
            this.lblyatır.TabIndex = 1;
            this.lblyatır.Text = "Aşağıdaki kısma yatırılacak tutarı giriniz";
            // 
            // txtyatır
            // 
            this.txtyatır.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtyatır.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtyatır.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtyatır.HintForeColor = System.Drawing.Color.Empty;
            this.txtyatır.HintText = "";
            this.txtyatır.isPassword = false;
            this.txtyatır.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txtyatır.LineIdleColor = System.Drawing.Color.Gray;
            this.txtyatır.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtyatır.LineThickness = 3;
            this.txtyatır.Location = new System.Drawing.Point(62, 53);
            this.txtyatır.Margin = new System.Windows.Forms.Padding(4);
            this.txtyatır.Name = "txtyatır";
            this.txtyatır.Size = new System.Drawing.Size(310, 44);
            this.txtyatır.TabIndex = 0;
            this.txtyatır.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // parayatır
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 175);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "parayatır";
            this.Text = "parayatır";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankadakiPara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblyatır;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtyatır;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnBankadakiPara;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOnayla;
        private System.Windows.Forms.Label label1;
    }
}