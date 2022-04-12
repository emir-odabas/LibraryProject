using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int KitapId { get; set; }

        public string Ad { get; set; }

        public int SayfaSay { get; set; }

        public int  YazarId { get; set; }

        public int TurId { get; set; }

    }
}
