using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaziliOrtalamaHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int yazili1, yazili2;
            double ortalama;
            yazili1=Convert.ToInt32(txtYazili1.Text);
            yazili2=Convert.ToInt32(txtYazili2.Text);
            ortalama=(yazili1+yazili2)/2.0;
            MessageBox.Show("Ortalamanız: " + ortalama);

        }
    }
}
