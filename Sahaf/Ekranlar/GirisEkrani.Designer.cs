namespace Sahaf.Ekranlar
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            btnGirisYap = new Button();
            txtKullaniciAdi = new TextBox();
            txtParola = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackgroundImage = (Image)resources.GetObject("btnGirisYap.BackgroundImage");
            btnGirisYap.BackgroundImageLayout = ImageLayout.Stretch;
            btnGirisYap.Cursor = Cursors.Hand;
            btnGirisYap.Location = new Point(109, 365);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(206, 60);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click_1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Cursor = Cursors.IBeam;
            txtKullaniciAdi.Location = new Point(109, 221);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(206, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtParola
            // 
            txtParola.Cursor = Cursors.IBeam;
            txtParola.Location = new Point(109, 311);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(206, 27);
            txtParola.TabIndex = 1;
            txtParola.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 1);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 3;
            label1.Text = "TR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 199);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 4;
            label2.Text = "KULLANICI ADI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            label3.Location = new Point(175, 288);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "PAROLA";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 240);
            ClientSize = new Size(416, 451);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtParola);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGirisYap);
            MaximizeBox = false;
            Name = "GirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += GirisEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private TextBox txtKullaniciAdi;
        private TextBox txtParola;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
    }
}