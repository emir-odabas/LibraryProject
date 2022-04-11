﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        IDataResult<List<Student>> GetAll();

        IResult Add(Student ogrenci);

        IResult Update(Student ogrenci);

        IResult Delete(Student ogrenci);
    }
}
