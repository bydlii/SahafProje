using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Configurations
{
    internal class Yayinevi_CFG : IEntityTypeConfiguration<Yayinevi>
    {
        public void Configure(EntityTypeBuilder<Yayinevi> builder)
        {
            builder.HasMany(y => y.Kitaplar)
               .WithOne(k => k.Yayinevi)
               .HasForeignKey(k => k.YayineviId);

            //Yayinevi Veri Ekleme
            builder.HasData(

              new Yayinevi { Id = 1, YayineviAdi = "İş Bankası Kültür Yayınları" },
              new Yayinevi { Id = 2, YayineviAdi = "Koridor Yayıncılık" },
              new Yayinevi { Id = 3, YayineviAdi = "Diyojen Yayıncılık" },
              new Yayinevi { Id = 4, YayineviAdi = "Butik" },
              new Yayinevi { Id = 5, YayineviAdi = "Taze Kitap" },
              new Yayinevi { Id = 6, YayineviAdi = "Timaş Çocuk" },
              new Yayinevi { Id = 7, YayineviAdi = "Everest Yayınları" },
              new Yayinevi { Id = 8, YayineviAdi = "Alfa Yayıncılık" },
              new Yayinevi { Id = 9, YayineviAdi = "Yapı Kredi Yayınları" },
              new Yayinevi { Id = 10, YayineviAdi = "Doğan Kitap" },
              new Yayinevi { Id = 11, YayineviAdi = "Enkitap" },
              new Yayinevi { Id = 12, YayineviAdi = "Gece Kitaplığı" },
              new Yayinevi { Id = 13, YayineviAdi = "Fihrist" },
              new Yayinevi { Id = 14, YayineviAdi = "Eksik Parça Yayınları" },
              new Yayinevi { Id = 15, YayineviAdi = "Doğan Kitap" }
              );
        }
    }
}
