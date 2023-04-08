using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace FormAtm
{
    public partial class paracek : Form
    {
        public paracek()
        {
            InitializeComponent();
        }
        int bakiye=8500;
        int yüz = 100;
        int ucyuz = 300;
        int besyuz = 500;
        int yediyüz = 700;
        int dokuzyüz = 900;
        static System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        public class YetersizBakiye
        {
            public bool YetersizBakiyeKontrol(decimal ihtiyacMiktari, decimal mevcutBakiye)
            {
                if (ihtiyacMiktari > mevcutBakiye)
                {
                    MessageBox.Show("Yeterli bakiyeniz olmadığı için işlem gerçekleştirilemiyor","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ses.Stop();
                    return false;
                }
                else
                {
                    MessageBox.Show("İşleminiz başarılı para içerde hazırlanıyor","Başarılı");
                    ses.SoundLocation = "parasay.wav";
                    ses.Play();
                    return true;
                }
            }
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            YetersizBakiye yb = new YetersizBakiye();
            int yediyuz = 700;
            int mevcutbakiye = bakiye;
            if (yb.YetersizBakiyeKontrol(yüz, mevcutbakiye))
            {

                paracekildimi = true;
                if (paracekildimi == true)
                {
                    Thread.Sleep(8300);
                    MessageBox.Show("Paranınızı başarıyla çekdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yüzdolar.Visible = true;
                    ücyüzdolar.Visible = true;
                    besyuzdolar.Visible = true;
                    yedüyuzdolar.Visible = true;
                    dokuzyüzdolar.Visible = true;
                }
                System.Threading.Thread.Sleep(8300);
                MessageBox.Show("700$ Paranız Hazır Paranızı almayı unutmayın", "Para", MessageBoxButtons.OK);
                bakiye -= yediyuz;
                lblBakiye.Text = bakiye.ToString();
                cebimdekiparam += 700;
            }
        }
        
        private void YetersizBakiyeKontrol(double cekilecekTutar)
        {
            throw new NotImplementedException();
        }
        public static bool dekontaldımı = false;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            YetersizBakiye yb = new YetersizBakiye();
            int ucyuz = 300;
            int mevcutbakiye = bakiye;
            if (yb.YetersizBakiyeKontrol(yüz, mevcutbakiye))
            {

                paracekildimi = true;
                if (paracekildimi == true)
                {
                    Thread.Sleep(8300);
                    MessageBox.Show("Paranınızı başarıyla çekdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yüzdolar.Visible = true;
                    ücyüzdolar.Visible = true;
                    besyuzdolar.Visible = true;
                    yedüyuzdolar.Visible = true;
                    dokuzyüzdolar.Visible = true;
                }
                System.Threading.Thread.Sleep(8300);
                MessageBox.Show("300$ Paranız Hazır Paranızı almayı unutmayın", "Para", MessageBoxButtons.OK);
                bakiye -= ucyuz;
                lblBakiye.Text = bakiye.ToString();
                cebimdekiparam += 300;
            }
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panelcek.Visible = true;
            lblnekadarcek.Visible = true;
            btnonay.Visible = true;
            yüzdolar.Visible = false;
            ücyüzdolar.Visible = false;
            besyuzdolar.Visible = false;
            yedüyuzdolar.Visible = false;
            dokuzyüzdolar.Visible = false;

        }
        private void paracek_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = bakiye.ToString();
            panelcek.Visible = false;
            lblnekadarcek.Visible = false;
            btnonay.Visible = false;
        }
        bool paracekildimi = false;
        private void btnonay_Click(object sender, EventArgs e)
        {
            int cekilecekktutar = Convert.ToInt32(txtmiktar.Text);
            if (cekilecekktutar <= 0)
            {
                MessageBox.Show("Negatif Değer İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            YetersizBakiye yb = new YetersizBakiye();
            int mevcutbakiye = bakiye;
            if (yb.YetersizBakiyeKontrol(cekilecekktutar, mevcutbakiye))
            {
                cebimdekiparam += int.Parse(cekilecekktutar.ToString());
                paracekildimi = true;
                if (paracekildimi == true)
                {
                    Thread.Sleep(8300);
                    MessageBox.Show("Paranınızı başarıyla çekdiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    yüzdolar.Visible = true;
                    ücyüzdolar.Visible = true;
                    besyuzdolar.Visible = true;
                    yedüyuzdolar.Visible = true;
                    dokuzyüzdolar.Visible = true;
                }
                bakiye -= cekilecekktutar;
                lblBakiye.Text = bakiye.ToString();
            }
        }

        private void txtmiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı girilmesini saglar
        }
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            YetersizBakiye yb = new YetersizBakiye();
            int yüz = 100;
            int mevcutbakiye = bakiye;
            if (yb.YetersizBakiyeKontrol(yüz, mevcutbakiye))
            {

                paracekildimi = true;
                if (paracekildimi == true)
                {
                    Thread.Sleep(8300);
                    MessageBox.Show("Paranınızı başarıyla çekdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yüzdolar.Visible = true;
                    ücyüzdolar.Visible = true;
                    besyuzdolar.Visible = true;
                    yedüyuzdolar.Visible = true;
                    dokuzyüzdolar.Visible = true;
                }
                System.Threading.Thread.Sleep(8300);
                MessageBox.Show("100$ Paranız Hazır Paranızı almayı unutmayın", "Para", MessageBoxButtons.OK);
                bakiye -= yüz;
                lblBakiye.Text = bakiye.ToString();
                cebimdekiparam += 100;
            }
            
        }
        private void besyuzdolar_Click(object sender, EventArgs e)
        {
           
            YetersizBakiye yb = new YetersizBakiye();
            int besyuz = 500;
            int mevcutbakiye = bakiye;
            if (yb.YetersizBakiyeKontrol(yüz, mevcutbakiye))
            {

                paracekildimi = true;
                if (paracekildimi == true)
                {
                    Thread.Sleep(8300);
                    MessageBox.Show("Paranınızı başarıyla çekdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yüzdolar.Visible = true;
                    ücyüzdolar.Visible = true;
                    besyuzdolar.Visible = true;
                    yedüyuzdolar.Visible = true;
                    dokuzyüzdolar.Visible = true;
                }
                System.Threading.Thread.Sleep(8300);
                MessageBox.Show("500$ Paranız Hazır Paranızı almayı unutmayın", "Para", MessageBoxButtons.OK);
                bakiye -= besyuz;
                lblBakiye.Text = bakiye.ToString();
                cebimdekiparam += 500;
            }
            
        }

        private void dokuzyüzdolar_Click(object sender, EventArgs e)
        {
            
            YetersizBakiye yb = new YetersizBakiye();
            int dokuzyuz = 900;
            int mevcutbakiye = bakiye;
            if (yb.YetersizBakiyeKontrol(yüz, mevcutbakiye))
            {

                paracekildimi = true;
                if (paracekildimi == true)
                {
                    Thread.Sleep(8300);
                    MessageBox.Show("Paranınızı başarıyla çekdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yüzdolar.Visible = true;
                    ücyüzdolar.Visible = true;
                    besyuzdolar.Visible = true;
                    yedüyuzdolar.Visible = true;
                    dokuzyüzdolar.Visible = true;
                }
                System.Threading.Thread.Sleep(8300);
                MessageBox.Show("900$ Paranız Hazır Paranızı almayı unutmayın", "Para", MessageBoxButtons.OK);
                bakiye -= dokuzyuz;
                lblBakiye.Text = bakiye.ToString();
                cebimdekiparam += 900;
            }
        }
        public double cekilecekTutar { get; set; }
        decimal cebimdekiparam = 0;
        private void btnCebdekipara_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cebimdekiparam.ToString(),"Bakiye Sorgulama",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
