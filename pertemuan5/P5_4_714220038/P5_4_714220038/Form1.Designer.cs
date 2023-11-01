namespace P5_4_714220038
{
    partial class Form1
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
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.Tanggallahir = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.JenisKelamin1 = new System.Windows.Forms.ComboBox();
            this.TanggalWaktu = new System.Windows.Forms.DateTimePicker();
            this.KelasGrupBox = new System.Windows.Forms.GroupBox();
            this.komposer1 = new System.Windows.Forms.CheckBox();
            this.vokal1 = new System.Windows.Forms.CheckBox();
            this.drum1 = new System.Windows.Forms.CheckBox();
            this.piano1 = new System.Windows.Forms.CheckBox();
            this.konduktor1 = new System.Windows.Forms.CheckBox();
            this.gitar1 = new System.Windows.Forms.CheckBox();
            this.saxophone1 = new System.Windows.Forms.CheckBox();
            this.biola1 = new System.Windows.Forms.CheckBox();
            this.GrupJadwalBox = new System.Windows.Forms.GroupBox();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.SelasaKamis = new System.Windows.Forms.RadioButton();
            this.SeninKamis = new System.Windows.Forms.RadioButton();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.KelasGrupBox.SuspendLayout();
            this.GrupJadwalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(373, 53);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(44, 16);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(373, 88);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(90, 16);
            this.JenisKelamin.TabIndex = 1;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // Tanggallahir
            // 
            this.Tanggallahir.AutoSize = true;
            this.Tanggallahir.Location = new System.Drawing.Point(373, 134);
            this.Tanggallahir.Name = "Tanggallahir";
            this.Tanggallahir.Size = new System.Drawing.Size(90, 16);
            this.Tanggallahir.TabIndex = 2;
            this.Tanggallahir.Text = "Tanggal Lahir";
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(555, 47);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(299, 22);
            this.textnama.TabIndex = 3;
            // 
            // JenisKelamin1
            // 
            this.JenisKelamin1.FormattingEnabled = true;
            this.JenisKelamin1.Items.AddRange(new object[] {
            "Pria ",
            "Wanita"});
            this.JenisKelamin1.Location = new System.Drawing.Point(555, 85);
            this.JenisKelamin1.Name = "JenisKelamin1";
            this.JenisKelamin1.Size = new System.Drawing.Size(299, 24);
            this.JenisKelamin1.TabIndex = 4;
            // 
            // TanggalWaktu
            // 
            this.TanggalWaktu.Location = new System.Drawing.Point(555, 129);
            this.TanggalWaktu.Name = "TanggalWaktu";
            this.TanggalWaktu.Size = new System.Drawing.Size(297, 22);
            this.TanggalWaktu.TabIndex = 5;
            // 
            // KelasGrupBox
            // 
            this.KelasGrupBox.BackgroundImage = global::P5_4_714220038.Properties.Resources.img0_3840x2160;
            this.KelasGrupBox.Controls.Add(this.komposer1);
            this.KelasGrupBox.Controls.Add(this.vokal1);
            this.KelasGrupBox.Controls.Add(this.drum1);
            this.KelasGrupBox.Controls.Add(this.piano1);
            this.KelasGrupBox.Controls.Add(this.konduktor1);
            this.KelasGrupBox.Controls.Add(this.gitar1);
            this.KelasGrupBox.Controls.Add(this.saxophone1);
            this.KelasGrupBox.Controls.Add(this.biola1);
            this.KelasGrupBox.Location = new System.Drawing.Point(31, 206);
            this.KelasGrupBox.Name = "KelasGrupBox";
            this.KelasGrupBox.Size = new System.Drawing.Size(415, 208);
            this.KelasGrupBox.TabIndex = 6;
            this.KelasGrupBox.TabStop = false;
            this.KelasGrupBox.Text = "Pilih Kelas";
            this.KelasGrupBox.Enter += new System.EventHandler(this.Kelas_Grup_Enter);
            // 
            // komposer1
            // 
            this.komposer1.AutoSize = true;
            this.komposer1.Location = new System.Drawing.Point(253, 161);
            this.komposer1.Name = "komposer1";
            this.komposer1.Size = new System.Drawing.Size(91, 20);
            this.komposer1.TabIndex = 7;
            this.komposer1.Text = "Komposer";
            this.komposer1.UseVisualStyleBackColor = true;
            // 
            // vokal1
            // 
            this.vokal1.AutoSize = true;
            this.vokal1.Location = new System.Drawing.Point(253, 110);
            this.vokal1.Name = "vokal1";
            this.vokal1.Size = new System.Drawing.Size(64, 20);
            this.vokal1.TabIndex = 6;
            this.vokal1.Text = "Vokal";
            this.vokal1.UseVisualStyleBackColor = true;
            // 
            // drum1
            // 
            this.drum1.AutoSize = true;
            this.drum1.Location = new System.Drawing.Point(253, 65);
            this.drum1.Name = "drum1";
            this.drum1.Size = new System.Drawing.Size(61, 20);
            this.drum1.TabIndex = 5;
            this.drum1.Text = "Drum";
            this.drum1.UseVisualStyleBackColor = true;
            // 
            // piano1
            // 
            this.piano1.AutoSize = true;
            this.piano1.Location = new System.Drawing.Point(253, 23);
            this.piano1.Name = "piano1";
            this.piano1.Size = new System.Drawing.Size(64, 20);
            this.piano1.TabIndex = 4;
            this.piano1.Text = "Piano";
            this.piano1.UseVisualStyleBackColor = true;
            // 
            // konduktor1
            // 
            this.konduktor1.AutoSize = true;
            this.konduktor1.Location = new System.Drawing.Point(16, 161);
            this.konduktor1.Name = "konduktor1";
            this.konduktor1.Size = new System.Drawing.Size(89, 20);
            this.konduktor1.TabIndex = 3;
            this.konduktor1.Text = "Konduktor";
            this.konduktor1.UseVisualStyleBackColor = true;
            // 
            // gitar1
            // 
            this.gitar1.AutoSize = true;
            this.gitar1.Location = new System.Drawing.Point(16, 110);
            this.gitar1.Name = "gitar1";
            this.gitar1.Size = new System.Drawing.Size(57, 20);
            this.gitar1.TabIndex = 2;
            this.gitar1.Text = "Gitar";
            this.gitar1.UseVisualStyleBackColor = true;
            // 
            // saxophone1
            // 
            this.saxophone1.AutoSize = true;
            this.saxophone1.Location = new System.Drawing.Point(16, 65);
            this.saxophone1.Name = "saxophone1";
            this.saxophone1.Size = new System.Drawing.Size(105, 20);
            this.saxophone1.TabIndex = 1;
            this.saxophone1.Text = "Saxsophone";
            this.saxophone1.UseVisualStyleBackColor = true;
            // 
            // biola1
            // 
            this.biola1.AutoSize = true;
            this.biola1.Location = new System.Drawing.Point(16, 22);
            this.biola1.Name = "biola1";
            this.biola1.Size = new System.Drawing.Size(60, 20);
            this.biola1.TabIndex = 0;
            this.biola1.Text = "Biola";
            this.biola1.UseVisualStyleBackColor = true;
            // 
            // GrupJadwalBox
            // 
            this.GrupJadwalBox.BackgroundImage = global::P5_4_714220038.Properties.Resources.img0_3840x2160;
            this.GrupJadwalBox.Controls.Add(this.Minggu);
            this.GrupJadwalBox.Controls.Add(this.SabtuMinggu);
            this.GrupJadwalBox.Controls.Add(this.SelasaKamis);
            this.GrupJadwalBox.Controls.Add(this.SeninKamis);
            this.GrupJadwalBox.Location = new System.Drawing.Point(619, 206);
            this.GrupJadwalBox.Name = "GrupJadwalBox";
            this.GrupJadwalBox.Size = new System.Drawing.Size(493, 208);
            this.GrupJadwalBox.TabIndex = 7;
            this.GrupJadwalBox.TabStop = false;
            this.GrupJadwalBox.Text = "Pilih Jadwal";
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(47, 161);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(141, 20);
            this.Minggu.TabIndex = 3;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu 13.00-17.00";
            this.Minggu.UseVisualStyleBackColor = true;
            // 
            // SabtuMinggu
            // 
            this.SabtuMinggu.AutoSize = true;
            this.SabtuMinggu.Location = new System.Drawing.Point(47, 110);
            this.SabtuMinggu.Name = "SabtuMinggu";
            this.SabtuMinggu.Size = new System.Drawing.Size(188, 20);
            this.SabtuMinggu.TabIndex = 2;
            this.SabtuMinggu.TabStop = true;
            this.SabtuMinggu.Text = "Sabtu & Minggu, 09.00- 11.00";
            this.SabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // SelasaKamis
            // 
            this.SelasaKamis.AutoSize = true;
            this.SelasaKamis.Location = new System.Drawing.Point(47, 64);
            this.SelasaKamis.Name = "SelasaKamis";
            this.SelasaKamis.Size = new System.Drawing.Size(186, 20);
            this.SelasaKamis.TabIndex = 1;
            this.SelasaKamis.TabStop = true;
            this.SelasaKamis.Text = "Selasa & Kamis, 14.00-16.00";
            this.SelasaKamis.UseVisualStyleBackColor = true;
            // 
            // SeninKamis
            // 
            this.SeninKamis.AutoSize = true;
            this.SeninKamis.Location = new System.Drawing.Point(47, 22);
            this.SeninKamis.Name = "SeninKamis";
            this.SeninKamis.Size = new System.Drawing.Size(171, 20);
            this.SeninKamis.TabIndex = 0;
            this.SeninKamis.TabStop = true;
            this.SeninKamis.Text = "Senin Kamis 14.00-16.00";
            this.SeninKamis.UseVisualStyleBackColor = true;
            // 
            // Tampilkan
            // 
            this.Tampilkan.Location = new System.Drawing.Point(388, 484);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(105, 24);
            this.Tampilkan.TabIndex = 8;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = true;
            this.Tampilkan.Click += new System.EventHandler(this.button1_Click);
            // 
            // Selesai
            // 
            this.Selesai.Location = new System.Drawing.Point(588, 484);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(106, 24);
            this.Selesai.TabIndex = 9;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = true;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P5_4_714220038.Properties.Resources.FrMboRraUAA5_f_;
            this.ClientSize = new System.Drawing.Size(1162, 586);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.GrupJadwalBox);
            this.Controls.Add(this.KelasGrupBox);
            this.Controls.Add(this.TanggalWaktu);
            this.Controls.Add(this.JenisKelamin1);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.Tanggallahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.Text = "Form Pendaftaran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KelasGrupBox.ResumeLayout(false);
            this.KelasGrupBox.PerformLayout();
            this.GrupJadwalBox.ResumeLayout(false);
            this.GrupJadwalBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label Tanggallahir;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.ComboBox JenisKelamin1;
        private System.Windows.Forms.DateTimePicker TanggalWaktu;
        private System.Windows.Forms.GroupBox KelasGrupBox;
        private System.Windows.Forms.CheckBox komposer1;
        private System.Windows.Forms.CheckBox vokal1;
        private System.Windows.Forms.CheckBox drum1;
        private System.Windows.Forms.CheckBox piano1;
        private System.Windows.Forms.CheckBox konduktor1;
        private System.Windows.Forms.CheckBox gitar1;
        private System.Windows.Forms.CheckBox saxophone1;
        private System.Windows.Forms.CheckBox biola1;
        private System.Windows.Forms.GroupBox GrupJadwalBox;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.RadioButton SabtuMinggu;
        private System.Windows.Forms.RadioButton SelasaKamis;
        private System.Windows.Forms.RadioButton SeninKamis;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Selesai;
    }
}

