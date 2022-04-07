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
    public class OgrenciManager :IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }


        public IDataResult<List<Ogrenci>> GetAll()
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll());
        }

        public IResult Add(Ogrenci ogrenci)
        {
            _ogrenciDal.Add(ogrenci);
            return new SuccessResult("Eklendi");
        }

        public IResult Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
            return new SuccessResult("Güncellendi");
        }

        public IResult Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
            return new SuccessResult("Silindi");
        }
    }
}
