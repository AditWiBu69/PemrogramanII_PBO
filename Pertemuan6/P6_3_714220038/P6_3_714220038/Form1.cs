using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text == ""))
            {
                epWarning.SetError(txtHuruf, "Huruf Tidak Boleh Kosong");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "Input Harus Huruf");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }
        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text == ""))
            {
                epCorrect.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "Angka Tidak Boleh Kosong");
                epWrong.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Input Harus Angka");
                }
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if ((txtEmail.Text == ""))
            {
                epCorrect.SetError(txtEmail, "");
                epWarning.SetError(txtEmail, "Email Tidak Boleh Kosong");
                epWrong.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s])+$"))
                {
                    epCorrect.SetError(txtEmail, "Betul");
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                }
                else
                {
                    epCorrect.SetError(txtEmail, "");
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "email salah! \nContoh: a@b.c");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if ((txtAngka1.Text).All(Char.IsNumber))
            {
                int a;
                if (int.TryParse(txtAngka1.Text, out a))
                {
                    if (a > int.Parse(txtAngka2.Text))
                    {
                        epCorrect.SetError(txtAngka1, "Angka 1 lebih besar dari Angka 2");
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "");
                    }
                    else
                    {
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "Angka Tidak Boleh Kosong");
                        epWrong.SetError(txtAngka1, "");
                    }
                }
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka1, "Angka Tidak Boleh Kosong");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Input Harus Angka");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if ((txtAngka1.Text).All(Char.IsNumber))
            {
                int a;
                if (int.TryParse(txtAngka2.Text, out a))
                {
                    if (a > int.Parse(txtAngka1.Text))
                    {
                        epCorrect.SetError(txtAngka2, "Angka 1 lebih besar dari Angka 2");
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                    }
                    else
                    {
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "Angka 2 lebih besar dari Angka 1");
                        epWrong.SetError(txtAngka2, "");
                    }
                }
                if ((txtAngka2.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka2, "Angka Tidak Boleh Kosong");
                }
                else
                {
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Input Harus Angka");
                }
            }
        }
    }
}

