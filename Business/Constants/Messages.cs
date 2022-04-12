using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Business.Constants
{
    public class Messages
    {
        public static string StudentAdded = "Öğrenci eklendi";

        public static string StudentUpdated = "Öğrenci güncellendi";

        public static string StudentDeleted = "Öğrenci silindi";

        public static string TypeAdded = "Kitap Türü eklendi";

        public static string TypeUpdated = "Kitap Türü güncellendi";

        public static string TypeDeleted = "Kitap Türü silindi";

        public static string ProcessAdded = "İşlem eklendi";

        public static string ProcessUpdated = "İşlem güncellendi";

        public static string ProcessDeleted = "İşlem silindi";

        public static string BookAdded = "Kitap eklendi";

        public static string BookUpdated = "Kitap güncellendi";

        public static string BookDeleted = "Kitap silindi";

        public static string AuthorAdded = "Yazar eklendi";

        public static string AuthorUpdated = "Yazar güncellendi";

        public static string AuthorDeleted = "Yazar silindi";

        public static string UserRegistered = "Kullanıcı Kayıt edildi";

        public static string UserAlreadyExists = "Kullanıcı zaten var";

        public static string AccessTokenCreated = "AccessToken üretildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Hatalı şifre";

        public static string SuccessfulLogin = "Giriş başarılı";
    }
}
