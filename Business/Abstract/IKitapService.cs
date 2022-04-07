using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IKitapService
    {
        IDataResult<List<Kitap>> GetAll();

        IResult Add(Kitap kitap);

        IResult Update(Kitap kitap);

        IResult Delete(Kitap kitap);
    }
}
