using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAtm
{
    public partial class AtmGiris : Form
    {
        public AtmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.Visible = false;
            btngiris.Visible = false;
            pictureBox2.Visible = false;
            label2.Visible = false;
            bunifuCustomLabel1.Visible = false;
           
        }

        private void btnkarttak_Click(object sender, EventArgs e)
        {
            //bazı yanlıs yerler
        }

        private void btnKartCıkar_Click(object sender, EventArgs e)
        {
           //bazı yanlıs yerler
        }
        bool girdimi = false;
        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            /*int sifre = Convert.ToInt32(txtSifregir.Text);
            if (sifre==3737)
            {
                MessageBox.Show("Giriş Başarılı","Giriş", MessageBoxButtons.OK,MessageBoxIcon.Information);
                girdimi = true;
                btnGirisyap.Visible = false;
                lbsifregir.Visible = false;
                txtSifregir.Visible = false;
                AtmPanel fr2 = new AtmPanel();
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girişi Tespit Edildi", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             */
        }

        private void txtSifregir_Click(object sender, EventArgs e)
        {
           // txtSifregir.Text = "";
        }

        private void rbKartGiris_CheckedChanged(object sender, EventArgs e)
        {
            //bazı yanlıs yerler
        }

        private void rbKartCıkıs_CheckedChanged(object sender, EventArgs e)
        {
            // //bazı yanlıs yerler
        }

        private void btnkarttak_Click_1(object sender, EventArgs e)
        {
           /*MessageBox.Show("Kartınız Atm'ye takıldı","Takıldı", MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnKartCıkar.Visible = true;
            btnkarttak.Visible = false;
            txtSifregir.Visible = true;
            lbsifregir.Visible = true;
            btnGirisyap.Visible = true;
            karttakıldımı = true;
           pictureBox1.Visible = true;
            */
            
             
            
        }
      bool karttakıldımı = false;
        private void btnKartCıkar_Click_1(object sender, EventArgs e)
        {

             /*btnKartCıkar.Visible = true;
             btnkarttak.Visible = true;
             lbsifregir.Visible = false;
             txtSifregir.Visible = false;
             if (karttakıldımı==false)
             {
                 MessageBox.Show("Kartınızı daha takmadınız ","Takmadın",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }
             else
             {
                 MessageBox.Show("Kartınız Atm'den Çıkarıldı almayı unutmayınız","Kart Çıkarıldı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 karttakıldımı = false;
             }
             pictureBox1.Visible = false;
             }
              */
             
        }

        private void btnKartCıkar_MouseClick(object sender, MouseEventArgs e)
        {
            // //bazı yanlıs yerler
        }

        private void txtSifre_OnValueChanged(object sender, EventArgs e)
        {
            //
        }

        private void ButonKarttak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kartınız Atm'ye takıldı", "Takıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ButonKarttak.Visible = false;
            label2.Visible = true;
            txtSifre.Visible = true;
            btngiris.Visible = true;
            pictureBox2.Visible = true;
            karttakıldımı = true;
            bunifuCustomLabel1.Visible = true;
        }

        private void ButonKartCıkar_Click(object sender, EventArgs e)
        {
            ButonKarttak.Visible = true;
            pictureBox2.Visible = false;
            label2.Visible = false;
            txtSifre.Visible = false;
            btngiris.Visible = false;
            bunifuCustomLabel1.Visible = false;
            if (karttakıldımı==false)
            {
                 MessageBox.Show("Kartınızı daha takmadınız ","Takmadın",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kartınız Atm'den Çıkarıldı almayı unutmayınız", "Kart Çıkarıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                karttakıldımı = false;
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            //
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
             int sifre = Convert.ToInt32(txtSifre.Text);
            if (sifre==3737)
            {
                MessageBox.Show("Giriş Başarılı", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                girdimi = true;
                btngiris.Visible = false;
                label2.Visible = false;
                txtSifre.Visible = false;
                AtmPanel fr2 = new AtmPanel();
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girişi Tespit Edildi", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
