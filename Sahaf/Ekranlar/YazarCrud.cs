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
    public partial class YazarCrud : Form
    {
        public YazarCrud()
        {
            InitializeComponent();
        }
        //SahafDbContext sınıfımızdan nesne oluşturduk
        SahafDbContext context = new SahafDbContext();


        //Load
        private void YazarCrud_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            GridViewDuzenleYazarlar();
        }



        //Ekle Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Yazar yazar = new Yazar();
                YazarRepository yazarRepo = new YazarRepository(new Data.SahafDbContext());
                yazar.YazarAdi = txtYazar.Text;
                yazarRepo.Ekle(yazar);
                MessageBox.Show("Yazar Eklendi..");
                GridViewDuzenleYazarlar();
                ButtonAktifPasif(false);
                txtId.Enabled = true;
                txtId.Clear();
                txtYazar.Clear();

            }
            catch (Exception)
            {

                MessageBox.Show("Yazar Eklenemedi..");
            }

        }



        //Guncelle Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                YazarRepository yazarRepo = new YazarRepository(context);
                Yazar yazar = yazarRepo.Ara(id);
                yazar.YazarAdi = txtYazar.Text;
                MessageBox.Show("Yazar Güncellendi..");
                GridViewDuzenleYazarlar();
                txtId.Enabled = true;
                txtId.Clear();
                txtYazar.Clear();
                ButtonAktifPasif(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Yazar Güncellenemedi..");
            }
        }



        //Sil Butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            YazarRepository yazarRepo = new YazarRepository(context);

            DialogResult dr = MessageBox.Show("Emin Misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int YazarId = int.Parse(txtId.Text);
                yazarRepo.Sil(YazarId);
                GridViewDuzenleYazarlar();
                txtId.Clear();
                txtYazar.Clear();
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
                YazarRepository yazarRepo = new YazarRepository(context);
                Yazar yazar = yazarRepo.Ara(id);
                txtYazar.Text = yazar.YazarAdi;
                ButtonAktifPasif(true);
                txtId.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Id bulunamadı..");
            }
        }



        //Ekranı Sıfırla butonu
        private void btnEkraniSifirla_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            txtId.Clear();
            txtYazar.Clear();

            GridViewDuzenleYazarlar();
        }


        //İşlevsel duzenleme metodlarımız
        public void ButtonAktifPasif(bool aktif)
        {
            btnGuncelle.Enabled = aktif;
            btnSil.Enabled = aktif;
            btnEkle.Enabled = !aktif;
            btnAra.Enabled = !aktif;
        }

        public void GridViewDuzenleYazarlar()
        {
            var yazarlar = context.Yazarlar
                          .Include(x => x.Kitaplar)
                          .Select(x => new
                          {
                              Id = x.Id,
                              YazarAdi = x.YazarAdi,
                              Kitaplar = string.Join(", ", x.Kitaplar.Select(y => y.KitapAdi)),

                          }).ToList();
            dgvYazar.DataSource = yazarlar.ToList();
        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
