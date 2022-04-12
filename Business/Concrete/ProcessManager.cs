using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProcessManager : IProcessService
    {
         IProcessDal _processDal;


        public ProcessManager(IProcessDal processDal)
        {
            _processDal = processDal;
        }

        public IResult Add(Process process)
        {
            _processDal.Add(process);

            return new SuccessResult(Messages.ProcessAdded);
        }

        public IResult Delete(Process process)
        {
            _processDal.Delete(process);

            return new SuccessResult(Messages.ProcessDeleted);

        }

        public IDataResult<List<Process>> GetAll()
        {
            return new SuccessDataResult<List<Process>>(_processDal.GetAll());
        }


        public IResult Update(Process process)
        {
            _processDal.Update(process);

            return new SuccessResult(Messages.ProcessUpdated);
        }
    }
}
