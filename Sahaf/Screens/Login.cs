using Sahaf.Data;
using Sahaf.Ekranlar;
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

namespace Sahaf.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SahafDbContext context = new SahafDbContext();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            var kullanici = context.Kullanicilar
               .Where(k => k.KullaniciAdi == kullaniciAdi)
               .FirstOrDefault();
            //kitapVeri.kullaniciId = kullanici.Id;

            if (kullanici != null && kullanici.Parola == HashUtility.MdFive(parola))
            {
                MessageBox.Show("Logged in..");
                Oturum.AnlikKullanici = kullanici;
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
            
        }
    }
}
