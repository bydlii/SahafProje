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
    internal class Yazar_CFG : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder
          .HasMany(y => y.Kitaplar)
          .WithMany(k => k.Yazarlar)
          .UsingEntity<Dictionary<string, object>>(
              "KitapYazar",
              j => j.HasOne<Kitap>().WithMany().HasForeignKey("KitapId"),
              j => j.HasOne<Yazar>().WithMany().HasForeignKey("YazarId")
          );

            //Yazar Veri Ekleme
            builder.HasData(
                  new Yazar { Id = 1, YazarAdi = "Adolf Hitler" },
                  new Yazar { Id = 2, YazarAdi = "Mustafa Kemal Atatürk" },
                  new Yazar { Id = 3, YazarAdi = "Aristoteles" },
                  new Yazar { Id = 4, YazarAdi = "John D. Rockefeller" },
                  new Yazar { Id = 5, YazarAdi = "Ales Kot" },
                  new Yazar { Id = 6, YazarAdi = "Orhan Kemal" },
                  new Yazar { Id = 7, YazarAdi = "Ali Kılıç" },
                  new Yazar { Id = 8, YazarAdi = "Jack London" },
                  new Yazar { Id = 9, YazarAdi = "Sebahattin Ali" },
                  new Yazar { Id = 10, YazarAdi = "Fyodor Mihaylovic Dostoyevsiki" },
                  new Yazar { Id = 11, YazarAdi = "Şermin Yaşar" },
                  new Yazar { Id = 12, YazarAdi = "William Golding" },
                  new Yazar { Id = 13, YazarAdi = "Piere Franckh" },
                  new Yazar { Id = 14, YazarAdi = "James Allen" },
                  new Yazar { Id = 15, YazarAdi = "Henry Cloud" },
                  new Yazar { Id = 16, YazarAdi = "Caroline Myss" },
                  new Yazar { Id = 17, YazarAdi = "Şermin Yaşar" },
                  new Yazar { Id = 18, YazarAdi = "Mert Arık" },
                  new Yazar { Id = 19, YazarAdi = "Duncan Beedie" }
            );
        }
    }
}
