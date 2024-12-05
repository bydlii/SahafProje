using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Abstracts
{
    internal interface IBaseRepository<TEntity> where TEntity : class
    {
        public void Ekle(TEntity entity);
        public void Guncelle(TEntity entity);
        public void Sil(int id);
        public TEntity Ara(int id);
        public List<TEntity> Listele();
    }
}
