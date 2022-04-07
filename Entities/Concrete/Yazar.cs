using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Yazar :IEntity
    {
        public int YazarId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

    }
}
