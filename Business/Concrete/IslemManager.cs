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
    public class IslemManager : IIslemService
    {
         IIslemDal _islemDal;


        public IslemManager(IIslemDal islemDal)
        {
            _islemDal = islemDal;
        }

        public IResult Add(Process islem)
        {
            _islemDal.Add(islem);

            return new SuccessResult(Messages.ProcessAdded);
        }

        public IResult Delete(Process islem)
        {
            _islemDal.Delete(islem);

            return new SuccessResult(Messages.ProcessDeleted);

        }

        public IDataResult<List<Process>> GetAll()
        {
            return new SuccessDataResult<List<Process>>(_islemDal.GetAll());
        }


        public IResult Update(Process islem)
        {
            _islemDal.Update(islem);

            return new SuccessResult(Messages.ProcessUpdated);
        }
    }
}
