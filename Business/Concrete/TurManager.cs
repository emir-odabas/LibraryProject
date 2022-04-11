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
    public class TurManager : ITurService
    {
        private ITurDal _turDal;

        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }

        public IDataResult<List<Entities.Concrete.Type>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.Type>>(_turDal.GetAll());
        }

        public IResult Add(Entities.Concrete.Type tur)
        {
            _turDal.Add(tur);
            return new SuccessResult(Messages.TypeAdded);
        }

        public IResult Update(Entities.Concrete.Type tur)
        {
            _turDal.Update(tur);

            return new SuccessResult(Messages.TypeUpdated);
        }

        public IResult Delete(Entities.Concrete.Type tur)
        {
            _turDal.Delete(tur);

            return new SuccessResult(Messages.TypeDeleted);
        }
    }
}
