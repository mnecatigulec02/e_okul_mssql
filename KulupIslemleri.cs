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
    public partial class KulupIslemleri : Form
    {
        public KulupIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PVEILPL;Initial Catalog=DB_E_Okul;Integrated Security=True");
        public void KulupListele() 
        {
            baglanti.Open();
            SqlCommand kmtKulupListele = new SqlCommand("Select * from Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmtKulupListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void KulupIslemleri_Load(object sender, EventArgs e)
        {
            KulupListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KulupListele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtKulupEkle = new SqlCommand("insert into Tbl_Kulupler (KulupAd) values (@p1)", baglanti);
            kmtKulupEkle.Parameters.AddWithValue("@p1", txtKulupAD.Text);
            kmtKulupEkle.ExecuteNonQuery();
            baglanti.Close();
            KulupListele();
            
            MessageBox.Show("Kulüp listeye eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtKulupSil = new SqlCommand("Delete from Tbl_Kulupler where Kulupid=@k1;",baglanti);
            kmtKulupSil.Parameters.AddWithValue("@k1", txtKulupID.Text);
            kmtKulupSil.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Kulüp Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            KulupListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtKulupGuncelle = new SqlCommand("Update Tbl_Kulupler set KulupAd=@p1 where Kulupid=@p2;",baglanti);
            kmtKulupGuncelle.Parameters.AddWithValue("@p2", txtKulupID.Text);
            kmtKulupGuncelle.Parameters.AddWithValue("@p1", txtKulupAD.Text);
            kmtKulupGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KulupListele();
        }
    }
}
