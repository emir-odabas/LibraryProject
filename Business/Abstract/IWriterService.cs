using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWriterService
    {
        IDataResult<List<Writer>> GetAll();

        IResult Add(Writer writer);

        IResult Update(Writer writer);

        IResult Delete(Writer writer);
    }
}
