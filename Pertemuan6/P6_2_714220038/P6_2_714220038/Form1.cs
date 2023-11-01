using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714220038
{
    public partial class Catch : Form
    {
        private string filePath;
        public Catch()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = openFileDialog2.ShowDialog();
            if(userResponse == DialogResult.OK)
            {
                filePath = openFileDialog2.FileName.ToString();
                MessageBox.Show("Berhasil: '" + filePath + "'", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else
            {
                MessageBox.Show("Gagal", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            }
        }
        Catch (Exception ex)
        {
            MessageBox.Show(ex.Message.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
       
}