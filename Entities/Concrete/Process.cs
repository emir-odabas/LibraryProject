using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Process : IEntity
    {
        public int IslemId { get; set; }

        public int OgrId { get; set; }

        public int KitapId { get; set; }

        public DateTime AlTarih { get; set; }

        public DateTime VerTarih { get; set; }

    }
}
