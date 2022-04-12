using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper  
    {
        //"SigningCredentials" sisteme girmek için elimizde olanlardır.
        //Security key bize "SigningCredentials" nın imzalama nesnesini döndürendir
        public static SigningCredentials CreateSigningCredentials(SecurityKey securitykey) 
        {
            //Hangi algoritmanın kullanılacağını bildiriyoruz.
            return new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
