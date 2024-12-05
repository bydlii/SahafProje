using Microsoft.EntityFrameworkCore;
using Sahaf.Data;
using Sahaf.Models;
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

namespace Sahaf.Ekranlar
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        SahafDbContext context = new SahafDbContext();


        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            var kullanici = context.Kullanicilar
               .Where(k => k.KullaniciAdi == kullaniciAdi)
               .FirstOrDefault();
           

            if (kullanici != null && kullanici.Parola == HashUtility.MdFive(parola))
            {
                MessageBox.Show("Giriş Yapıldı.");
                Oturum.AnlikKullanici = kullanici;
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanici adi veya parola yanlış.");
            }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
