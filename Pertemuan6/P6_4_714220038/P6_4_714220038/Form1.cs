using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sizecost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pesan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama: " + Nama.Text + "\nEmail: " + Email.Text + "\nNo.Telp: " + NoTelp.Text + "\nWaktu Penyewaan: " + hari.Text + "\nSize: " + Size.Text, "Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Nama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nama.Text))
            {
                WpWarning.SetError(Nama, "Nama tidak boleh kosong");
                WpWrong.SetError(Nama, "");
                WpCorrect.SetError(Nama, "");
            }
            else
            {
                bool isValid = true;
                string inputText = Nama.Text;


                if (!char.IsUpper(inputText[0]))
                {
                    WpWrong.SetError(Nama, "Huruf pertama harus besar");
                    WpWarning.SetError(Nama, "");
                    WpCorrect.SetError(Nama, "");
                    isValid = false;
                }


                for (int i = 1; i < inputText.Length; i++)
                {
                    if (!char.IsLetter(inputText[i]) && inputText[i] != ' ')
                    {
                        WpWrong.SetError(Nama, "Inputan hanya boleh berisi huruf dan spasi dengan huruf pertama besar");
                        WpWarning.SetError(Nama, "");
                        WpCorrect.SetError(Nama, "");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    WpWrong.SetError(Nama, "");
                    WpWarning.SetError(Nama, "");
                    WpCorrect.SetError(Nama, "Betul!");
                }
            }

        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                WpWarning.SetError(Email, "Textbox Email tidak boleh kosong!");
                WpWrong.SetError(Email, "");
                WpCorrect.SetError(Email, "");
            }
            else
            {
                if (Regex.IsMatch(Email.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    WpWarning.SetError(Email, "");
                    WpWrong.SetError(Email, "");
                    WpCorrect.SetError(Email, "Betul!");
                }
                else
                {
                    WpWrong.SetError(Email, "Format email salah!\nContoh: a@b.c");
                    WpWarning.SetError(Email, "");
                    WpCorrect.SetError(Email, "");
                }
            }
        }

        private void sewaCosp_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nama.Text))
            {
                WpWarning.SetError(sewaCosp, "Nama tidak boleh kosong");
                WpWrong.SetError(sewaCosp, "");
                WpCorrect.SetError(sewaCosp, "");
            }
            else
            {
                bool isValid = true;
                string inputText = sewaCosp.Text;


                if (!char.IsUpper(inputText[0]))
                {
                    WpWrong.SetError(sewaCosp, "Huruf pertama harus besar");
                    WpWarning.SetError(sewaCosp, "");
                    WpCorrect.SetError(sewaCosp, "");
                    isValid = false;
                }


                for (int i = 1; i < inputText.Length; i++)
                {
                    if (!char.IsLetter(inputText[i]) && inputText[i] != ' ')
                    {
                        WpWrong.SetError(sewaCosp, "Inputan hanya boleh berisi huruf dan spasi dengan huruf pertama besar");
                        WpWarning.SetError(sewaCosp, "");
                        WpCorrect.SetError(sewaCosp, "");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    WpWrong.SetError(sewaCosp, "");
                    WpWarning.SetError(sewaCosp, "");
                    WpCorrect.SetError(sewaCosp, "Betul!");
                }
            }

        }

        private void NoTelp_Leave(object sender, EventArgs e)
        {
            if (NoTelp.Text == "")
            {
                WpWarning.SetError(NoTelp, "No.telp tidak boleh kosong");
                WpWrong.SetError(NoTelp, "");
                WpCorrect.SetError(NoTelp, "");
            }
            else
            {
                if ((NoTelp.Text).All(Char.IsNumber))
                {
                    WpWarning.SetError(NoTelp, "");
                    WpWrong.SetError(NoTelp, "");
                    WpCorrect.SetError(NoTelp, "Benar");
                }
                else
                {
                    WpWarning.SetError(NoTelp, "");
                    WpWrong.SetError(NoTelp, "Inputan Hanya boleh angka");
                    WpCorrect.SetError(NoTelp, "");
                }
            }
        }

        private void hari_Leave(object sender, EventArgs e)
        {
            if (hari.Text == "")
            {
                WpWarning.SetError(hari, "tidak boleh kosong");
                WpWrong.SetError(hari, "");
                WpCorrect.SetError(hari, "");
            }
            else
            {
                if ((hari.Text).All(Char.IsNumber))
                {
                    WpWarning.SetError(hari, "");
                    WpWrong.SetError(hari, "");
                    WpCorrect.SetError(hari, "Benar");
                }
                else
                {
                    WpWarning.SetError(hari, "");
                    WpWrong.SetError(hari, "Inputan Hanya boleh angka");
                    WpCorrect.SetError(hari, "");
                }
            }
        }

        private void Sizecost_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Sizecost.Text))
            {
                WpWarning.SetError(Sizecost, "Nama tidak boleh kosong");
                WpWrong.SetError(Sizecost, "");
                WpCorrect.SetError(Sizecost, "");
            }
            else
            {
                bool isValid = true;
                string inputText = Sizecost.Text;


                if (!char.IsUpper(inputText[0]))
                {
                    WpWrong.SetError(Sizecost, "Huruf pertama harus besar");
                    WpWarning.SetError(Sizecost, "");
                    WpCorrect.SetError(Sizecost, "");
                    isValid = false;
                }


                for (int i = 1; i < inputText.Length; i++)
                {
                    if (!char.IsLetter(inputText[i]) && inputText[i] != ' ')
                    {
                        WpWrong.SetError(Sizecost, "Inputan hanya boleh berisi huruf dan spasi dengan huruf pertama besar");
                        WpWarning.SetError(Sizecost, "");
                        WpCorrect.SetError(Sizecost, "");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    WpWrong.SetError(Sizecost, "");
                    WpWarning.SetError(Sizecost, "");
                    WpCorrect.SetError(Sizecost, "Betul!");
                }
            }
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}