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
        IDataResult<List<Yazar>> GetAll();

        IResult Add(Yazar yazar);

        IResult Update(Yazar yazar);

        IResult Delete(Yazar yazar);
    }
}
