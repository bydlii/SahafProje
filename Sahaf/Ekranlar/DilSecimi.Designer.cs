namespace Sahaf.Ekranlar
{
    partial class DilSecimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DilSecimi));
            pictureBox1 = new PictureBox();
            btnTr = new Button();
            btnEn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTr
            // 
            btnTr.BackgroundImage = (Image)resources.GetObject("btnTr.BackgroundImage");
            btnTr.BackgroundImageLayout = ImageLayout.Stretch;
            btnTr.Cursor = Cursors.Hand;
            btnTr.Location = new Point(58, 243);
            btnTr.Name = "btnTr";
            btnTr.Size = new Size(121, 97);
            btnTr.TabIndex = 0;
            btnTr.UseVisualStyleBackColor = true;
            btnTr.Click += btnTr_Click;
            // 
            // btnEn
            // 
            btnEn.BackgroundImage = (Image)resources.GetObject("btnEn.BackgroundImage");
            btnEn.BackgroundImageLayout = ImageLayout.Stretch;
            btnEn.Cursor = Cursors.Hand;
            btnEn.Location = new Point(441, 243);
            btnEn.Name = "btnEn";
            btnEn.Size = new Size(121, 97);
            btnEn.TabIndex = 1;
            btnEn.UseVisualStyleBackColor = true;
            btnEn.Click += btnEn_Click;
            // 
            // DilSecimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 240);
            ClientSize = new Size(619, 363);
            Controls.Add(btnEn);
            Controls.Add(btnTr);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "DilSecimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dil/Language";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnTr;
        private Button btnEn;
    }
}