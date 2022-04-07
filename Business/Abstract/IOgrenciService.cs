using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Abstract.DTOs;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        IDataResult<List<Ogrenci>> GetAll();

        IResult Add(Ogrenci ogrenci);

        IResult Update(Ogrenci ogrenci);

        IResult Delete(Ogrenci ogrenci);
    }
}
