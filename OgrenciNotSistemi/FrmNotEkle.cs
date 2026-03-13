using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FrmNotEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=OkulOtomasyon;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
        public FrmNotEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void FrmNotEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;

            // TextBox'lardan değerleri alıp sayıya çeviriyoruz
            // Hata almamak için try-catch bloğu veya double.TryParse kullanılabilir ama şimdilik temel mantığı yazıyorum.
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);

            // Üniversite geneli ortalama hesabı: Vize %40 + Final %60
            ortalama = (vize * 0.4) + (final * 0.6);

            // Ortalamayı yazdır
            txtOrtalama.Text = ortalama.ToString("0.00"); // Virgülden sonra 2 hane gösterir

            // Geçme Kalma Durumu
            if (ortalama >= 50)
            {
                txtDurum.Text = "Geçti";
                txtDurum.BackColor = Color.Green; // Görsel ipucu
                txtDurum.ForeColor = Color.White;
            }
            else
            {
                txtDurum.Text = "Kaldı";
                txtDurum.BackColor = Color.Red;
                txtDurum.ForeColor = Color.White;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)

        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Notlar (OgrenciID, DersID, Vize, Final, Ortalama, Durum) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);

            // ComboBox'tan seçilen gizli ID'leri alıyoruz
            komut.Parameters.AddWithValue("@p1", cmbOgrenci.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbDers.SelectedValue);

            komut.Parameters.AddWithValue("@p3", txtVize.Text);
            komut.Parameters.AddWithValue("@p4", txtFinal.Text);

            // Hesaplama ve Durum (Önceki mesajlarımızdaki gibi)
            double ort = (Convert.ToDouble(txtVize.Text) + Convert.ToDouble(txtFinal.Text)) / 2;
            komut.Parameters.AddWithValue("@p5", ort);
            komut.Parameters.AddWithValue("@p6", ort >= 50 ? "Geçti" : "Kaldı");

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Not başarıyla kaydedildi!");
        }
    }
}
