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

namespace Sahaf.Screens
{
    public partial class CategoryCrud : Form
    {
        public CategoryCrud()
        {
            InitializeComponent();
        }
        //SahafDbContext sınıfımızdan nesne oluşturduk
        SahafDbContext context = new SahafDbContext();
        private void CategoryCrud_Load(object sender, EventArgs e)
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
                MessageBox.Show("Category added..");
                GridViewDuzenleKategoriler();
                txtKategori.Clear();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
                txtId.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Category could not be added..");
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
                MessageBox.Show("Category updated..");
                GridViewDuzenleKategoriler();
                txtId.Clear();
                txtKategori.Clear();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Category could not be updated..");
            }
        }

        //Sil Butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            KategoriRepository kategoriRepo = new KategoriRepository(context);

            DialogResult dr = MessageBox.Show("Are you sure", "WARNİNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("Id not found..");
            }
        }

        //Sıfırla Butonu
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
                                Category = x.KategoriAdi,
                                Books = string.Join(", ", x.Kitaplar.Select(y => y.KitapAdi)),
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
