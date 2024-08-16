using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HastaneOtomasyonu
{
    public partial class CalisanEkleme : Form
    {
        public CalisanEkleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         void KisileriListele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT* FROM Çalışanlar", baglanti);
            DataTable tablo = new DataTable();   
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
           String sorgu = "INSERT INTO Çalışanlar(İsim,Soyisim,Kimlik,Bölüm) values (@isim,@soyisim,@kimlik,@bölüm)";
            komut = new OleDbCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@isim", txtİsim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
            komut.Parameters.AddWithValue("@kimlik", txtKimlik.Text); 
            komut.Parameters.AddWithValue("@bölüm", txtBölüm.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            KisileriListele();


        }

        private void CalisanEkleme_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }

        private void btnSekreterEkle_Click(object sender, EventArgs e)
        {

            String sorgu = "INSERT INTO Çalışanlar(İsim,Soyisim,Kimlik) values (@isim,@soyisim,@kimlik)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim", txtİsim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
            komut.Parameters.AddWithValue("@kimlik", txtKimlik.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE* FROM Çalışanlar WHERE id= @id";
         komut = new OleDbCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
           baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            KisileriListele();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YöneticiEkrani fr = new YöneticiEkrani();
            fr.Show();
            this.Hide();
        }
    }
}
