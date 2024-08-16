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
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            HastaneOtomasyonu fr = new HastaneOtomasyonu();
            fr.Show();
            this.Hide();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select* From Doktorlar where isim=@isim and soyisim =@soyisim and kimlik=@kimlik", baglanti);
                komut.Parameters.AddWithValue("isim", txtİsim.Text);
                komut.Parameters.AddWithValue("soyisim", txtSoyisim.Text);
                komut.Parameters.AddWithValue("kimlik", txtKimlik.Text);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    HastaMuayene fr = new HastaMuayene();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış girdiniz.");
            }
            baglanti.Close();
        }

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {

        }

        private void txtİsim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
