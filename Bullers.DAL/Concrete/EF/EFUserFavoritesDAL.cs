using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;
using Bullers.Entity.Concrete;

namespace Bullers.DAL.Concrete.EF
{
    public class EFUserFavoritesDAL : IUserFavoritesDAL
    {
        Context c = new Context();
        public void AddToFavorites(UserFavorites fav)
        {
            
            c.UserFavorites.Add(fav);
            c.SaveChanges();
        }

        public List<UserFavorites> listUserFav(int id)
        {
            return c.UserFavorites.Where(c => c.UserID ==id ).ToList();
        }

        public void RemoveAndAddFromFavorites(UserFavorites fav)
        {
            var favedProduct = c.UserFavorites.SingleOrDefault(x=>x.ProductID==fav.ProductID && x.UserID==fav.UserID);
            if (favedProduct != null ) {
                c.UserFavorites.Remove(favedProduct);
                c.SaveChanges();
            }
            else
            {
                c.UserFavorites.Add(fav);
                c.SaveChanges();
            }
        }
    }
}
