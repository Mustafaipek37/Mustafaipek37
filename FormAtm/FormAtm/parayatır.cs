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
    public partial class parayatır : Form
    {
        public parayatır()
        {
            InitializeComponent();
        }
        int bakiyen = 8500;
        int icbakiyeniz = 0;
       
        private void btnOnayla_Click(object sender, EventArgs e)
        {    
            int yatırılacaktutar = int.Parse(txtyatır.Text);
             int eksigirilmez = Convert.ToInt32(txtyatır.Text);
            if (eksigirilmez <= 0)
            {
                MessageBox.Show("Negatif Değer İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (icbakiyeniz+yatırılacaktutar>bakiyen)
            {
                MessageBox.Show("Yatırılacak değer bakiyenizi aşıyor işlem gerçekleştirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            else
            {
                icbakiyeniz += yatırılacaktutar;
                MessageBox.Show(yatırılacaktutar.ToString() + " TL hesabınıza yatırıldı:");
            }
            
        }

        private void btnBankadakiPara_Click(object sender, EventArgs e)
        {
            MessageBox.Show(icbakiyeniz.ToString()+" "+"TL"+" "+"Nakitiniz Bulunmaktadır.","İçBakiye",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
