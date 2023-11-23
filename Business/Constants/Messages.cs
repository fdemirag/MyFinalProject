using System;
using Entities.Concrete;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Ürün eklendi";
		public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static List<Product> MaintenanceTime;
        internal static bool ProductsListed;
        //public static string MaintenanceTime = "Sistem bakımda";
        //public static string ProductsListed = "Ürünler listelendi";
    }
}

