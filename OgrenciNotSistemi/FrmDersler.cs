using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL kütüphanesini unutmuyoruz

namespace OgrenciNotSistemi
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        // Veritabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=OkulOtomasyon;Integrated Security=True");

        // Form Açılınca Listele
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // LİSTELEME METODU
        void Listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        // EKLEME BUTONU
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Dersler (DersAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDersAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Eklendi");
            Listele(); // Listeyi yenile
        }

        // SİLME BUTONU
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Dersler where DersID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDersID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Silindi");
            Listele();
        }

        // GÜNCELLEME BUTONU
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Dersler set DersAd=@p1 where DersID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDersAd.Text);
            komut.Parameters.AddWithValue("@p2", txtDersID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Güncellendi");
            Listele();
        }

        // LİSTELE BUTONU (Ekstra basmak istenirse diye)
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // TABLOYA TIKLAYINCA BİLGİLERİ KUTULARA TAŞI (Pratiklik için)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satırın indeksini al
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtDersID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void FrmDersler_Load_1(object sender, EventArgs e)
        {

        }
    }
}