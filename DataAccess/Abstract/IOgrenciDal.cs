using Core.DataAccess;
using Entities.Abstract.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOgrenciDal : IEntityRepository<Ogrenci>
    {
        
    }
}
