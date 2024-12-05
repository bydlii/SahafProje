using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Models
{
    internal class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public int BasimYili { get; set; }
        public int BaskiSayisi { get; set; }
        public string? KapakYazisi { get; set; }

        // Navigation property
        public int KategoriId { get; set; }
        public Kategori? Kategori { get; set; }

        public int YayineviId { get; set; }
        public Yayinevi? Yayinevi { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici? Kullanici { get; set; }

        public ICollection<Yazar>? Yazarlar { get; set; }


    }
}
