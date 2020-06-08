using Shop.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Shop
    {
        public static string path = @"E:\codegym\Module2\MenuArray\Shop\Data\";
        public static string dbName = "database.json";
        public ShopService shopService = new ShopService(path, dbName);
    }
}
