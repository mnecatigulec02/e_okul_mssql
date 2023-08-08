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
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();

        private void Dersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAD.Text);
            MessageBox.Show("Ders Eklendi.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(Convert.ToInt32(txtDersID.Text));
            MessageBox.Show("Ders Silindi.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtDersAD.Text, Convert.ToInt32(txtDersID.Text));
            MessageBox.Show("Ders Güncellendi.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
