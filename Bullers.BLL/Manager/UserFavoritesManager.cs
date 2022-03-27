using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;
using Bullers.Entity.Concrete;
using Bullers.Interface;

namespace Bullers.BLL.Manager
{
    public class UserFavoritesManager : IUserFavoritesService
    {
        IUserFavoritesDAL _fav;
        public UserFavoritesManager(IUserFavoritesDAL fav)
        {
            _fav = fav;
        }
        public void AddToFavorites(UserFavorites fav)
        {
            _fav.AddToFavorites(fav);
        }

        public List<UserFavorites> listUserFav(int id)
        {
          return  _fav.listUserFav(id);
        }

        public void RemoveAndAddFromFavorites(UserFavorites fav)
        {
            _fav.RemoveAndAddFromFavorites(fav);
        }
    }
}
