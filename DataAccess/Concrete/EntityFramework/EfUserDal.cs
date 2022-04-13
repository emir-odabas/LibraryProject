using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, LibraryContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new LibraryContext())
            {
                var result = from opc in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on opc.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim {Id = opc.Id, Name = opc.Name};
                return result.ToList();


            }
        }
    }
}
