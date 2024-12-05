using Microsoft.EntityFrameworkCore;
using Sahaf.Data;
using Sahaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Services
{
    internal class KitapRepository : BaseRepository<Kitap>
    {
        public KitapRepository(SahafDbContext context) : base(context)
        {
            
        }
        
        
    }
}
