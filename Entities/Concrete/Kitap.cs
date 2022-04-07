using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kitap : IEntity
    {
        public int KitapId { get; set; }

        public string Ad { get; set; }

        public int SayfaSay { get; set; }

        public int  YazarId { get; set; }

        public int TurId { get; set; }

    }
}
