namespace Sahaf.Screens
{
    partial class CategoryCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryCrud));
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnEkraniSifirla = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnAra = new Button();
            txtId = new TextBox();
            dgvKategori = new DataGridView();
            txtKategori = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 3);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 33;
            label3.Text = "EN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnEkraniSifirla
            // 
            btnEkraniSifirla.BackgroundImage = (Image)resources.GetObject("btnEkraniSifirla.BackgroundImage");
            btnEkraniSifirla.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkraniSifirla.Cursor = Cursors.Hand;
            btnEkraniSifirla.Location = new Point(381, 321);
            btnEkraniSifirla.Name = "btnEkraniSifirla";
            btnEkraniSifirla.Size = new Size(117, 107);
            btnEkraniSifirla.TabIndex = 6;
            btnEkraniSifirla.UseVisualStyleBackColor = true;
            btnEkraniSifirla.Click += btnEkraniSifirla_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Location = new Point(514, 259);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 51);
            btnSil.TabIndex = 5;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = (Image)resources.GetObject("btnGuncelle.BackgroundImage");
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Location = new Point(514, 188);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 51);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = (Image)resources.GetObject("btnEkle.BackgroundImage");
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.Location = new Point(514, 111);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 51);
            btnEkle.TabIndex = 3;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnAra
            // 
            btnAra.BackgroundImage = (Image)resources.GetObject("btnAra.BackgroundImage");
            btnAra.BackgroundImageLayout = ImageLayout.Stretch;
            btnAra.Cursor = Cursors.Hand;
            btnAra.Location = new Point(37, 377);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(200, 51);
            btnAra.TabIndex = 1;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtId
            // 
            txtId.Cursor = Cursors.IBeam;
            txtId.Location = new Point(35, 341);
            txtId.Name = "txtId";
            txtId.Size = new Size(201, 27);
            txtId.TabIndex = 0;
            // 
            // dgvKategori
            // 
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(37, 33);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.RowHeadersWidth = 51;
            dgvKategori.Size = new Size(461, 276);
            dgvKategori.TabIndex = 26;
            // 
            // txtKategori
            // 
            txtKategori.Cursor = Cursors.IBeam;
            txtKategori.Location = new Point(514, 57);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(189, 27);
            txtKategori.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(522, 321);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // CategoryCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 240);
            ClientSize = new Size(725, 451);
            Controls.Add(pictureBox2);
            Controls.Add(txtKategori);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnEkraniSifirla);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnAra);
            Controls.Add(txtId);
            Controls.Add(dgvKategori);
            MaximizeBox = false;
            Name = "CategoryCrud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Transactions";
            Load += CategoryCrud_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button btnEkraniSifirla;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnAra;
        private TextBox txtId;
        private DataGridView dgvKategori;
        private TextBox txtKategori;
        private PictureBox pictureBox2;
    }
}