using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
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

        public IDataResult<List<Tur>> GetAll()
        {
            return new SuccessDataResult<List<Tur>>(_turDal.GetAll());
        }

        public IResult Add(Tur tur)
        {
            return new SuccessResult("Kitap türü eklendi");
        }

        public IResult Update(Tur tur)
        {
            _turDal.Update(tur);

            return new SuccessResult("Kitap türü güncellendi");
        }

        public IResult Delete(Tur tur)
        {
            _turDal.Delete(tur);

            return new SuccessResult("");
        }
    }
}
