using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "urun Ismi Gecersiz";
        public static string MaintenanceTime = "Sistem Bakimda";
        public static string ProductListed= "Urunler Listelendi";
        public static string ProductNameAlreadyExists= "Bu urunde baska bir urun var";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 urun olabilir";
        public static string CategoryLimitExceded = "Kategori limiti asildi";
        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
