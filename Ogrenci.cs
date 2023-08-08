using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_okul_mssql
{
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds2 = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PVEILPL;Initial Catalog=DB_E_Okul;Integrated Security=True");

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.OgrenciListesi();
            baglanti.Open();
            SqlCommand komutKulupGetir = new SqlCommand("Select * from Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutKulupGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulup.DisplayMember = "KulupAd";
            cmbKulup.ValueMember = "Kulupid";
            cmbKulup.DataSource = dt;
            baglanti.Close();
        }
        string c = "";

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (radioButtonKiz.Checked==true)
            {
                c = "Kız";
            }
            if (radioButtonErkek.Checked==true)
            {
                c = "Erkek";
            }
            ds2.OgrenciEkle(txtOgrAd.Text, txtOgrSoyad.Text, Convert.ToInt32(cmbKulup.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci ekleme işlemi yapıldı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = ds2.OgrenciListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.OgrenciListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds2.OgrenciSil(Convert.ToInt32(txtOgrID.Text));
            dataGridView1.DataSource = ds2.OgrenciListesi();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds2.OgrenciGuncelle(txtOgrAd.Text, txtOgrSoyad.Text, Convert.ToInt32(cmbKulup.SelectedValue.ToString()), c,int.Parse(txtOgrID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOgrAd.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgrSoyad.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKulup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek")
            {
                radioButtonErkek.Checked = true;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() =="Kadın")
            {
                radioButtonKiz.Checked = true;
            }
        }

        private void radioButtonKiz_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKiz.Checked)
            {
                c = "Kız";
            }
        }

        private void radioButtonErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonErkek.Checked)
            {
                c = "Erkek";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.OgrenciBul(txtBoxAra.Text);
        }
    }
}
