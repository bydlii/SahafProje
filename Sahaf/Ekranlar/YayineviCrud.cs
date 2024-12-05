using Microsoft.EntityFrameworkCore;
using Sahaf.Data;
using Sahaf.Models;
using Sahaf.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahaf.Ekranlar
{
    public partial class YayineviCrud : Form
    {
        public YayineviCrud()
        {
            InitializeComponent();
        }

        //SahafDbContext sınıfımızdan nesne oluşturduk
        SahafDbContext context = new SahafDbContext();


        //Load
        private void YayineviCrud_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            GridViewDuzenleYayinevleri();
        }


        //Ekle Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Yayinevi yayinevi = new Yayinevi();
                YayineviRepository yayineviRepo = new YayineviRepository(new Data.SahafDbContext());
                yayinevi.YayineviAdi = txtYayinevi.Text;
                yayineviRepo.Ekle(yayinevi);
                MessageBox.Show("Yayın Evi Eklendi..");
                GridViewDuzenleYayinevleri();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
                txtId.Clear();
                txtYayinevi.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Yayın Evi Eklenemedi..");
            }
        }


        //Guncelle butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                YayineviRepository yayineviRepo = new YayineviRepository(context);
                Yayinevi yayinevi = yayineviRepo.Ara(id);
                yayinevi.YayineviAdi = txtYayinevi.Text;
                MessageBox.Show("Yayin Evi Güncellendi..");
                GridViewDuzenleYayinevleri();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
                txtId.Clear();               
                txtYayinevi.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Yayin Evi Güncellenemedi..");
            }
        }


        //Sil butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            YayineviRepository yayineviRepo = new YayineviRepository(context);

            DialogResult dr = MessageBox.Show("Emin Misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int YayineviId = int.Parse(txtId.Text);
                yayineviRepo.Sil(YayineviId);
                GridViewDuzenleYayinevleri();
                txtId.Clear();
                txtYayinevi.Clear();
                ButtonAktifPasif(false);
                txtId.Enabled = true;

            }
        }


        //Ara butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                YayineviRepository yayineviRepo = new YayineviRepository(context);
                Yayinevi yayinevi = yayineviRepo.Ara(id);
                txtYayinevi.Text = yayinevi.YayineviAdi;
                ButtonAktifPasif(true);
                txtId.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Id bulunamadı..");
            }
        }


        //Sıfırla butonu
        private void btnEkraniSifirla_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            txtId.Clear();
            txtYayinevi.Clear();
            GridViewDuzenleYayinevleri();
        }



        //İşlevsel düzenleme metodlarımız
        public void ButtonAktifPasif(bool aktif)
        {
            btnGuncelle.Enabled = aktif;
            btnSil.Enabled = aktif;
            btnEkle.Enabled = !aktif;
            btnAra.Enabled = !aktif;
        }

        
        public void GridViewDuzenleYayinevleri()
        {
            var kitaplar = context.Yayinevleri
                          .Include(x => x.Kitaplar)
                          .Select(x => new
                          {
                              Id = x.Id,
                              Yayinevi = x.YayineviAdi,
                              KitapAdi = string.Join(", ", x.Kitaplar.Select(y => y.KitapAdi)),
                          }).ToList();
            dgvYayinevi.DataSource = kitaplar.ToList();
        }

    }
}
