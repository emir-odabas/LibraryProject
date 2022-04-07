using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Abstract.DTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIslemDal :EfEntityRepositoryBase<Islem,LibraryContext>,IIslemDal
    {
        

        public List<IslemDetailDto> GetIslemDetails()
        {
            using (LibraryContext Context = new LibraryContext())
            {
                var result = from a in Context.ogrenci
                             join b in Context.islem
                             on a.OgrId equals b.OgrId
                             select new IslemDetailDto()
                    {
                       

                       
                    };
                return result.ToList();
            }
        }
        
    }
}
