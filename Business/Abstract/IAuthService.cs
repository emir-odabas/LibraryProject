using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Abstract.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService   //Bu servis sayesinde sisteme login veya register olunucak
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IResult UserExists(string email); //Kullanıcının daha önceden bir kayıtı varmı kontrol edilecek

        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
