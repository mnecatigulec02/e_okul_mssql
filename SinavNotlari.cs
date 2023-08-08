using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_okul_mssql
{
    public partial class SinavNotlari : Form
    {
        public SinavNotlari()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter dsNot = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PVEILPL;Initial Catalog=DB_E_Okul;Integrated Security=True");
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsNot.NotListesi(int.Parse(txtOgrID.Text));
        }
        

        private void SinavNotlari_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komutNotGetir = new SqlCommand("Select * from Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutNotGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.ValueMember = "DERSID";
            cmbDers.DataSource = dt;
            baglanti.Close();
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOgrID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinav2.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSinav3.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrtalama.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            sinav1 = Convert.ToInt32(txtSinav1.Text);
            sinav2 = Convert.ToInt32(txtSinav2.Text);
            sinav3 = Convert.ToInt32(txtSinav3.Text);
            proje = Convert.ToInt32(txtProje.Text);
            ortalama = (sinav1+sinav2+sinav3+proje)/4;
            txtOrtalama.Text = Convert.ToString(ortalama);
            if (ortalama>=50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text= "False";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dsNot.NotGuncelle(int.Parse(cmbDers.SelectedValue.ToString()),int.Parse(txtOgrID.Text),sinav1,sinav2,sinav3,proje,decimal.Parse(txtOrtalama.Text),bool.Parse(txtDurum.Text),notid);
        }
    }
}
