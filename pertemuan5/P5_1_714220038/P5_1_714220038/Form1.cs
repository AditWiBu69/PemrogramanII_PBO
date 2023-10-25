using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_714220038
{
    public partial class FormHello : Form
    {
        public FormHello()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Hello World!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
