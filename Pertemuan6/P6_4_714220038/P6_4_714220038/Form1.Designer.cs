namespace P6_4_714220038
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nama = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.NoTelp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sewaCosp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Sizecost = new System.Windows.Forms.ComboBox();
            this.Batal = new System.Windows.Forms.Button();
            this.Pesan = new System.Windows.Forms.Button();
            this.WpWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.WpWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.WpCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WpWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(174, 16);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(100, 20);
            this.Nama.TabIndex = 0;
            this.Nama.Leave += new System.EventHandler(this.Nama_Leave);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(174, 51);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 1;
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // NoTelp
            // 
            this.NoTelp.Location = new System.Drawing.Point(174, 93);
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Size = new System.Drawing.Size(100, 20);
            this.NoTelp.TabIndex = 2;
            this.NoTelp.Leave += new System.EventHandler(this.NoTelp_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "No.Telp";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(49, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model Costum Yang Ingin di sewa";
            // 
            // sewaCosp
            // 
            this.sewaCosp.Location = new System.Drawing.Point(174, 141);
            this.sewaCosp.Name = "sewaCosp";
            this.sewaCosp.Size = new System.Drawing.Size(100, 20);
            this.sewaCosp.TabIndex = 6;
            this.sewaCosp.Leave += new System.EventHandler(this.sewaCosp_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "waktu penyewaan";
            // 
            // hari
            // 
            this.hari.Location = new System.Drawing.Point(174, 211);
            this.hari.Name = "hari";
            this.hari.Size = new System.Drawing.Size(27, 20);
            this.hari.TabIndex = 8;
            this.hari.Leave += new System.EventHandler(this.hari_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "/Hari*";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(49, 245);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(27, 13);
            this.Size.TabIndex = 12;
            this.Size.Text = "Size";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Sizecost
            // 
            this.Sizecost.FormattingEnabled = true;
            this.Sizecost.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.Sizecost.Location = new System.Drawing.Point(174, 242);
            this.Sizecost.Name = "Sizecost";
            this.Sizecost.Size = new System.Drawing.Size(66, 21);
            this.Sizecost.TabIndex = 14;
            this.Sizecost.Leave += new System.EventHandler(this.Sizecost_Leave);
            // 
            // Batal
            // 
            this.Batal.Location = new System.Drawing.Point(51, 309);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(92, 31);
            this.Batal.TabIndex = 15;
            this.Batal.Text = "Batal";
            this.Batal.UseVisualStyleBackColor = true;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // Pesan
            // 
            this.Pesan.Location = new System.Drawing.Point(164, 309);
            this.Pesan.Name = "Pesan";
            this.Pesan.Size = new System.Drawing.Size(87, 31);
            this.Pesan.TabIndex = 16;
            this.Pesan.Text = "Cek Pesanan";
            this.Pesan.UseVisualStyleBackColor = true;
            this.Pesan.Click += new System.EventHandler(this.Pesan_Click);
            // 
            // WpWarning
            // 
            this.WpWarning.ContainerControl = this;
            this.WpWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("WpWarning.Icon")));
            // 
            // WpWrong
            // 
            this.WpWrong.ContainerControl = this;
            this.WpWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("WpWrong.Icon")));
            // 
            // WpCorrect
            // 
            this.WpCorrect.ContainerControl = this;
            this.WpCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("WpCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 436);
            this.Controls.Add(this.Pesan);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Sizecost);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sewaCosp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoTelp);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nama);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pemesanan Costum Cosplay";
            ((System.ComponentModel.ISupportInitialize)(this.WpWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NoTelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sewaCosp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Sizecost;
        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.Button Pesan;
        private System.Windows.Forms.ErrorProvider WpWarning;
        private System.Windows.Forms.ErrorProvider WpWrong;
        private System.Windows.Forms.ErrorProvider WpCorrect;
    }
}

