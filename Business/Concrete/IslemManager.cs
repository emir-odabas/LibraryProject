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

        public IResult Add(Islem islem)
        {
            _islemDal.Add(islem);

            return new SuccessResult(Messages.ProcessAdded);
        }

        public IResult Delete(Islem islem)
        {
            _islemDal.Delete(islem);

            return new SuccessResult(Messages.ProcessDeleted);

        }

        public IDataResult<List<Islem>> GetAll()
        {
            return new SuccessDataResult<List<Islem>>(_islemDal.GetAll());
        }


        public IResult Update(Islem islem)
        {
            _islemDal.Update(islem);

            return new SuccessResult(Messages.ProcessUpdated);
        }
    }
}
