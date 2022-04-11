using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IIslemService
    {
        IDataResult<List<Process>> GetAll();

        IResult Add(Process islem);

        IResult Update(Process islem);

        IResult Delete(Process islem);
    }
}
