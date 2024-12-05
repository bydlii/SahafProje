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
    public partial class BookCrud : Form
    {
        public BookCrud()
        {
            InitializeComponent();
        }
        //SahafDbContext sınıfından context nesnesi oluşturduk.
        SahafDbContext context = new SahafDbContext();

        private void BookCrud_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            Temizle();
            ComboBoxTemizle();
            GridViewDuzenleKitaplar();
            cbKategoriler.DataSource = context.Kategoriler.ToList();
            cbKategoriler.ValueMember = "Id";
            cbKategoriler.DisplayMember = "KategoriAdi";

            cbYayinevleri.DataSource = context.Yayinevleri.ToList();
            cbYayinevleri.ValueMember = "Id";
            cbYayinevleri.DisplayMember = "YayinEviAdi";


            clbYazarlar.DataSource = context.Yazarlar.ToList();
            clbYazarlar.ValueMember = "Id";
            clbYazarlar.DisplayMember = "YazarAdi";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = Oturum.AnlikKullanici;

                Kitap kitap = new Kitap()
                {

                    KitapAdi = txtKitapAdi.Text,
                    Fiyat = int.Parse(txtFiyat.Text),
                    BasimYili = int.Parse(txtBasimYili.Text),
                    BaskiSayisi = int.Parse(txtBaskiSayisi.Text),
                    KapakYazisi = txtKapakYazisi.Text,
                    KategoriId = Convert.ToInt32(cbKategoriler.SelectedValue),
                    YayineviId = Convert.ToInt32(cbYayinevleri.SelectedValue),
                    KullaniciId = kullanici.Id,

                };

                YazarRepository yazarRepo = new YazarRepository(context);
                //Yazarların id sini checkedlistbox tan çekip kitap yazarlarına gönderme
                var yazarlarId = new List<int>();
                foreach (Yazar item in clbYazarlar.CheckedItems)
                {
                    yazarlarId.Add(item.Id);
                }

                var yazarlar = new List<Yazar>();
                foreach (int item in yazarlarId)
                {
                    Yazar yazar = yazarRepo.Ara(item);
                    yazarlar.Add(yazar);
                }

                kitap.Yazarlar = yazarlar;

                KitapRepository kitapRepo = new KitapRepository(context);
                kitapRepo.Ekle(kitap);

                MessageBox.Show("Book added..");
                GridViewDuzenleKitaplar();
                Temizle();
                ComboBoxTemizle();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Book could not be added..");
            }

        }

        //Sil Butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            KitapRepository kitapRepo = new KitapRepository(context);

            DialogResult dr = MessageBox.Show("Are you sure", "WARNİNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int kitapiId = int.Parse(txtId.Text);
                kitapRepo.Sil(kitapiId);
                GridViewDuzenleKitaplar();
                Temizle();
                ComboBoxTemizle();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
            }
        }

        //Guncelle Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = Oturum.AnlikKullanici;
                KitapRepository kitapRepo = new KitapRepository(context);
                Kitap kitap = kitapRepo.Ara(int.Parse(txtId.Text));


                kitap.KitapAdi = txtKitapAdi.Text;
                kitap.Fiyat = int.Parse(txtFiyat.Text);
                kitap.BasimYili = int.Parse(txtBasimYili.Text);
                kitap.BaskiSayisi = int.Parse(txtBaskiSayisi.Text);
                kitap.KapakYazisi = txtKapakYazisi.Text;
                kitap.KategoriId = Convert.ToInt32(cbKategoriler.SelectedValue);
                kitap.YayineviId = Convert.ToInt32(cbYayinevleri.SelectedValue);
                kitap.KullaniciId = kullanici.Id;

                YazarRepository yazarRepo = new YazarRepository(context);

                //Yazarları checkedlistbox tan çekip kitap yazarlarına gönderme
                var yazarlarId = new List<int>();
                foreach (Yazar item in clbYazarlar.CheckedItems)
                {
                    yazarlarId.Add(item.Id);
                }

                var yazarlar = new List<Yazar>();
                foreach (int item in yazarlarId)
                {
                    Yazar yazar = yazarRepo.Ara(item);
                    yazarlar.Add(yazar);
                }

                kitap.Yazarlar = yazarlar;

                kitapRepo.Guncelle(kitap);

                MessageBox.Show("Book updated..");
                GridViewDuzenleKitaplar();
                Temizle();
                ButtonAktifPasif(false);
                txtId.Enabled = true;



            }
            catch (Exception)
            {
                MessageBox.Show("Book could not be updated..");
            }
        }


        //Ara Butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                KitapRepository kitapRepo = new KitapRepository(context);
                Kitap kitap = kitapRepo.Ara(id);
                txtKitapAdi.Text = kitap.KitapAdi;
                txtFiyat.Text = kitap.Fiyat.ToString();
                txtBasimYili.Text = kitap.BasimYili.ToString();
                txtBaskiSayisi.Text = kitap.BaskiSayisi.ToString();
                txtKapakYazisi.Text = kitap.KapakYazisi;

                cbKategoriler.SelectedValue = kitap.KategoriId;
                cbYayinevleri.SelectedValue = kitap.YayineviId;
                KitapYazariCBGetir(id);
                GridViewDuzenleKitaplar();
                ButtonAktifPasif(false);

            }
            catch (Exception)
            {
                MessageBox.Show("Id not found..");
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            Temizle();
            ComboBoxTemizle();
            GridViewDuzenleKitaplar();
        }


        //Kitap yazarlarını id ile comboboxta seçili hale getirme
        public void KitapYazariCBGetir(int id)
        {
            var kitapyazar = context.Kitaplar
                       .Include(k => k.Yazarlar)
                       .FirstOrDefault(k => k.Id == id);

            List<int> yazarIdler = new List<int>();
            foreach (var item in kitapyazar.Yazarlar)
            {

                yazarIdler.Add(item.Id);

            }

            for (int i = 0; i < clbYazarlar.Items.Count; i++)
            {

                var yazar = (Yazar)clbYazarlar.Items[i];


                if (yazarIdler.Contains(yazar.Id))
                {
                    clbYazarlar.SetItemChecked(i, true);
                }
                else
                {
                    clbYazarlar.SetItemChecked(i, false);
                }

            }
        }

        //İşlevsel Düzenleme Metodlarımız
        private void GridViewDuzenleKitaplar()
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
            dgvKitaplar.DataSource = kitaplar;
        }
        public void ButtonAktifPasif(bool aktif)
        {
            btnGuncelle.Enabled = aktif;
            btnSil.Enabled = aktif;
            btnEkle.Enabled = !aktif;
            btnAra.Enabled = !aktif;
        }
        public void Temizle()
        {
            txtId.Clear();
            txtKitapAdi.Clear();
            txtKapakYazisi.Clear();
            txtBaskiSayisi.Clear();
            txtBasimYili.Clear();
            txtFiyat.Clear();
        }
        public void ComboBoxTemizle()
        {
            cbKategoriler.SelectedIndex = -1;
            cbYayinevleri.SelectedIndex = -1;
            for (int i = 0; i < clbYazarlar.Items.Count; i++)
            {
                clbYazarlar.SetItemChecked(i, false);
            }
        }

    }
}
