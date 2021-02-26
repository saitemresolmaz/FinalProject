using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";  // değişken publicse pascalCase yaparız. (Baş harfi büyük!)
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün limitini aştınız";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni bir ürün eklenemiyor";
    }
}
