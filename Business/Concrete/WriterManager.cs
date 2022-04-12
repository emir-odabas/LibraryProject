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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public IDataResult<List<Writer>> GetAll()
        {
            return new SuccessDataResult<List<Writer>>(_writerDal.GetAll());
        }

        public IResult Add(Writer writer)
        {
            _writerDal.Add(writer);

            return new SuccessResult(Messages.AuthorAdded);
        }

        public IResult Update(Writer writer)
        {
            _writerDal.Update(writer);

            return new SuccessResult(Messages.AuthorUpdated);
        }

        public IResult Delete(Writer writer)
        {
            _writerDal.Delete(writer);

            return new SuccessResult(Messages.AuthorDeleted);
        }
    }
}
