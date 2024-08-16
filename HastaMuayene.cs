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
    public partial class HastaMuayene : Form
    {
        public HastaMuayene()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            DoktorEkrani fr =new DoktorEkrani();
            fr.Show();
            this.Hide();
        }

        private void HastaMuayene_Load(object sender, EventArgs e)
        {
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select* From HastaBak where isim=@isim and sikayet=@sikayet and kimlik=@kimlik and tedavi=@tedavi", baglanti);
            komut.Parameters.AddWithValue("isim", txtSoyisim.Text);
            komut.Parameters.AddWithValue("soyisim", txtSoyisim.Text);
            komut.Parameters.AddWithValue("sikayet", txtSikayet.Text);
            komut.Parameters.AddWithValue("tedavi", cmbTedavi.Text);
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 5000);
            txtRecete.Text = Convert.ToString(sayi);
        }

        private void txtRecete_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
