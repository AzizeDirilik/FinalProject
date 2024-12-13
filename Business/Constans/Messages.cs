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
    }
}
