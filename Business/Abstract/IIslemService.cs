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
    public interface IIslemService
    {
        IDataResult<List<Islem>> GetAll();

        List<IslemDetailDto> GetIslemDetails();

        IResult Add(Islem islem);

        IResult Update(Islem islem);

        IResult Delete(Islem islem);
    }
}
