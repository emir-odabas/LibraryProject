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
    public class TypeManager : ITypeService
    {
        private ITypeDal _typeDal;

        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = typeDal;
        }

        public IDataResult<List<Entities.Concrete.Type>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.Type>>(_typeDal.GetAll());
        }

        public IResult Add(Entities.Concrete.Type type)
        {
            _typeDal.Add(type);
            return new SuccessResult(Messages.TypeAdded);
        }

        public IResult Update(Entities.Concrete.Type type)
        {
            _typeDal.Update(type);

            return new SuccessResult(Messages.TypeUpdated);
        }

        public IResult Delete(Entities.Concrete.Type type)
        {
            _typeDal.Delete(type);

            return new SuccessResult(Messages.TypeDeleted);
        }
    }
}
