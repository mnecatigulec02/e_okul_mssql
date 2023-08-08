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
    public partial class OgrenciNotlar : Form
    {
        public OgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PVEILPL;Initial Catalog=DB_E_Okul;Integrated Security=True");
        public string numara;
        private void OgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();  
            SqlCommand kmtOgrAdGetir = new SqlCommand("Select OgrAd,OgrSoyad from Tbl_Ogrenciler where Ogrid=@n1",baglanti);
            kmtOgrAdGetir.Parameters.AddWithValue("@n1", numara);
            SqlDataReader drAdSoyadGetir = kmtOgrAdGetir.ExecuteReader();
            while (drAdSoyadGetir.Read())
            {
                this.Text = drAdSoyadGetir[0] + " " + drAdSoyadGetir[1];
            }
            baglanti.Close();
            SqlCommand kmtNotlarTablosunuGetir = new SqlCommand("Select DersAd,Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.Dersid=Tbl_Dersler.Dersid where Ogrid=@n1;", baglanti);
            kmtNotlarTablosunuGetir.Parameters.AddWithValue("@n1", numara);
            
            SqlDataAdapter da = new SqlDataAdapter(kmtNotlarTablosunuGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
