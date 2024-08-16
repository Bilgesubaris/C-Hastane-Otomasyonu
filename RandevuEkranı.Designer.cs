namespace HastaneOtomasyonu
{
    partial class RandevuEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGöster = new System.Windows.Forms.Button();
            this.btnAl = new System.Windows.Forms.Button();
            this.txtUzman = new System.Windows.Forms.TextBox();
            this.dtmTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Randevu Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Randevu Saati:";
            // 
            // btnGöster
            // 
            this.btnGöster.BackColor = System.Drawing.Color.Salmon;
            this.btnGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGöster.Location = new System.Drawing.Point(3, 262);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(157, 43);
            this.btnGöster.TabIndex = 4;
            this.btnGöster.Text = "Randevuları Görüntüle";
            this.btnGöster.UseVisualStyleBackColor = false;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // btnAl
            // 
            this.btnAl.BackColor = System.Drawing.Color.Salmon;
            this.btnAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAl.Location = new System.Drawing.Point(171, 262);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(157, 43);
            this.btnAl.TabIndex = 5;
            this.btnAl.Text = "Randevular Oluştur";
            this.btnAl.UseVisualStyleBackColor = false;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // txtUzman
            // 
            this.txtUzman.Location = new System.Drawing.Point(171, 97);
            this.txtUzman.Name = "txtUzman";
            this.txtUzman.Size = new System.Drawing.Size(145, 20);
            this.txtUzman.TabIndex = 6;
            // 
            // dtmTarih
            // 
            this.dtmTarih.Location = new System.Drawing.Point(172, 160);
            this.dtmTarih.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtmTarih.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtmTarih.Name = "dtmTarih";
            this.dtmTarih.Size = new System.Drawing.Size(145, 20);
            this.dtmTarih.TabIndex = 8;
            this.dtmTarih.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbSaat.Location = new System.Drawing.Point(171, 191);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(145, 21);
            this.cmbSaat.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 523);
            this.dataGridView1.TabIndex = 10;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Fizyoterapi",
            "Genel Cerrahi",
            "Kalp ve Damar Cerrahisi",
            "Beyin Cerrahisi",
            "Dahiliye",
            "Nöroloji",
            "Cildiye",
            "Çocuk Hastalıkları",
            "Çocuk Cerrahisi",
            "Gastroentoloji",
            "Radyoloji",
            "Kadın Hastalıkları",
            "Kulak Burun Boğaz",
            "Üroloji",
            "Kadın Doğum",
            "Odyoloji"});
            this.cmbBolum.Location = new System.Drawing.Point(172, 126);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(144, 21);
            this.cmbBolum.TabIndex = 11;
            // 
            // btnGeri
            // 
            this.btnGeri.ImageKey = "geri.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(29, 30);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 33);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.png");
            // 
            // RandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(969, 547);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.dtmTarih);
            this.Controls.Add(this.txtUzman);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RandevuEkrani";
            this.Text = "Randevu Ekranı";
            this.Load += new System.EventHandler(this.RandevuEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGöster;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.TextBox txtUzman;
        private System.Windows.Forms.DateTimePicker dtmTarih;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}