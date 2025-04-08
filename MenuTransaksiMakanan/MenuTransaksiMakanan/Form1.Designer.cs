namespace MenuTransaksiMakanan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            jm = new ComboBox();
            label2 = new Label();
            nm = new ComboBox();
            harga = new TextBox();
            label3 = new Label();
            jumlah = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nonota = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            potongan = new TextBox();
            label9 = new Label();
            totalharga = new TextBox();
            label10 = new Label();
            totalbayar = new TextBox();
            label11 = new Label();
            button3 = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(32, 128);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Jenis Makanan";
            // 
            // jm
            // 
            jm.FormattingEnabled = true;
            jm.Location = new Point(169, 128);
            jm.Name = "jm";
            jm.Size = new Size(258, 33);
            jm.TabIndex = 1;
            jm.SelectedIndexChanged += jm_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 176);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama Makanan";
            // 
            // nm
            // 
            nm.FormattingEnabled = true;
            nm.Location = new Point(169, 176);
            nm.Name = "nm";
            nm.Size = new Size(258, 33);
            nm.TabIndex = 3;
            nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            // 
            // harga
            // 
            harga.Location = new Point(169, 224);
            harga.Multiline = true;
            harga.Name = "harga";
            harga.Size = new Size(258, 36);
            harga.TabIndex = 4;
            harga.TextChanged += harga_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(68, 224);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 5;
            label3.Text = "Harga";
            // 
            // jumlah
            // 
            jumlah.Location = new Point(169, 277);
            jumlah.Multiline = true;
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(258, 36);
            jumlah.TabIndex = 6;
            jumlah.TextChanged += jumlah_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(68, 277);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Jumlah";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(169, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(40, 82);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 9;
            label5.Text = "Tgl Transaksi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, -105);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(538, 76);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 11;
            label7.Text = "No. Nota";
            // 
            // nonota
            // 
            nonota.Location = new Point(639, 76);
            nonota.Multiline = true;
            nonota.Name = "nonota";
            nonota.Size = new Size(258, 36);
            nonota.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(549, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(169, 367);
            button1.Name = "button1";
            button1.Size = new Size(115, 33);
            button1.TabIndex = 14;
            button1.Text = "HITUNG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(312, 367);
            button2.Name = "button2";
            button2.Size = new Size(115, 33);
            button2.TabIndex = 15;
            button2.Text = "BERSIH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(538, 399);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 19;
            label8.Text = "Potongan";
            // 
            // potongan
            // 
            potongan.Location = new Point(639, 399);
            potongan.Multiline = true;
            potongan.Name = "potongan";
            potongan.Size = new Size(258, 36);
            potongan.TabIndex = 18;
            potongan.TextChanged += potongan_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(522, 349);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 17;
            label9.Text = "Total Harga";
            // 
            // totalharga
            // 
            totalharga.Location = new Point(639, 346);
            totalharga.Multiline = true;
            totalharga.Name = "totalharga";
            totalharga.Size = new Size(258, 36);
            totalharga.TabIndex = 16;
            totalharga.TextChanged += totalharga_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(525, 454);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 21;
            label10.Text = "Total Bayar";
            // 
            // totalbayar
            // 
            totalbayar.Location = new Point(639, 454);
            totalbayar.Multiline = true;
            totalbayar.Name = "totalbayar";
            totalbayar.Size = new Size(258, 36);
            totalbayar.TabIndex = 20;
            totalbayar.TextChanged += totalbayar_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(312, 9);
            label11.Name = "label11";
            label11.Size = new Size(334, 38);
            label11.TabIndex = 22;
            label11.Text = "ANGKRINGAN KANG ALI";
            label11.Click += label11_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(782, 508);
            button3.Name = "button3";
            button3.Size = new Size(115, 33);
            button3.TabIndex = 23;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(32, 508);
            label12.Name = "label12";
            label12.Size = new Size(258, 25);
            label12.TabIndex = 24;
            label12.Text = "Raenak gasah mbayar kang !!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(979, 560);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(totalbayar);
            Controls.Add(label8);
            Controls.Add(potongan);
            Controls.Add(label9);
            Controls.Add(totalharga);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(nonota);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(jumlah);
            Controls.Add(label3);
            Controls.Add(harga);
            Controls.Add(nm);
            Controls.Add(label2);
            Controls.Add(jm);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox jm;
        private Label label2;
        private ComboBox nm;
        private TextBox harga;
        private Label label3;
        private TextBox jumlah;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox nonota;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label8;
        private TextBox potongan;
        private Label label9;
        private TextBox totalharga;
        private Label label10;
        private TextBox totalbayar;
        private Label label11;
        private Button button3;
        private Label label12;
    }
}
