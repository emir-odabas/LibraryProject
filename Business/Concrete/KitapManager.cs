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
    public class KitapManager :IKitapService
    {
         IKitapDal _kitapDal;

        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        
        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_kitapDal.GetAll());
        }

        public IResult Add(Book kitap)
        {
            _kitapDal.Add(kitap);

            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Update(Book kitap)
        {
            _kitapDal.Update(kitap);

            return new SuccessResult(Messages.BookUpdated);
        }

        public IResult Delete(Book kitap)
        {
            _kitapDal.Delete(kitap);

            return new SuccessResult(Messages.BookDeleted);
        }
    }
}
