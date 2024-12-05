using Microsoft.EntityFrameworkCore;
using Sahaf.Configurations;
using Sahaf.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Data
{
    internal class SahafDbContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=.;initial catalog=KD22_DbSahaf_Project;integrated security=true;Trust Server certificate=true";
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            


            modelBuilder.ApplyConfiguration(new Kitap_CFG());
            modelBuilder.ApplyConfiguration(new Yazar_CFG());
            modelBuilder.ApplyConfiguration(new Kategori_CFG());
            modelBuilder.ApplyConfiguration(new Yayinevi_CFG());
            modelBuilder.ApplyConfiguration(new Kullanici_CFG());

            base.OnModelCreating(modelBuilder);
        }

    }
}
