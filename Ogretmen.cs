using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_okul_mssql
{
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }

        private void btnDersİslemleri_Click(object sender, EventArgs e)
        {
            Dersler drsler = new Dersler();
            drsler.Show();
        }

        private void btnKulupIslemleri_Click(object sender, EventArgs e)
        {
            KulupIslemleri klpIslemleri = new KulupIslemleri();
            klpIslemleri.Show();
            
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Show();
            this.Hide();
        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
            SinavNotlari snvnot = new SinavNotlari();
            snvnot.Show();
        }
    }
}
