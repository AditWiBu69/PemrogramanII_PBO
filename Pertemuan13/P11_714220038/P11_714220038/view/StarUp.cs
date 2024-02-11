using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714220038.view
{
    public partial class StarUp : Form
    {
        public StarUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ParentForm frm = new ParentForm();
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Dispose();
                Close();
            }
        }
    }
}
