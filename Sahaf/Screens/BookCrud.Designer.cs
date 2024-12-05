namespace Sahaf.Screens
{
    partial class BookCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCrud));
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnSifirla = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dgvKitaplar = new DataGridView();
            cbKategoriler = new ComboBox();
            cbYayinevleri = new ComboBox();
            txtKitapAdi = new TextBox();
            txtFiyat = new TextBox();
            txtBasimYili = new TextBox();
            txtKapakYazisi = new TextBox();
            txtBaskiSayisi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnAra = new Button();
            txtId = new TextBox();
            clbYazarlar = new CheckedListBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 3);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 51;
            label3.Text = "EN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // btnSifirla
            // 
            btnSifirla.BackgroundImage = (Image)resources.GetObject("btnSifirla.BackgroundImage");
            btnSifirla.BackgroundImageLayout = ImageLayout.Stretch;
            btnSifirla.Cursor = Cursors.Hand;
            btnSifirla.Location = new Point(847, 331);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(117, 107);
            btnSifirla.TabIndex = 13;
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Location = new Point(763, 259);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 51);
            btnSil.TabIndex = 12;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = (Image)resources.GetObject("btnGuncelle.BackgroundImage");
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Location = new Point(763, 149);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 51);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = (Image)resources.GetObject("btnEkle.BackgroundImage");
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.Location = new Point(763, 33);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 51);
            btnEkle.TabIndex = 10;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(11, 33);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(733, 276);
            dgvKitaplar.TabIndex = 44;
            // 
            // cbKategoriler
            // 
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(11, 345);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(151, 28);
            cbKategoriler.TabIndex = 0;
            // 
            // cbYayinevleri
            // 
            cbYayinevleri.FormattingEnabled = true;
            cbYayinevleri.Location = new Point(11, 419);
            cbYayinevleri.Name = "cbYayinevleri";
            cbYayinevleri.Size = new Size(151, 28);
            cbYayinevleri.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Cursor = Cursors.IBeam;
            txtKitapAdi.Location = new Point(391, 324);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(182, 27);
            txtKitapAdi.TabIndex = 3;
            // 
            // txtFiyat
            // 
            txtFiyat.Cursor = Cursors.IBeam;
            txtFiyat.Location = new Point(391, 392);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(182, 27);
            txtFiyat.TabIndex = 4;
            // 
            // txtBasimYili
            // 
            txtBasimYili.Cursor = Cursors.IBeam;
            txtBasimYili.Location = new Point(391, 473);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(182, 27);
            txtBasimYili.TabIndex = 5;
            // 
            // txtKapakYazisi
            // 
            txtKapakYazisi.Cursor = Cursors.IBeam;
            txtKapakYazisi.Location = new Point(270, 611);
            txtKapakYazisi.Name = "txtKapakYazisi";
            txtKapakYazisi.Size = new Size(303, 27);
            txtKapakYazisi.TabIndex = 7;
            // 
            // txtBaskiSayisi
            // 
            txtBaskiSayisi.Cursor = Cursors.IBeam;
            txtBaskiSayisi.Location = new Point(391, 547);
            txtBaskiSayisi.Name = "txtBaskiSayisi";
            txtBaskiSayisi.Size = new Size(182, 27);
            txtBaskiSayisi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 321);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 56;
            label2.Text = "CATEGORY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 395);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 57;
            label1.Text = "PUBLISHING HOUSE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 476);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 58;
            label4.Text = "AUTHOR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(270, 331);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 59;
            label5.Text = "BOOK NAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 399);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 60;
            label6.Text = "PRICE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(322, 480);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 61;
            label7.Text = "YEAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(186, 555);
            label8.Name = "label8";
            label8.Size = new Size(187, 20);
            label8.TabIndex = 62;
            label8.Text = "NUMBER OF PRINTINGS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(153, 619);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 63;
            label9.Text = "BOOK COVER";
            // 
            // btnAra
            // 
            btnAra.BackgroundImage = (Image)resources.GetObject("btnAra.BackgroundImage");
            btnAra.BackgroundImageLayout = ImageLayout.Stretch;
            btnAra.Cursor = Cursors.Hand;
            btnAra.Location = new Point(580, 387);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(163, 51);
            btnAra.TabIndex = 9;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtId
            // 
            txtId.Cursor = Cursors.IBeam;
            txtId.Location = new Point(580, 331);
            txtId.Name = "txtId";
            txtId.Size = new Size(164, 27);
            txtId.TabIndex = 8;
            // 
            // clbYazarlar
            // 
            clbYazarlar.FormattingEnabled = true;
            clbYazarlar.Location = new Point(14, 501);
            clbYazarlar.Margin = new Padding(3, 4, 3, 4);
            clbYazarlar.Name = "clbYazarlar";
            clbYazarlar.Size = new Size(146, 114);
            clbYazarlar.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(580, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(383, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // BookCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 240);
            ClientSize = new Size(976, 656);
            Controls.Add(pictureBox2);
            Controls.Add(clbYazarlar);
            Controls.Add(btnAra);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtBaskiSayisi);
            Controls.Add(txtKapakYazisi);
            Controls.Add(txtBasimYili);
            Controls.Add(txtFiyat);
            Controls.Add(txtKitapAdi);
            Controls.Add(cbYayinevleri);
            Controls.Add(cbKategoriler);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSifirla);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvKitaplar);
            MaximizeBox = false;
            Name = "BookCrud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Transactions";
            Load += BookCrud_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button btnSifirla;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private DataGridView dgvKitaplar;
        private ComboBox cbKategoriler;
        private ComboBox cbYayinevleri;
        private TextBox txtKitapAdi;
        private TextBox txtFiyat;
        private TextBox txtBasimYili;
        private TextBox txtKapakYazisi;
        private TextBox txtBaskiSayisi;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAra;
        private TextBox txtId;
        private CheckedListBox clbYazarlar;
        private PictureBox pictureBox2;
    }
}