using Microsoft.EntityFrameworkCore;
using Sahaf.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sahaf.Screens
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        SahafDbContext context = new SahafDbContext();

        private void MainScreen_Load(object sender, EventArgs e)
        {
            cmbKategoriAra.DataSource = context.Kategoriler.ToList();
            cmbKategoriAra.ValueMember = "Id";
            cmbKategoriAra.DisplayMember = "KategoriAdi";
            cmbKategoriAra.SelectedIndex = -1;

            cmbYayineviAra.DataSource = context.Yayinevleri.ToList();
            cmbYayineviAra.ValueMember = "Id";
            cmbYayineviAra.DisplayMember = "YayineviAdi";
            cmbYayineviAra.SelectedIndex = -1;

            KitaplariDataGridViewGetir();
        }

        //Yayinevi arama butonu
        private void btnYayineviAra_Click(object sender, EventArgs e)
        {
            int yayineviId = Convert.ToInt32(cmbYayineviAra.SelectedValue);
            var yayineviKitaplari = context.Kitaplar.Include(x => x.Yayinevi)
                                                    .Where(x => x.YayineviId == yayineviId)
                                                    .Select(x => new
                                                    {
                                                        Phouse = x.Yayinevi,
                                                        BookName = x.KitapAdi,
                                                        Category = x.Kategori,
                                                        User = x.Kullanici,
                                                        Authors = string.Join(", ", x.Yazarlar.Select(y => y.YazarAdi)),
                                                    }).ToList();

            dgvAnaEkran.DataSource = yayineviKitaplari.ToList();

        }

        //Kategori arama butonu
        private void btnKategoriAra_Click(object sender, EventArgs e)
        {
            int kategoriId = Convert.ToInt32(cmbKategoriAra.SelectedValue);
            var kategoriKitaplari = context.Kitaplar.Include(x => x.Kategori)
                                                    .Where(x => x.KategoriId == kategoriId)
                                                    .Select(x => new
                                                    {
                                                        Category = x.Kategori,
                                                        BookName = x.KitapAdi,
                                                        Phouse = x.Yayinevi,
                                                        User = x.Kullanici,
                                                        Authors = string.Join(", ", x.Yazarlar.Select(y => y.YazarAdi)),
                                                    })
                                                    .ToList();

            dgvAnaEkran.DataSource = kategoriKitaplari.ToList();
        }

        //yazar arama butonu
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
                        Authors = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi)),
                        BookName = k.KitapAdi,
                        Category = k.Kategori,
                        Phouse = k.Yayinevi,
                        User = k.Kullanici,

                    })
                    .ToList();

                dgvAnaEkran.DataSource = kitaplar;
            }
        }

        //Kullanıcı arama butonu
        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtAra.Text.Trim();

            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                var KullaniciKitaplari = context.Kitaplar.Include(x => x.Kullanici).Where(x => x.Kullanici.KullaniciAdi == kullaniciAdi)
                .Select(k => new
                {
                    User = k.Kullanici,
                    BookName = k.KitapAdi,
                    Price = k.Fiyat,
                    NumberOfPrints = k.BaskiSayisi,
                    YearOfPublication = k.BasimYili,
                    CoverText = k.KapakYazisi,
                    Category = k.Kategori,
                    Phouse = k.Yayinevi,
                    Authors = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                })
                .ToList();
                dgvAnaEkran.DataSource = KullaniciKitaplari.ToList();
            }
        }

        //Kitap arama butonu
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
                        User = k.Kullanici,
                        BookName = k.KitapAdi,
                        Price = k.Fiyat,
                        NumberOfPrints = k.BaskiSayisi,
                        YearOfPublication = k.BasimYili,
                        CoverText = k.KapakYazisi,
                        Category = k.Kategori,
                        Phouse = k.Yayinevi,
                        Authors = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                    })
                    .ToList();

                dgvAnaEkran.DataSource = kitaplar;
            }
        }

        //son 10 kitabı getiren buton
        private void btnSonOnKitap_Click(object sender, EventArgs e)
        {
            try
            {
                var sonOnKitap = context.Kitaplar
                    .OrderByDescending(k => k.Id)
                    .Take(10)
                    .Select(k => new
                    {
                        User = k.Kullanici,
                        BookName = k.KitapAdi,
                        Price = k.Fiyat,
                        NumberOfPrints = k.BaskiSayisi,
                        YearOfPublication = k.BasimYili,
                        CoverText = k.KapakYazisi,
                        Category = k.Kategori,
                        Phouse = k.Yayinevi,
                        Authors = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                    })
                    .ToList();

                dgvAnaEkran.DataSource = sonOnKitap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Fetch Data: {ex.Message}");
            }
        }

        //Belirli fiyat aralığında arama butonu
        private void btnFiyatAra_Click(object sender, EventArgs e)
        {
            try
            {
                double minFiyat = double.Parse(txtMin.Text);
                double maxFiyat = double.Parse(txtMax.Text);

                var kitapFiyatlar = context.Kitaplar.Where(k => k.Fiyat >= minFiyat && k.Fiyat <= maxFiyat)
                    .Select(k => new
                    {
                        User = k.Kullanici,
                        BookName = k.KitapAdi,
                        Price = k.Fiyat,
                        NumberOfPrints = k.BaskiSayisi,
                        YearOfPublication = k.BasimYili,
                        CoverText = k.KapakYazisi,
                        Category = k.Kategori,
                        Phouse = k.Yayinevi,
                        Authors = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                    })
                    .ToList();

                dgvAnaEkran.DataSource = kitapFiyatlar;

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid price range..");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Guncelle butonu
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


        //Crud formlarına geçiş butonları
        private void btnKitapCrud_Click(object sender, EventArgs e)
        {
            BookCrud bookCrud = new BookCrud();
            bookCrud.Show();

        }

        private void btnYazarCrud_Click(object sender, EventArgs e)
        {
            AuthorCrud authorCrud = new AuthorCrud();
            authorCrud.Show();
        }

        private void btnYayıneviCrud_Click(object sender, EventArgs e)
        {
            PhouseCrud phouseCrud = new PhouseCrud();
            phouseCrud.Show();
        }

        private void btnKategoriCrud_Click(object sender, EventArgs e)
        {
            CategoryCrud categoryCrud = new CategoryCrud();
            categoryCrud.Show();
        }

        private void btnKullaniciCrud_Click(object sender, EventArgs e)
        {
            UsersCrud usersCrud = new UsersCrud();
            usersCrud.Show();
        }




        //Kitapları yazar adlarıyla dataGridView e getirme metodu
        public void KitaplariDataGridViewGetir()
        {
            var kitaplar = context.Kitaplar
                .Include(k => k.Yazarlar)
                .Select(k => new
                {
                    Id = k.Id,
                    BookName = k.KitapAdi,
                    Price = k.Fiyat,
                    NumberOfPrints = k.BaskiSayisi,
                    YearOfPublication = k.BasimYili,
                    CoverText = k.KapakYazisi,
                    Category = k.Kategori,
                    Phouse = k.Yayinevi,
                    User = k.Kullanici,                   
                    Authors = string.Join(", ", k.Yazarlar.Select(y => y.YazarAdi))
                }).ToList();
            dgvAnaEkran.DataSource = kitaplar;
        }


    }
}
