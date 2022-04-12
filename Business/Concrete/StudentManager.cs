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
    public class StudentManager :IStudentService
    {
        IStudentDal _studentDal;

      

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }


        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }
    }
}
