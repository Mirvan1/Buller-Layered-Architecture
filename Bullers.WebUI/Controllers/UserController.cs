using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bullers.BLL.Manager;
using Bullers.DAL.Concrete.EF;
using Bullers.Entity.Concrete;

namespace Bullers.WebUI.Controllers
{
    public class UserController : Controller
    {
        UserFavoritesManager ufm = new UserFavoritesManager(new EFUserFavoritesDAL());
        UserManager um = new UserManager(new EFUserDAL());

        public ActionResult Favorites(int id)
        {
            UserFavorites uf = new UserFavorites();
            uf.ProductID = id;
            
            
            if (Session["userID"] != null)
            {
                uf.UserID = (int)Session["userID"];
                ufm.RemoveAndAddFromFavorites(uf);
                return RedirectToAction("Index", "Main");
            }
            else {
                return RedirectToAction("Index", "Login");
            }
        }



        public ActionResult ListUserFavorites() {
            
            if (Session["userID"] != null)
            {
                int userID = (int)Session["userID"];
                var favs = ufm.listUserFav(userID);
                return View(favs);
            }
            else {
                return RedirectToAction("Index", "Login");
            }
        }


        public ActionResult UserInfo() {
            if (Session["userID"] != null)
            {
                var user = um.getUserByID((int)Session["userID"]);
                return View("UserInfo",user);
            }
            else {
                return RedirectToAction("Index", "Login");

            }
        }

        public ActionResult UserUpdate(User user) {
            if (ModelState.IsValid)
            {
                um.UserUpdate(user);
                return RedirectToAction("Index", "Main");
            }
            return RedirectToAction("UserInfo","User");
        }


       
    }
}