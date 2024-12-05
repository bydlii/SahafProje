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
    public partial class PhouseCrud : Form
    {
        public PhouseCrud()
        {
            InitializeComponent();
        }
        //SahafDbContext sınıfımızdan nesne oluşturduk
        SahafDbContext context = new SahafDbContext();

        private void PhouseCrud_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            GridViewDuzenleYayinevleri();
        }

        //Ekle butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Yayinevi yayinevi = new Yayinevi();
                YayineviRepository yayineviRepo = new YayineviRepository(new Data.SahafDbContext());
                yayinevi.YayineviAdi = txtYayinevi.Text;
                yayineviRepo.Ekle(yayinevi);
                MessageBox.Show("Publishing house added..");
                GridViewDuzenleYayinevleri();
                txtId.Enabled = true;
                ButtonAktifPasif(false);
                txtId.Clear();
                txtYayinevi.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Publishing house could not be added..");
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
                MessageBox.Show("Publishing house updated..");
                GridViewDuzenleYayinevleri();              
                txtId.Enabled = true;
                ButtonAktifPasif(false);
                txtId.Clear();
                txtYayinevi.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Publishing house could not be updated..");
            }
        }

        //Sil butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            YayineviRepository yayineviRepo = new YayineviRepository(context);

            DialogResult dr = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("Id not found..");
            }
        }

        //Sıfırla
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

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            ButtonAktifPasif(false);
            txtId.Clear();
            txtYayinevi.Clear();

            GridViewDuzenleYayinevleri();
        }
        public void GridViewDuzenleYayinevleri()
        {
            var kitaplar = context.Yayinevleri
                          .Include(x => x.Kitaplar)
                          .Select(x => new
                          {
                              Id = x.Id,
                              Phouse = x.YayineviAdi,
                              BookNames = string.Join(", ", x.Kitaplar.Select(y => y.KitapAdi)),
                          }).ToList();
            dgvYayinevi.DataSource = kitaplar.ToList();

        }

    }
}
