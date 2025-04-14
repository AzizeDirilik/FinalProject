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
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductListedById = "Ürün Id'ye Göre Listelendi";
        public static string ProductDetailsListed = "Ürün Detayları Listelendi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductNameAlreadyExists = "Bu Üründe Başka Bir Ürün var";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 15 Ürün Olabilir";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";

        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string CategoriesById = "Kategori Listelendi";
        public static string CategoryListed = "Kategoriler Listelendi";
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";
        public static string CategoryNameAlreadyExists = "Aynı isimde başka bir kategori bulunmaktadır.";

        public static string CustomersListedById = "Müşteri Id'ye göre listelendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string OrderAdded = "Sipariş Eklendi";
        public static string OrderDeleted = "Sipariş Silindi";
        public static string OrderUpdated = "Sipariş Güncellendi";
        public static string OrdersListed = "Siparişler Listelendi";
        public static string OrdersListedById = "Siparişler Id'ye Göre Listelendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserClaimsListed = "Kullanıcı Rolleri Listelendi";
        public static string UserListedByMail = "Kullanıcı Listelendi";
    }
}
