using Sahaf.Data;
using Sahaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Services
{
    internal class YayineviRepository : BaseRepository<Yayinevi>
    {
        public YayineviRepository(SahafDbContext context) : base(context)
        {
        }
    }
}
