using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FormAtm
{
    public partial class AtmPanel : Form
    {
        public AtmPanel()
        {
            InitializeComponent();
        }

        private void AtmPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //
        }

        private void krediŞartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Sadece Bir Gösteridir Kredi Çekmek İçin Bankamızı Ziyaret Edin","Kredi İçin Bankaya Gelin",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Credit cr1 = new Credit();
            cr1.Show();
            this.Hide();
        }

        private void AtmPanel_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Kartınız Atm'den Çıkarıldı almayı unutmayınız", "Kart Çıkarıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(900);
            Application.Exit();
        }
        paracek pcek = new paracek();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pgonder.Visible = false;
            fode.Visible = false;
            pyatır.Visible = false;
            pcek.MdiParent = this;
            pcek.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(pcek);
            pcek.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }
        parayatır pyatır = new parayatır();
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pgonder.Visible = false;
            pcek.Visible = false;
            fode.Visible = false;
            pyatır.MdiParent = this;
            pyatır.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(pyatır);
            pyatır.Show();
        }
        faturaode fode = new faturaode();
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            pgonder.Visible = false;
            pcek.Visible = false;
            pyatır.Visible = false;
            fode.MdiParent = this;
            fode.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(fode);
            fode.Show();
        }
        paragonder pgonder = new paragonder();
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pcek.Visible = false;
            pyatır.Visible = false;
            fode.Visible = false;
            pgonder.MdiParent = this;
            pgonder.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(pgonder);
            pgonder.Show();
        }
    }
}
