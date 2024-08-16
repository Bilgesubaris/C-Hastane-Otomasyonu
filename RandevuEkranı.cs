using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HastaneOtomasyonu
{
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }

        private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        void KisileriListele1()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT* FROM Randevular1", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        
        private void btnGöster_Click(object sender, EventArgs e)
        {
            KisileriListele1();

            //baglanti.Open();
            //String sorgu = "INSERT INTO Randevular1(Uzman,Bölüm,RandevuTarihi,RandevuSaati) values (@uzman,@bolum,@tarih,@saat)";
            //komut = new OleDbCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@uzman", txtUzman.Text);
            //komut.Parameters.AddWithValue("@bolum", cmbBolum.Text);
            //komut.Parameters.AddWithValue("@tarih", dtmTarih.Text);
            //komut.Parameters.AddWithValue("@saat", cmbSaat.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //KisileriListele();

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select* From RandevuAl where  uzman=@uzman and bölüm=@bolum and randevutarihi=@tarih and randevusaati=@saat", baglanti);

                komut.Parameters.AddWithValue("@uzman", txtUzman.Text);
                komut.Parameters.AddWithValue("@bolum", cmbBolum.Text);
                komut.Parameters.AddWithValue("@tarih", dtmTarih.Text);
                komut.Parameters.AddWithValue("@saat", cmbSaat.Text);

                da = new OleDbDataAdapter("SELECT* FROM RandevuAl ", baglanti);
               
            
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
           
              
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            HastaGiris fr = new HastaGiris();
            fr.Show();
            this.Hide();
        }
    }
}
