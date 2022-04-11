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
    public class YazarManager : IYazarService
    {
        IYazarDal _yazarDal;

        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }

        public IDataResult<List<Writer>> GetAll()
        {
            return new SuccessDataResult<List<Writer>>(_yazarDal.GetAll());
        }

        public IResult Add(Writer yazar)
        {
            _yazarDal.Add(yazar);

            return new SuccessResult(Messages.AuthorAdded);
        }

        public IResult Update(Writer yazar)
        {
            _yazarDal.Update(yazar);

            return new SuccessResult(Messages.AuthorUpdated);
        }

        public IResult Delete(Writer yazar)
        {
            _yazarDal.Delete(yazar);

            return new SuccessResult(Messages.AuthorDeleted);
        }
    }
}
