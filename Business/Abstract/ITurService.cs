using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITurService
    {
        IDataResult<List<Tur>> GetAll();

        IResult Add(Tur tur);

        IResult Update(Tur tur);

        IResult Delete(Tur tur);
    }
}
