using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using Bullers.BLL.Manager;
using Bullers.DAL.Concrete.EF;
using Bullers.Entity.Concrete;

namespace Bullers.WebUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        UserManager um = new UserManager(new EFUserDAL());
     

        [HttpGet]
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
          
            if (ModelState.IsValid)
            { 
                var foundUser = um.getUserFromMail(user);
                
                if (foundUser == null) {
                    TempData["userRegister"] = 1;


                    return View();

               
                }
                bool checkPassword = Crypto.VerifyHashedPassword(foundUser.Password, user.Password);

                var umUser = um.LoginAcc(user,checkPassword);
                if (umUser != null && umUser.UseEmail != null && checkPassword)
                {
                    Session["userMail"] = umUser.UseEmail;
                    Session["userName"] = umUser.Username;
                    Session["userID"] = umUser.UserID;
                    return RedirectToAction("Index", "Main");
                }
    
              
                else
                {
                    return View();
                }
            }
            return View();

        }


        [HttpGet]
        public ActionResult Register() {

            return View();

        }

        [HttpPost]
        public ActionResult Register(User user) {
        
            TempData["userRegister"]= 0;
            if (ModelState.IsValid)
            {
                um.RegisterAcc(user);
                Session["userMail"] = user.UseEmail;
                Session["userName"] = user.Username;
                return RedirectToAction("Index", "Main");
            }
           
                return View();

            
        }


        public ActionResult Logout() {
               um.LogOut();
            HttpContext.Request.Cookies.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Login");

        }
    }
}