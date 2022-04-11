using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
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


        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_ogrenciDal.GetAll());
        }

        public IResult Add(Student ogrenci)
        {
            _ogrenciDal.Add(ogrenci);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IResult Update(Student ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
            return new SuccessResult(Messages.StudentUpdated);
        }

        public IResult Delete(Student ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
            return new SuccessResult(Messages.StudentDeleted);
        }
    }
}
