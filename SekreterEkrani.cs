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
    public partial class SekreterEkrani : Form
    {
        public SekreterEkrani()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");



        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select* From Sekreterler where isim=@isim and soyisim =@soyisim and kimlik=@kimlik", baglanti);
                komut.Parameters.AddWithValue("isim", textBox1.Text);
                komut.Parameters.AddWithValue("soyisim",txtSoyisim.Text);
                komut.Parameters.AddWithValue("kimlik", txtSifre.Text);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    HastaGiris fr1 = new HastaGiris();
                    fr1.Show();
                    this.Hide();

                }
            }
           catch(Exception)
            {
                MessageBox.Show("Yanlış girdiniz.");
            }
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            HastaneOtomasyonu fr = new HastaneOtomasyonu();
            fr.Show();
            this.Hide();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void SekreterEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
