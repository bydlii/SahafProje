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
    public partial class KategoriCrud : Form
    {
        public KategoriCrud()
        {

            InitializeComponent();
        }


        //SahafDbContext sınıfımızdan nesne oluşturduk
        SahafDbContext context = new SahafDbContext();


        //Load
        private void KategoriCrud_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            GridViewDuzenleKategoriler();
        }


        //Ekle Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori();
                KategoriRepository kategoriRepo = new KategoriRepository(new Data.SahafDbContext());
                kategori.KategoriAdi = txtKategori.Text;
                kategoriRepo.Ekle(kategori);
                MessageBox.Show("Kategori Eklendi..");
                GridViewDuzenleKategoriler();
                txtKategori.Clear();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
                txtId.Clear();               
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori Eklenemedi..");
            }
        }


        //Güncelle Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                KategoriRepository kategoriRepo = new KategoriRepository(context);
                Kategori kategori = kategoriRepo.Ara(id);
                kategori.KategoriAdi = txtKategori.Text;                
                MessageBox.Show("Kategori Güncellendi..");
                GridViewDuzenleKategoriler();
                txtId.Clear();
                txtKategori.Clear();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori Güncellenemedi..");
            }
        }


        //Sil Butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            KategoriRepository kategoriRepo = new KategoriRepository(context);

            DialogResult dr = MessageBox.Show("Emin Misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int kategoriId = int.Parse(txtId.Text);
                kategoriRepo.Sil(kategoriId);
                GridViewDuzenleKategoriler();
                txtId.Clear();
                txtKategori.Clear();
                ButtonAktifPasif(false);
                txtId.Enabled = true;

            }
        }


        //Ara Butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                KategoriRepository kategoriRepo = new KategoriRepository(context);
                Kategori kategori = kategoriRepo.Ara(id);
                txtKategori.Text = kategori.KategoriAdi;
                ButtonAktifPasif(true);
                txtId.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Id bulunamadı..");
            }
        }

        //Ekranı Sıfırlama Metodu
        private void btnEkraniSifirla_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            txtId.Clear();
            txtKategori.Clear();

            GridViewDuzenleKategoriler();
        }




        //İşlevsel Düzenleme Metodlarımız
        private void GridViewDuzenleKategoriler()
        {
            var kategoriler = context.Kategoriler
                             .Include(x => x.Kitaplar)
                             .Select(x => new
                             {
                                 Id = x.Id,
                                 Kategori = x.KategoriAdi,
                                 Kitaplar = string.Join(", ", x.Kitaplar.Select(y => y.KitapAdi)),
                             }).ToList();
            dgvKategori.DataSource = kategoriler.ToList();

        }
        public void ButtonAktifPasif(bool aktif)
        {
            btnGuncelle.Enabled = aktif;
            btnSil.Enabled = aktif;
            btnEkle.Enabled = !aktif;
            btnAra.Enabled = !aktif;
        }

    }
}
