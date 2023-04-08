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
    public partial class faturaode : Form
    {
        public faturaode()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int su;
        int elektirik;
        int dogalgaz;
        int bakiyen = 1500;
        int odendi;
        int odendi1;
        int odendi2;
        private void faturaode_Load(object sender, EventArgs e)
        {
            lblgelensu.Visible = false;
            lblgelenelektirik.Visible = false;
            lblgelendogalgaz.Visible = false;
            su = rnd.Next(80, 280);
            elektirik = rnd.Next(100, 600);
            dogalgaz = rnd.Next(200, 1200);
            cbsec.AddItem("-----------");//0
            cbsec.AddItem("Elektirik");//1
            cbsec.AddItem("Su");//2
            cbsec.AddItem("Doğalgaz");//3
            lblgelensu.Text = su.ToString();
            lblgelendogalgaz.Text = dogalgaz.ToString();
            lblgelenelektirik.Text = elektirik.ToString();
            lblbakiyen.Text = bakiyen + "TL";
        }

        private void cbsec_onItemSelected(object sender, EventArgs e)
        {
            DialogResult diyalog = new DialogResult();
            if (cbsec.selectedIndex == 0)
            {
                lblgelenelektirik.Visible = false;
                lblgelendogalgaz.Visible = false;
                lblgelensu.Visible = false;
            }
            if (cbsec.selectedIndex == 1)
            {
                if (odendi == 1)
                {
                    MessageBox.Show("Zaten bu faturayı önceden ödemiştiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblgelenelektirik.Visible = true;
                diyalog = MessageBox.Show(elektirik.ToString() + " " + "Liralık Faturanızı Ödemek İstiyormusunuz?", "İstemek", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (diyalog == DialogResult.Yes)
                {
                    if (elektirik > bakiyen)
                    {
                        MessageBox.Show("İşlemi gerçekleştirmek için bakiyeniz bulunmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Faturanızı Ödediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bakiyen -= elektirik;
                        lblbakiyen.Text = bakiyen.ToString() + "TL";
                        odendi = 1;
                    }
                }
            }

            if (cbsec.selectedIndex == 2)
            {
                if (odendi1 == 1)
                {
                    MessageBox.Show("Zaten bu faturayı önceden ödemiştiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblgelensu.Visible = true;
                diyalog = MessageBox.Show(su.ToString() + " " + "Liralık Faturanızı Ödemek İstiyormusunuz?", "İstemek", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (diyalog == DialogResult.Yes)
                {
                    if (su > bakiyen)
                    {
                        MessageBox.Show("İşlemi gerçekleştirmek için bakiyeniz bulunmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Faturanızı Ödediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bakiyen -= su;
                        lblbakiyen.Text = bakiyen.ToString() + "TL";
                        odendi1 = 1;
                    }
                }
            }

            if (cbsec.selectedIndex == 3)
            {
                if (odendi2==1)
                {
                    MessageBox.Show("Zaten bu faturayı önceden ödemiştiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                lblgelendogalgaz.Visible = true;
                diyalog = MessageBox.Show(dogalgaz.ToString() + " " + "Liralık Faturanızı Ödemek İstiyormusunuz?", "İstemek", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (diyalog == DialogResult.Yes)
                {
                    if (dogalgaz > bakiyen)
                    {
                        MessageBox.Show("İşlemi gerçekleştirmek için bakiyeniz bulunmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Faturanızı Ödediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bakiyen -= dogalgaz;
                        lblbakiyen.Text = bakiyen.ToString();
                        odendi2 = 1;
                        
                    }
                }
            }
        }
    }
}