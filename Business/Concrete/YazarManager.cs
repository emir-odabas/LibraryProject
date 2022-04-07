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
    public class YazarManager : IYazarService
    {
        IYazarDal _yazarDal;

        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }

        public IDataResult<List<Yazar>> GetAll()
        {
            return new SuccessDataResult<List<Yazar>>(_yazarDal.GetAll());
        }

        public IResult Add(Yazar yazar)
        {
            _yazarDal.Add(yazar);

            return new SuccessResult("Yazar eklendi");
        }

        public IResult Update(Yazar yazar)
        {
            _yazarDal.Update(yazar);

            return new SuccessResult("Yazar güncellendi");
        }

        public IResult Delete(Yazar yazar)
        {
            _yazarDal.Delete(yazar);

            return new SuccessResult("Yazar Silindi");
        }
    }
}
