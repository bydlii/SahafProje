using Sahaf.Data;
using Sahaf.Models;
using Sahaf.Services;
using Sahaf.Utility;
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
    public partial class UsersCrud : Form
    {
        public UsersCrud()
        {
            InitializeComponent();
        }

        //SahafDbContext sınıfından context nesnesi oluşturduk
        SahafDbContext context = new SahafDbContext();

        private void UsersCrud_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            GridViewDuzenleKullanicilar();
        }
        //Ekleme butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            KullaniciRepository kullaniciRepo = new KullaniciRepository(context);
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;

            string parola = txtParola.Text;

            var result = context.Kullanicilar.FirstOrDefault((x => x.KullaniciAdi == txtKullaniciAdi.Text));
            if (result == null)
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                if (!string.IsNullOrEmpty(txtParola.Text))
                {
                    kullanici.Parola = HashUtility.MdFive(txtParola.Text);
                    kullaniciRepo.Guncelle(kullanici);
                    MessageBox.Show("Kullanıcı Eklendi..");
                    GridViewDuzenleKullanicilar();
                    ButtonAktifPasif(false);
                    txtId.Enabled = true;
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Parola Boş Geçilemez..");
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı adı geçersiz!");
            }
        }

        //Guncelle Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciRepository kullaniciRepo = new KullaniciRepository(context);
                Kullanici kullanici = kullaniciRepo.Ara(int.Parse(txtId.Text));
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                if (!string.IsNullOrEmpty(txtParola.Text))
                {
                    kullanici.Parola = HashUtility.MdFive(txtParola.Text);
                    kullaniciRepo.Guncelle(kullanici);
                    MessageBox.Show("Kullanıcı Eklendi..");
                    GridViewDuzenleKullanicilar();
                    ButtonAktifPasif(false);
                    txtId.Enabled = true;
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Parola Boş Geçilemez..");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User could not be updated..");
            }
        }

        //Silme Butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            KullaniciRepository kullaniciRepo = new KullaniciRepository(context);

            DialogResult dr = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                kullaniciRepo.Sil(id);
                GridViewDuzenleKullanicilar();
                Temizle();
                ButtonAktifPasif(false);
                txtId.Enabled = true;

            }
        }

        //Arama Butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                KullaniciRepository kullaniciRepo = new KullaniciRepository(context);
                Kullanici kullanici = kullaniciRepo.Ara(id);
                txtAd.Text = kullanici.Ad;
                txtSoyad.Text = kullanici.Soyad;
                txtKullaniciAdi.Text = kullanici.KullaniciAdi;

                GridViewDuzenleKullanicilar();
                ButtonAktifPasif(true);
                txtId.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Id not found..");
            }

        }

        //Sıfırla Butonu
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            Temizle();
            GridViewDuzenleKullanicilar();
        }

        //İşlevsel Düzenleme metodlarımız
        private void GridViewDuzenleKullanicilar()
        {
            var kitaplar = context.Kullanicilar
                          .Select(x => new
                          {
                              Id = x.Id,
                              UserName = x.KullaniciAdi,
                              Name = x.Ad,
                              Surname = x.Soyad,
                          }).ToList();

            dgvKullanici.DataSource = kitaplar.ToList();
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
            txtKullaniciAdi.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtParola.Clear();
        }
    }
}
