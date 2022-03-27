using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using Bullers.BLL.Manager;
using Bullers.DAL.Concrete.EF;
using Bullers.Entity.Concrete;

namespace Bullers.BLL.Caches
{
   public class Cache
    {
        public static IQueryable<CommonProducts> GetCategoriesFromCache(string catName)
        {
            var result = WebCache.Get("product_cache");

            if (result == null)
            {
                ProductManager pm = new ProductManager(new EFProductDAL());
                result = pm.ListProductByCategory(catName);
                WebCache.Set("product_cache", result, 20, true);
            }

            return result;
        }
        public static void RemoveCacheCategory()
        {

            WebCache.Remove("product_cache");
        }
    }
}
