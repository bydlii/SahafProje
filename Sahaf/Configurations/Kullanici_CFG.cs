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
    internal class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasMany(u => u.Kitaplar)
              .WithOne(k => k.Kullanici)
              .HasForeignKey(k => k.KullaniciId);

            //Başlangıç kullanıcı verisi eklendi..
            builder.HasData(
                new Kullanici { Id = 1, Ad = "Sebahattin", Soyad = "Abanaz", KullaniciAdi = "admin", Parola = "81dc9bdb52d04dc20036dbd8313ed055" }
                );

        }
    }
}
