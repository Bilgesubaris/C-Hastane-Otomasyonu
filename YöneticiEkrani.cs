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
    public partial class YöneticiEkrani : Form
    {
        public YöneticiEkrani()
        {
            InitializeComponent();
        }

        private void YöneticiEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("SELECT * From Doktorlar");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["isim"].ToString();
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["kimlik"].ToString());
                ekle.SubItems.Add(oku["Bölüm"].ToString());
                    listView1.Items.Add(ekle);

            }
            baglanti.Close();
        } 

        private void btnSekreter_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bilgesu\\Desktop\\HastaneOtomasyonu.mdb");


            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("SELECT * From Sekreterler");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["İsim"].ToString();
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["Kimlik"].ToString());
               
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Yöneticigiris fr = new Yöneticigiris();
            fr.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CalisanEkleme fr1= new CalisanEkleme();
            fr1.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
