using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();

        IResult Add(Student student);

        IResult Update(Student student);

        IResult Delete(Student student);
    }
}
