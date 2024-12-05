namespace Sahaf.Ekranlar
{
    partial class KullaniciCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciCrud));
            btnEkle = new Button();
            btnAra = new Button();
            btnGuncelle = new Button();
            btnSifirla = new Button();
            btnSil = new Button();
            txtAd = new TextBox();
            txtParola = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSoyad = new TextBox();
            txtId = new TextBox();
            dgvKullanici = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKullanici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = (Image)resources.GetObject("btnEkle.BackgroundImage");
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.Location = new Point(58, 368);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 51);
            btnEkle.TabIndex = 4;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnAra
            // 
            btnAra.BackgroundImage = (Image)resources.GetObject("btnAra.BackgroundImage");
            btnAra.BackgroundImageLayout = ImageLayout.Stretch;
            btnAra.Cursor = Cursors.Hand;
            btnAra.Location = new Point(285, 515);
            btnAra.Margin = new Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(200, 51);
            btnAra.TabIndex = 8;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = (Image)resources.GetObject("btnGuncelle.BackgroundImage");
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Location = new Point(58, 453);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 51);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.BackgroundImage = (Image)resources.GetObject("btnSifirla.BackgroundImage");
            btnSifirla.BackgroundImageLayout = ImageLayout.Stretch;
            btnSifirla.Cursor = Cursors.Hand;
            btnSifirla.Location = new Point(785, 480);
            btnSifirla.Margin = new Padding(3, 4, 3, 4);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(117, 107);
            btnSifirla.TabIndex = 9;
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Location = new Point(58, 536);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 51);
            btnSil.TabIndex = 6;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAd
            // 
            txtAd.Cursor = Cursors.IBeam;
            txtAd.Location = new Point(58, 61);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(201, 27);
            txtAd.TabIndex = 0;
            // 
            // txtParola
            // 
            txtParola.Cursor = Cursors.IBeam;
            txtParola.Location = new Point(58, 279);
            txtParola.Margin = new Padding(3, 4, 3, 4);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(201, 27);
            txtParola.TabIndex = 3;
            txtParola.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Cursor = Cursors.IBeam;
            txtKullaniciAdi.Location = new Point(58, 205);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(201, 27);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Cursor = Cursors.IBeam;
            txtSoyad.Location = new Point(58, 133);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(201, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Cursor = Cursors.IBeam;
            txtId.Location = new Point(285, 453);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(201, 27);
            txtId.TabIndex = 7;
            // 
            // dgvKullanici
            // 
            dgvKullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanici.Location = new Point(285, 13);
            dgvKullanici.Margin = new Padding(3, 4, 3, 4);
            dgvKullanici.Name = "dgvKullanici";
            dgvKullanici.RowHeadersWidth = 51;
            dgvKullanici.Size = new Size(617, 380);
            dgvKullanici.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            label2.Location = new Point(139, 37);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 12;
            label2.Text = "AD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            label3.Location = new Point(127, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 12;
            label3.Text = "SOYAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            label4.Location = new Point(99, 181);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 12;
            label4.Text = "KULLANICI ADI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            label5.Location = new Point(119, 255);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "PAROLA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 3);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 28;
            label1.Text = "TR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(510, 400);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // KullaniciCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 240);
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvKullanici);
            Controls.Add(txtId);
            Controls.Add(txtSoyad);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtParola);
            Controls.Add(txtAd);
            Controls.Add(btnSil);
            Controls.Add(btnSifirla);
            Controls.Add(btnGuncelle);
            Controls.Add(btnAra);
            Controls.Add(btnEkle);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "KullaniciCrud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı İşlemleri";
            Load += KullaniciCrud_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanici).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnSifirla;
        private Button btnSil;
        private TextBox txtAd;
        private TextBox txtParola;
        private TextBox txtKullaniciAdi;
        private TextBox txtSoyad;
        private TextBox txtId;
        private DataGridView dgvKullanici;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}