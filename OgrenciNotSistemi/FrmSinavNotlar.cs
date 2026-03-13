using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // 1. KÜTÜPHANEYİ UNUTMA

namespace OgrenciNotSistemi
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=OkulOtomasyon;Integrated Security=True");

        void Listele()
        {

            baglanti.Open();
  
            SqlCommand komut = new SqlCommand(@"Select 
        NotID,
        AdSoyad as 'Ad Soyad',
        DersAd as 'Ders',
        Vize,
        Final,
        Ortalama,
        Durum
        From Tbl_Notlar 
        INNER JOIN tbl_Ogrenciler ON Tbl_Notlar.OgrenciID = tbl_Ogrenciler.OgrenciID
        INNER JOIN Tbl_Dersler ON Tbl_Notlar.DersID = Tbl_Dersler.DersID", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            // Form açılınca listeyi getir
            // Şu an liste BOŞ gelecek çünkü hiç not girmedik, ama başlıklar gelmeli.
            //Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSinavNotlar_Load_1(object sender, EventArgs e)
        {
           Listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblOgrenciEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            FrmNotEkle fr = new FrmNotEkle();
            fr.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}