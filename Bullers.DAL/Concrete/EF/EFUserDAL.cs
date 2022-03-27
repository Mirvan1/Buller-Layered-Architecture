using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using Bullers.DAL.Abstract;
using Bullers.Entity.Concrete;

namespace Bullers.DAL.Concrete.EF
{
    public class EFUserDAL : IUserDAL
    {
        Context c = new Context();

        public User getUserByID(int id)
        {
            return c.User.Find(id);
        }

        public User getUserFromMail(User user)
        {
            return c.User.FirstOrDefault(x => x.UseEmail == user.UseEmail);
        }

        public User LoginAcc(User user)
        {
            return c.User.FirstOrDefault(x => x.UseEmail == user.UseEmail );       
        }

      

        public void RegisterAcc(User user)
        {
            var userControl = c.User.FirstOrDefault(x => x.UseEmail == user.UseEmail);
           
            if (userControl == null && user != null)
            {


                c.User.Add(user);
                c.SaveChanges();
            }

            
        }

        public void UserUpdate(User user)
        {
            var findUser = c.User.Find(user.UserID);
            if (findUser != null)
            {
                findUser.UseEmail = user.UseEmail;
                findUser.Username = user.Username;
                c.SaveChanges();
            }
            
        }
    }
}
