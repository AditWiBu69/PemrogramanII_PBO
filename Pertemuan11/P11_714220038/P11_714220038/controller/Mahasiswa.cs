using P11_714220038.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P11_714220038.controller
{
    class Mahasiswa
    {
        //Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Methode insert
        public bool Insert(M_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_mahasiswa(npm, nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "', '" +mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat +"','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data Berasil Ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return status;
        }
        //Methode insert
        public bool Update(M_mahasiswa mahasiswa, string npm_mhs)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_mahasiswa SET nama='" + mahasiswa.Nama + "',"+ "angkatan='" + mahasiswa.Angkatan + "'," + "alamat='" + mahasiswa.Alamat +"'," + "email='" + mahasiswa.Email + "'," + "nohp='" + mahasiswa.Nohp + "'WHERE npm = '" + npm_mhs + "'");
                status = true;
                MessageBox.Show("Data Berasil Diubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return status;
        }
        public bool Delete(string npm_mhs)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm_mhs + "'"); status = true;
                MessageBox.Show("Data Berasil Dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return status;
        }
    }
}
