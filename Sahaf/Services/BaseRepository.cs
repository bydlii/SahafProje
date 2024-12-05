using Microsoft.EntityFrameworkCore;
using Sahaf.Abstracts;
using Sahaf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Services
{
    internal class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected SahafDbContext _SahafDbContext;
        protected DbSet<TEntity> table;
        public BaseRepository(SahafDbContext context)
        {
            _SahafDbContext = context;
            table = context.Set<TEntity>();
        }
        public TEntity Ara(int id)
        {
            return table.Find(id);
        }

        public void Ekle(TEntity entity)
        {
            table.Add(entity);
            _SahafDbContext.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
            table.Update(entity);
            _SahafDbContext.SaveChanges();
        }

        public List<TEntity> Listele()
        {
            return table.ToList();
        }

        public void Sil(int id)
        {
            table.Remove(Ara(id));
            _SahafDbContext.SaveChanges();
        }
    }
}
