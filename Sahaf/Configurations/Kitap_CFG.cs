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
    internal class Kitap_CFG : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder
             .HasMany(k => k.Yazarlar)
             .WithMany(y => y.Kitaplar)
             .UsingEntity<Dictionary<string, object>>(
                 "KitapYazar",
                 j => j.HasOne<Yazar>().WithMany().HasForeignKey("YazarId"),
                 j => j.HasOne<Kitap>().WithMany().HasForeignKey("KitapId")
             );

            builder.HasOne(k => k.Kategori)
                   .WithMany(c => c.Kitaplar)
                   .HasForeignKey(k => k.KategoriId);

            builder.HasOne(k => k.Yayinevi)
                   .WithMany(y => y.Kitaplar)
                   .HasForeignKey(k => k.YayineviId);

            builder.HasOne(k => k.Kullanici)
                   .WithMany(u => u.Kitaplar)
                   .HasForeignKey(k => k.KullaniciId);


           
        }
    }
}
