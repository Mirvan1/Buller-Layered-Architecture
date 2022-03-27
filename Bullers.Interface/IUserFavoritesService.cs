﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.Entity.Concrete;

namespace Bullers.Interface
{
   public interface IUserFavoritesService
    {
        void AddToFavorites(UserFavorites fav);
        List<UserFavorites> listUserFav(int id);
        void RemoveAndAddFromFavorites(UserFavorites fav);
    }
}
