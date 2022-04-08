﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IIslemService
    {
        IDataResult<List<Islem>> GetAll();

        IResult Add(Islem islem);

        IResult Update(Islem islem);

        IResult Delete(Islem islem);
    }
}
