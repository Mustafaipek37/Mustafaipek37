namespace FormAtm
{
    partial class faturaode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faturaode));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbsec = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblgelendogalgaz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgelenelektirik = new System.Windows.Forms.Label();
            this.lblgelensu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbakiyen = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cbsec
            // 
            this.cbsec.BackColor = System.Drawing.Color.Transparent;
            this.cbsec.BorderRadius = 3;
            this.cbsec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbsec.ForeColor = System.Drawing.Color.White;
            this.cbsec.Items = new string[0];
            this.cbsec.Location = new System.Drawing.Point(180, 67);
            this.cbsec.Margin = new System.Windows.Forms.Padding(4);
            this.cbsec.Name = "cbsec";
            this.cbsec.NomalColor = System.Drawing.Color.Gray;
            this.cbsec.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbsec.selectedIndex = -1;
            this.cbsec.Size = new System.Drawing.Size(244, 46);
            this.cbsec.TabIndex = 0;
            this.cbsec.onItemSelected += new System.EventHandler(this.cbsec_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aşağıdan Fatura tipi seçin";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(180, 42);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(244, 18);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.lblgelendogalgaz);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.lblgelenelektirik);
            this.bunifuGradientPanel1.Controls.Add(this.lblgelensu);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-7, 120);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 100;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(697, 217);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(61, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Su:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğalgaz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elektirik:";
            // 
            // lblgelendogalgaz
            // 
            this.lblgelendogalgaz.AutoSize = true;
            this.lblgelendogalgaz.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgelendogalgaz.Location = new System.Drawing.Point(109, 110);
            this.lblgelendogalgaz.Name = "lblgelendogalgaz";
            this.lblgelendogalgaz.Size = new System.Drawing.Size(67, 16);
            this.lblgelendogalgaz.TabIndex = 6;
            this.lblgelendogalgaz.Text = "Doğalgaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gelen Faturalarınız";
            // 
            // lblgelenelektirik
            // 
            this.lblgelenelektirik.AutoSize = true;
            this.lblgelenelektirik.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgelenelektirik.Location = new System.Drawing.Point(109, 42);
            this.lblgelenelektirik.Name = "lblgelenelektirik";
            this.lblgelenelektirik.Size = new System.Drawing.Size(58, 16);
            this.lblgelenelektirik.TabIndex = 5;
            this.lblgelenelektirik.Text = "Elektirik";
            // 
            // lblgelensu
            // 
            this.lblgelensu.AutoSize = true;
            this.lblgelensu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgelensu.Location = new System.Drawing.Point(109, 76);
            this.lblgelensu.Name = "lblgelensu";
            this.lblgelensu.Size = new System.Drawing.Size(25, 16);
            this.lblgelensu.TabIndex = 4;
            this.lblgelensu.Text = "Su";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Faturalar İçin Bakiyen:";
            // 
            // lblbakiyen
            // 
            this.lblbakiyen.AutoSize = true;
            this.lblbakiyen.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbakiyen.Location = new System.Drawing.Point(578, 7);
            this.lblbakiyen.Name = "lblbakiyen";
            this.lblbakiyen.Size = new System.Drawing.Size(19, 21);
            this.lblbakiyen.TabIndex = 5;
            this.lblbakiyen.Text = "...";
            // 
            // faturaode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 336);
            this.Controls.Add(this.lblbakiyen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbsec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faturaode";
            this.Text = "kartborcode";
            this.Load += new System.EventHandler(this.faturaode_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown cbsec;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgelendogalgaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgelenelektirik;
        private System.Windows.Forms.Label lblgelensu;
        private System.Windows.Forms.Label lblbakiyen;
        private System.Windows.Forms.Label label6;
    }
}