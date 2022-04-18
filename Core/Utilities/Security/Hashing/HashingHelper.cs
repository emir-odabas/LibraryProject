using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    
    //Parola hashlememize yardımcı olucak bu classı oluşturduk
    public class HashingHelper
    {//Out kullanmamın sebebi veri boş bile gelse doldurup verebiliyor
        //Verdiğimiz passwordun salt ve hash ini oluşturduk.
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //Algormatnın Keyi & Her kullanıcı için yenisi üretilir
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//String byte[] değerini almak için burayı oluşturuyoruz
            }

        }

        //Yukarıdaki fonksiyonda bir key üretilecek ve alt tarafta  bu keyleri karşılaştıracağız.
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true; //İki değer birbiri ile eşleşirse true döndürür
        }
    }
}
