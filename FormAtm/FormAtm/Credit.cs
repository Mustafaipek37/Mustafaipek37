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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.doviz.com/makale/kredi-cekmek-icin-gereken-sartlar/152");
        }

        private void Credit_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtmPanel a2 = new AtmPanel();
            a2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
