using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Security;
using Bullers.DAL.Abstract;
using Bullers.Entity.Concrete;
using Bullers.Interface;

namespace Bullers.BLL.Manager
{
    public class UserManager : IUserService
    {
        IUserDAL _user;

        public UserManager(IUserDAL user)
        {
            _user = user;
        }

        public User getUserByID(int id)
        {
            return _user.getUserByID(id);
        }

        public User getUserFromMail(User user)
        {
            return _user.getUserFromMail(user);
        }

        public User LoginAcc(User user,bool pass)
        {
           var getUser= _user.LoginAcc(user);
            if (getUser != null )
            {
                if (pass == true)
                {
                    FormsAuthentication.SetAuthCookie(getUser.UseEmail, false);
                   
                return getUser;
                }

               
            }

            return null;
        }

        public void LogOut()
        {
            FormsAuthentication.SignOut();
           
        }

        public void RegisterAcc(User user)
        {
            user.Password = Crypto.HashPassword(user.Password);
            
            _user.RegisterAcc(user);
        }

        public void UserUpdate(User user)
        {
            _user.UserUpdate(user);
        }
    }
}
