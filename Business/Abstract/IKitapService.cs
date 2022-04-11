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
        IDataResult<List<Book>> GetAll();

        IResult Add(Book kitap);

        IResult Update(Book kitap);

        IResult Delete(Book kitap);
    }
}
