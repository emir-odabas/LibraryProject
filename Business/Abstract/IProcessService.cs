using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProcessService
    {
        IDataResult<List<Process>> GetAll();

        IResult Add(Process process);

        IResult Update(Process process);

        IResult Delete(Process process);
    }
}
