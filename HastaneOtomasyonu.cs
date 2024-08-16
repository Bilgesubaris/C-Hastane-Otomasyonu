using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HastaneOtomasyonu : Form
    {
        public HastaneOtomasyonu()
        {
            InitializeComponent();
        }

        private void HastaneOtomasyonu_Load(object sender, EventArgs e)
        {

        }
  

        private void btnSekreter_Click_1(object sender, EventArgs e)
        {
            SekreterEkrani fr = new SekreterEkrani();
            fr.Show();
            this.Hide();
        }

        private void btnYonetici_Click_1(object sender, EventArgs e)
        {

            Yöneticigiris fr1 = new Yöneticigiris();
            fr1.Show();
            this.Hide();
        }

        private void btnDoktor_Click_1(object sender, EventArgs e)
        {

            DoktorEkrani fr1 = new DoktorEkrani();
            fr1.Show();
            this.Hide();
        }

        private void ekranlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sekreterGirişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SekreterEkrani fr2 = new SekreterEkrani();
            fr2.Show();
            this.Hide();
        }

        private void doktorGirişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorEkrani fr3= new DoktorEkrani();
            fr3.Show();
            this.Hide();
        }

        private void yöneticiGirişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yöneticigiris fr4 = new Yöneticigiris();
            fr4.Show();
            this.Hide();
        }
    }
}
