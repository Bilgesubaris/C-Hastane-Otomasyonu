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
using System.Diagnostics.Eventing.Reader;

namespace HastaneOtomasyonu
{
    public partial class Yöneticigiris : Form
    {
        public Yöneticigiris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select* From Yönetici where isim=@isim and kimlik=@kimlik", baglanti);
                komut.Parameters.AddWithValue("isim", txtİsim.Text);
                komut.Parameters.AddWithValue("kimlik", txtSifre.Text);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    YöneticiEkrani fr = new YöneticiEkrani();
                    fr.Show();
                    this.Hide();
                }
            }
                catch (Exception ) {
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

        private void Yöneticigiris_Load(object sender, EventArgs e)
        {

        }
    }
}
