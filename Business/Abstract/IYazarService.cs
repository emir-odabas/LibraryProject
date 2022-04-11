using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IYazarService
    {
        IDataResult<List<Writer>> GetAll();

        IResult Add(Writer yazar);

        IResult Update(Writer yazar);

        IResult Delete(Writer yazar);
    }
}
