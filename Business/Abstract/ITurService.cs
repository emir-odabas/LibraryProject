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
        IDataResult<List<Entities.Concrete.Type>> GetAll();

        IResult Add(Entities.Concrete.Type tur);

        IResult Update(Entities.Concrete.Type tur);

        IResult Delete(Entities.Concrete.Type tur);
    }
}
