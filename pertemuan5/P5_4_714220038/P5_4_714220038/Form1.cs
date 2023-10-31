using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GrupKelasBox = "";
            string GrupJadwalBox = "";
            DateTime tanggalaja = TanggalWaktu.Value;
            string tanggalaja2 = tanggalaja.ToString("dd - MMMM - yyyy");
            string JenisKelamin = JenisKelamin1.GetItemText(JenisKelamin1.SelectedItem);


            //Group Kelas Box Musik
            if (biola1.Checked)
            {
                GrupKelasBox = "Biola, ";
            }
            if (saxophone1.Checked)
            {
                GrupKelasBox = "Saxophone, ";
            }
            if (gitar1.Checked)
            {
                GrupKelasBox = "Gitar1, ";
            }
            if (konduktor1.Checked)
            {
                GrupKelasBox = "Konduktor, ";
            }
            if (piano1.Checked)
            {
                GrupKelasBox = "Piano, ";
            }
            if (drum1.Checked)
            {
                GrupKelasBox = "Drum, ";
            }
            if (vokal1.Checked)
            {
                GrupKelasBox = "Vokal, ";
            }
            if (komposer1.Checked)
            {
                GrupKelasBox = "Komposer, ";
            }

            if (!string.IsNullOrEmpty(GrupKelasBox))
            {
                GrupKelasBox = GrupKelasBox.TrimEnd(' ', ',');
            }
            //Group Pilihan Waktu

            if (SeninKamis.Checked)
            {
                GrupJadwalBox = "Senin-Kamis, 14.00 - 16.00";
            }
            else if (SelasaKamis.Checked)
            {
                GrupJadwalBox = "Selasa-Kamis, 14.00 - 16.00";
            }
            else if (SabtuMinggu.Checked)
            {
                GrupJadwalBox = "Sabtu-Minggu, 09.00-11.00";
            }
            else if (Minggu.Checked)
            {
                GrupJadwalBox = "Minggu, 13.00 - 19.00";
            }
            if (GrupKelasBox != "" && GrupJadwalBox != "")
            {
                MessageBox.Show("Nama : " + textnama.Text + "\nJenis Kelamin : " + JenisKelamin + "\nTanggal Lahir : " + tanggalaja2 + "\nPilihan Kelas : " + GrupKelasBox + "\nPilihan Jadwal : " + GrupJadwalBox, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textnama.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (JenisKelamin == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (GrupKelasBox == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (GrupJadwalBox == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Kelas_Grup_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
