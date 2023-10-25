using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_android.Checked)
            {
                os = "Android";
            }
            else if (rb_ios.Checked)
            {
                os = "iOS";
            }

            if (cbYa.Checked)
            {
                status = "Ya sudah diperbaiki";
            }
            else
            {
                status = "Belum diperbaiki";
            }

            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text +
                "\nSystem Operasi : " + os +
                "\nStatus Perbaikan : " + status,
                "Informasi Service HP",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    }
}
