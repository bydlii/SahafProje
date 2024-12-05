using Sahaf.Data;
using Sahaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Services
{
    internal class KategoriRepository : BaseRepository<Kategori>
    {
        public KategoriRepository(SahafDbContext context) : base(context)
        {
        }
    }
}
