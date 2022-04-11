using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{ 
    public class Type : IEntity
    {
        public int TurId { get; set; }

        public string Ad { get; set; }

    }
}
