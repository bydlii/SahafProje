using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Models
{
    internal class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Parola { get; set; }


        public ICollection<Kitap> Kitaplar { get; set; }

        public override string ToString()
        {
            return $"{KullaniciAdi}";
        }
    }
}
