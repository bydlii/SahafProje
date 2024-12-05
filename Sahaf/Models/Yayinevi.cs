using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Models
{
    internal class Yayinevi
    {
        public int Id { get; set; }
        public string YayineviAdi { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }

        public override string ToString()
        {
            return $"{YayineviAdi}";
        }
    }
}
