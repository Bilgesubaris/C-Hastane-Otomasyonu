﻿using System;
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
    public partial class FormYükleme : Form
    {
        public FormYükleme()
        {
            InitializeComponent();
        }

        private void FormYükleme_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
                HastaneOtomasyonu fr = new HastaneOtomasyonu();
                fr.Show();
                this.Hide();
            }
        }
    }
}
