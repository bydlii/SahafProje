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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        SahafDbContext context = new SahafDbContext();

        //Load
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            cmbKategoriAra.DataSource = context.Kategoriler.ToList();
            cmbKategoriAra.ValueMember = "Id";
            cmbKategoriAra.DisplayMember = "KategoriAdi";
            cmbKategoriAra.SelectedIndex = -1;

            cmbYayineviAra.DataSource = context.Yayinevleri.ToList();
            cmbYayineviAra.ValueMember = "Id";
            cmbYayineviAra.DisplayMember = "YayinEviAdi";
            cmbYayineviAra.SelectedIndex = -1;

            KitaplariDataGridViewGetir();
        }



        //Yayinevi Arama butonu
        private void btnYayineviAra_Click(object sender, EventArgs e)
        {
            int yayineviId = Convert.ToInt32(cmbYayineviAra.SelectedValue);
            var yayineviKitaplari = context.Kitaplar.Include(x => x.Yayinevi)
                                                    .Where(x => x.YayineviId == yayineviId)
                                                    .Select(x => new
                                                    {
                                                        Yayinevi = x.Yayinevi,
                                                        KitapAdi = x.KitapAdi,
                                                        Kategori = x.Kategori,
                                                        Kullanici = x.Kullanici,
                                                        Yazarlar = string.Join(", ", x.Yazarlar.Select(y => y.YazarAdi)),
                                                    }).ToList();

            dgvAnaEkran.DataSource = yayineviKitaplari.ToList();

        }


        //Kategori Arama Butonu
        private void btnKategoriAra_Click(object sender, EventArgs e)
        {
            int kategoriId = Convert.ToInt32(cmbKategoriAra.SelectedValue);
            var kategoriKitaplari = context.Kitaplar.Include(x => x.Kategori)
                                                    .Where(x => x.KategoriId == kategoriId)
                                                    .Select(x => new
                                                    {
                                                        Kategori = x.Kategori,
                                                        KitapAdi = x.KitapAdi,
                                                        Yayinevi = x.Yayinevi,
                                                        Kullanici = x.Kullanici,
                                                        Yazarlar = string.Join(", ", x.Yazarlar.Select(y => y.YazarAdi)),
                                                    })
                                                    .ToList();

            dgvAnaEkran.DataSource = kategoriKitaplari.ToList();

        }

        //Yazar Arama Butonu
        private void btnYazarAra_Click(object sender, EventArgs e)
        {

            string yazarAdi = txtAra.Text.Trim();


            if (!string.IsNullOrEmpty(yazarAdi))
            {
                var kitaplar = context.Kitaplar
                    .Include(k => k.Yazarlar)
                    .Where(k => k.Yazarlar.Any(y => y.YazarAdi.Contains(yazarAdi)))
                    .Select(k => new
                    {
                        Yazarlar = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi)),
                        KitapAdi = k.KitapAdi,
                        Kategori = k.Kategori,
                        Yayinevi = k.Yayinevi,
                        Kullanici = k.Kullanici,

                    })
                    .ToList();

                dgvAnaEkran.DataSource = kitaplar;
            }
        }

        //Kullanici Arama Butonu
        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtAra.Text.Trim();

            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                var KullaniciKitaplari = context.Kitaplar.Include(x => x.Kullanici).Where(x => x.Kullanici.KullaniciAdi == kullaniciAdi)
                .Select(k => new
                {
                    Kullanici = k.Kullanici,
                    KitapAdi = k.KitapAdi,
                    Fiyat = k.Fiyat,
                    BaskiSayisi = k.BaskiSayisi,
                    BasımYili = k.BasimYili,
                    KapakYazisi = k.KapakYazisi,
                    Kategori = k.Kategori,
                    Yayinevi = k.Yayinevi,
                    Yazarlar = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                })
                .ToList();
                dgvAnaEkran.DataSource = KullaniciKitaplari.ToList();
            }

        }

        //Kitap Arama Butonu
        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtAra.Text.Trim();


            if (!string.IsNullOrEmpty(kitapAdi))
            {
                var kitaplar = context.Kitaplar
                    .Include(k => k.Yazarlar)
                    .Where(k => k.KitapAdi.Contains(kitapAdi))
                    .Select(k => new
                    {
                        KitapAdi = k.KitapAdi,
                        Fiyat = k.Fiyat,
                        BaskiSayisi = k.BaskiSayisi,
                        BasımYili = k.BasimYili,
                        KapakYazisi = k.KapakYazisi,
                        Kategori = k.Kategori,
                        Yayinevi = k.Yayinevi,
                        Kullanici = k.Kullanici,
                        Yazarlar = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                    })
                    .ToList();

                dgvAnaEkran.DataSource = kitaplar;
            }
        }


        //Son 10 kitap Butonu
        private void btnSonOnKitap_Click(object sender, EventArgs e)
        {
            try
            {
                var sonOnKitap = context.Kitaplar
                    .OrderByDescending(k => k.Id)
                    .Take(10)
                    .Select(k => new
                    {
                        KitapAdi = k.KitapAdi,
                        Fiyat = k.Fiyat,
                        BaskiSayisi = k.BaskiSayisi,
                        BasımYili = k.BasimYili,
                        KapakYazisi = k.KapakYazisi,
                        Kategori = k.Kategori,
                        Yayinevi = k.Yayinevi,
                        Kullanici = k.Kullanici,
                        Yazarlar = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                    })
                    .ToList();

                dgvAnaEkran.DataSource = sonOnKitap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler Getirilemedi: {ex.Message}");
            }
        }


        //Fiyata göre Arama Butonu
        private void btnFiyatAra_Click(object sender, EventArgs e)
        {
            try
            {
                double minFiyat = double.Parse(txtMin.Text);
                double maxFiyat = double.Parse(txtMax.Text);

                var kitapFiyatlar = context.Kitaplar.Where(k => k.Fiyat >= minFiyat && k.Fiyat <= maxFiyat)
                    .Select(k => new
                    {
                        KitapAdi = k.KitapAdi,
                        Fiyat = k.Fiyat,
                        BaskiSayisi = k.BaskiSayisi,
                        BasımYili = k.BasimYili,
                        KapakYazisi = k.KapakYazisi,
                        Kategori = k.Kategori,
                        Yayinevi = k.Yayinevi,
                        Kullanici = k.Kullanici,
                        Yazarlar = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                    })
                    .ToList();

                dgvAnaEkran.DataSource = kitapFiyatlar;

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir fiyat aralığı girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }


        //Ekranı güncelleme butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            cmbKategoriAra.DataSource = null;
            cmbKategoriAra.DataSource = context.Kategoriler.ToList();
            cmbKategoriAra.ValueMember = "Id";
            cmbKategoriAra.DisplayMember = "KategoriAdi";
            cmbKategoriAra.SelectedIndex = -1;

            cmbYayineviAra.DataSource = null;
            cmbYayineviAra.DataSource = context.Yayinevleri.ToList();
            cmbYayineviAra.ValueMember = "Id";
            cmbYayineviAra.DisplayMember = "YayinEviAdi";
            cmbYayineviAra.SelectedIndex = -1;

            KitaplariDataGridViewGetir();
            txtAra.Clear();
            txtMin.Clear();
            txtAra.Clear();
        }


        //Crud Formları geçiş butonları
        private void btnKitapCrud_Click(object sender, EventArgs e)
        {
            KitapCrud kitapCrud = new KitapCrud();
            kitapCrud.Show();
        }

        private void btnYazarCrud_Click(object sender, EventArgs e)
        {
            YazarCrud yazarCrud = new YazarCrud();
            yazarCrud.Show();
        }

        private void btnKategoriCrud_Click(object sender, EventArgs e)
        {
            KategoriCrud kategoriCrud = new KategoriCrud();
            kategoriCrud.Show();
        }

        private void btnYayineviCrud_Click(object sender, EventArgs e)
        {
            YayineviCrud yayineviCrud = new YayineviCrud();
            yayineviCrud.Show();
        }

        private void btnKullaniciCrud_Click(object sender, EventArgs e)
        {
            KullaniciCrud kullaniciCrud = new KullaniciCrud();
            kullaniciCrud.Show();
        }



        //Kitapları yazar adlarıyla dataGridView e getirme metodu
        public void KitaplariDataGridViewGetir()
        {
            var kitaplar = context.Kitaplar
                .Include(k => k.Yazarlar)
                .Select(k => new
                {
                    KitapAdi = k.KitapAdi,
                    Fiyat = k.Fiyat,
                    BaskiSayisi = k.BaskiSayisi,
                    BasımYili = k.BasimYili,
                    KapakYazisi = k.KapakYazisi,
                    Kategori = k.Kategori,
                    Yayinevi = k.Yayinevi,
                    Kullanici = k.Kullanici,
                    Yazarlar = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                }).ToList();
            dgvAnaEkran.DataSource = kitaplar;
        }


    }
}
