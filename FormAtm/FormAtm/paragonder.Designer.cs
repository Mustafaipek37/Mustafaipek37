namespace FormAtm
{
    partial class paragonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paragonder));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtiban = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btngonder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbakiye = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMiktar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbibanyaz = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lstKayitlar = new System.Windows.Forms.ListBox();
            this.btnarşiv = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnarşiv)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.btnarşiv);
            this.bunifuGradientPanel1.Controls.Add(this.lstKayitlar);
            this.bunifuGradientPanel1.Controls.Add(this.cbibanyaz);
            this.bunifuGradientPanel1.Controls.Add(this.txtMiktar);
            this.bunifuGradientPanel1.Controls.Add(this.lblbakiye);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel1.Controls.Add(this.btngonder);
            this.bunifuGradientPanel1.Controls.Add(this.txtiban);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, -7);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(696, 276);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // txtiban
            // 
            this.txtiban.BackColor = System.Drawing.Color.White;
            this.txtiban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtiban.BackgroundImage")));
            this.txtiban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtiban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtiban.Icon = ((System.Drawing.Image)(resources.GetObject("txtiban.Icon")));
            this.txtiban.Location = new System.Drawing.Point(10, 32);
            this.txtiban.Name = "txtiban";
            this.txtiban.Size = new System.Drawing.Size(323, 42);
            this.txtiban.TabIndex = 0;
            this.txtiban.text = "0";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(361, 19);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Alltaki Sekmeye İban yazın ve kutuya dokunun";
            // 
            // btngonder
            // 
            this.btngonder.Activecolor = System.Drawing.Color.Gray;
            this.btngonder.BackColor = System.Drawing.Color.Gray;
            this.btngonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngonder.BorderRadius = 0;
            this.btngonder.ButtonText = "                Gönder";
            this.btngonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngonder.DisabledColor = System.Drawing.Color.Gray;
            this.btngonder.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngonder.Iconcolor = System.Drawing.Color.Transparent;
            this.btngonder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btngonder.Iconimage")));
            this.btngonder.Iconimage_right = null;
            this.btngonder.Iconimage_right_Selected = null;
            this.btngonder.Iconimage_Selected = null;
            this.btngonder.IconMarginLeft = 0;
            this.btngonder.IconMarginRight = 0;
            this.btngonder.IconRightVisible = true;
            this.btngonder.IconRightZoom = 0D;
            this.btngonder.IconVisible = true;
            this.btngonder.IconZoom = 90D;
            this.btngonder.IsTab = false;
            this.btngonder.Location = new System.Drawing.Point(17, 188);
            this.btngonder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngonder.Name = "btngonder";
            this.btngonder.Normalcolor = System.Drawing.Color.Gray;
            this.btngonder.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.btngonder.OnHoverTextColor = System.Drawing.Color.White;
            this.btngonder.selected = false;
            this.btngonder.Size = new System.Drawing.Size(323, 38);
            this.btngonder.TabIndex = 2;
            this.btngonder.Text = "                Gönder";
            this.btngonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngonder.Textcolor = System.Drawing.Color.White;
            this.btngonder.TextFont = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(297, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bakiyen";
            // 
            // lblbakiye
            // 
            this.lblbakiye.AutoSize = true;
            this.lblbakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblbakiye.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbakiye.ForeColor = System.Drawing.Color.Black;
            this.lblbakiye.Location = new System.Drawing.Point(308, 144);
            this.lblbakiye.Name = "lblbakiye";
            this.lblbakiye.Size = new System.Drawing.Size(25, 23);
            this.lblbakiye.TabIndex = 6;
            this.lblbakiye.Text = "...";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(10, 80);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(323, 17);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(127, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 19);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Miktar Girin";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiktar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMiktar.HintForeColor = System.Drawing.Color.Empty;
            this.txtMiktar.HintText = "";
            this.txtMiktar.isPassword = false;
            this.txtMiktar.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txtMiktar.LineIdleColor = System.Drawing.Color.Transparent;
            this.txtMiktar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMiktar.LineThickness = 3;
            this.txtMiktar.Location = new System.Drawing.Point(66, 123);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(224, 44);
            this.txtMiktar.TabIndex = 9;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbibanyaz
            // 
            this.cbibanyaz.BackColor = System.Drawing.Color.Black;
            this.cbibanyaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbibanyaz.ChechedOffColor = System.Drawing.Color.Black;
            this.cbibanyaz.Checked = false;
            this.cbibanyaz.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbibanyaz.ForeColor = System.Drawing.Color.White;
            this.cbibanyaz.Location = new System.Drawing.Point(339, 32);
            this.cbibanyaz.Name = "cbibanyaz";
            this.cbibanyaz.Size = new System.Drawing.Size(20, 20);
            this.cbibanyaz.TabIndex = 1;
            this.cbibanyaz.OnChange += new System.EventHandler(this.cbibanyaz_OnChange);
            // 
            // lstKayitlar
            // 
            this.lstKayitlar.FormattingEnabled = true;
            this.lstKayitlar.Location = new System.Drawing.Point(373, 10);
            this.lstKayitlar.Name = "lstKayitlar";
            this.lstKayitlar.Size = new System.Drawing.Size(319, 212);
            this.lstKayitlar.TabIndex = 1;
            // 
            // btnarşiv
            // 
            this.btnarşiv.BackColor = System.Drawing.Color.Transparent;
            this.btnarşiv.Image = ((System.Drawing.Image)(resources.GetObject("btnarşiv.Image")));
            this.btnarşiv.ImageActive = null;
            this.btnarşiv.Location = new System.Drawing.Point(373, 218);
            this.btnarşiv.Name = "btnarşiv";
            this.btnarşiv.Size = new System.Drawing.Size(319, 55);
            this.btnarşiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnarşiv.TabIndex = 10;
            this.btnarşiv.TabStop = false;
            this.btnarşiv.Zoom = 10;
            this.btnarşiv.Click += new System.EventHandler(this.btnarşiv_Click);
            // 
            // paragonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 266);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "paragonder";
            this.Text = "paragonder";
            this.Load += new System.EventHandler(this.paragonder_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnarşiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTextbox txtiban;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btngonder;
        private System.Windows.Forms.Label lblbakiye;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMiktar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCheckbox cbibanyaz;
        private System.Windows.Forms.ListBox lstKayitlar;
        private Bunifu.Framework.UI.BunifuImageButton btnarşiv;
    }
}