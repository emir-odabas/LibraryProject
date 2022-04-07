using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Abstract.DTOs;
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

            return new SuccessResult("İşlem eklendi");
        }

        public IResult Delete(Islem islem)
        {
            _islemDal.Delete(islem);

            return new SuccessResult("İslem silindi");

        }

        public IDataResult<List<Islem>> GetAll()
        {
            return new SuccessDataResult<List<Islem>>(_islemDal.GetAll());
        }

        public List<IslemDetailDto> GetIslemDetails()
        {
            return new List<IslemDetailDto>(_islemDal.GetIslemDetails());
        }

        public IResult Update(Islem islem)
        {
            _islemDal.Update(islem);

            return new SuccessResult("İşlem güncellendi");
        }
    }
}
