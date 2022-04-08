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

        
        public IDataResult<List<Kitap>> GetAll()
        {
            return new SuccessDataResult<List<Kitap>>(_kitapDal.GetAll());
        }

        public IResult Add(Kitap kitap)
        {
            _kitapDal.Add(kitap);

            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);

            return new SuccessResult(Messages.BookUpdated);
        }

        public IResult Delete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);

            return new SuccessResult(Messages.BookDeleted);
        }
    }
}
