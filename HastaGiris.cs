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

namespace HastaneOtomasyonu
{
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }

        private void txtİsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select* From HastaBilgileri where isim=@isim and soyisim=@soyisim and kimlik=@kimlik and dogumtarihi=@dogumtarihi and telno=@telno and cinsiyet =@cinsiyet", baglanti);
                komut.Parameters.AddWithValue("isim", txtİsim.Text);
                komut.Parameters.AddWithValue("soyisim", txtSoyisim.Text);
                komut.Parameters.AddWithValue("kimlik", txtKimlik.Text);
                komut.Parameters.AddWithValue("DoğumTarihi", dtpDogum.Text);
                komut.Parameters.AddWithValue("TelNo",txtTel.Text);
                komut.Parameters.AddWithValue("Cinsiyet", cmbCinsiyet.Text);
               
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                   RandevuEkrani fr = new RandevuEkrani();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception )
            {
                MessageBox.Show("Yanlış girdiniz.");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SekreterEkrani fr = new SekreterEkrani();   
            fr.Show();
            this.Hide();
        }

        private void HastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKimlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

