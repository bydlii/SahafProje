using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Models
{
    internal class Yazar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }

        // Navigation property
        public ICollection<Kitap>? Kitaplar { get; set; }
        

    }
}
