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
    internal class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasMany(k => k.Kitaplar)
              .WithOne(k => k.Kategori)
              .HasForeignKey(k => k.KategoriId);

            //Kategori Veri Ekleme
            builder.HasData(
           new Kategori { Id = 1, KategoriAdi = "Edebiyat" },
           new Kategori { Id = 2, KategoriAdi = "Roman" },
           new Kategori { Id = 3, KategoriAdi = "Kişisel Gelişim" },
           new Kategori { Id = 4, KategoriAdi = "Çocuk ve Gelişim" },
           new Kategori { Id = 5, KategoriAdi = "Arastırma - Tarih" },
           new Kategori { Id = 6, KategoriAdi = "Yabanci Dilde Kitaplar" },
           new Kategori { Id = 7, KategoriAdi = "Çizgi Roman" },
           new Kategori { Id = 8, KategoriAdi = "Felsefe Kitapları" }
           );

        }
    }
}
