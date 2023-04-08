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
    public partial class paragonder : Form
    {
        public paragonder()
        {
            InitializeComponent();
        }
        int bakiyen = 5200;

        private void paragonder_Load(object sender, EventArgs e)
        {            
            lblbakiye.Text = bakiyen.ToString() + "TL";
            btngonder.Visible = false;
            bunifuCustomLabel2.Visible = false;
            label3.Visible = false;
            lblbakiye.Visible = false;
            txtMiktar.Visible = false;
            lstKayitlar.Visible = false;
            btnarşiv.Visible = false;
        }

        private void cbibanyaz_OnChange(object sender, EventArgs e)
        {
            int iban = Convert.ToInt32(txtiban.text);
            if (iban == 0)
            {
                MessageBox.Show("Geçersiz iban geçerli iban girmeyi deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (iban == 0123456789)
            {
                cbibanyaz.Visible = false;
                btngonder.Visible = true;
                bunifuCustomLabel2.Visible = true;
                label3.Visible = true;
                lblbakiye.Visible = true;
                txtMiktar.Visible = true;
                btnarşiv.Visible = true;
                txtiban.Text="";
            }
            else
            {
                MessageBox.Show("Geçersiz iban geçerli iban girmeyi deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            double gidenparaToplam = 0.0;
            int gidenpara = Convert.ToInt32(txtMiktar.Text);
            if (gidenpara <= 0)
            {
                MessageBox.Show("Negatif Değer İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gidenpara > bakiyen)
            {
                MessageBox.Show("Yetersiz Bakiye", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                gidenparaToplam += gidenpara;
                bakiyen -= gidenpara;
                lblbakiye.Text = bakiyen.ToString();
                MessageBox.Show("Para başarıyla gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "Tarih" +" "+ DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " Gönderilen Para" + gidenpara.ToString("C2");
                lstKayitlar.Items.Add(kayit);
                lstKayitlar.Font = new Font("Arial", 9, FontStyle.Bold);
            }
        }

        private void btnarşiv_Click(object sender, EventArgs e)
        {
            lstKayitlar.Visible = true;
        }
        }
    }

