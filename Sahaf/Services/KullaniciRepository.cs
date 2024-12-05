using Sahaf.Data;
using Sahaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Services
{
    internal class KullaniciRepository : BaseRepository<Kullanici>
    {
        public KullaniciRepository(SahafDbContext context) : base(context)
        {
        }
    }
}
