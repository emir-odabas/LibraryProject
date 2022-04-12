using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;



namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
       

        public IConfiguration Configuration { get; } 
        private TokenOptionss _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptionss").Get<TokenOptionss>();
        //Appsettings.json daki değerleri teker teker  "TokenOptions" daki değerlere atıyor
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)  //CreateToken metotunu implemente ediyoruz.
        {
            //Tokenin süresi ne zaman bitecek ve kaç dakika eklenecek
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration); 
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);//Hangi algoritmayı kullanacağımızı belirtiyor
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);//Bir tane JWT oluşturuyor
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler(); //Oluşturulan jwt yi elde ediyoruz
            var token = jwtSecurityTokenHandler.WriteToken(jwt); //Ve yazdırıyoruz

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptionss tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience, 
                expires: _accessTokenExpiration,//Token sona eriyor
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims), //Kullanıcının claimleri burda 
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)  //Burada Claim listesi oluşturuyoruz
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}

