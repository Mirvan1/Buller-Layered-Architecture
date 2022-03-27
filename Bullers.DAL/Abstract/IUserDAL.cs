using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.Entity.Concrete;

namespace Bullers.DAL.Abstract
{
   public interface IUserDAL
    {
        User LoginAcc(User user);
        
        void RegisterAcc(User user);
        User getUserFromMail(User user);
        User getUserByID(int id);
        void UserUpdate(User user);
    }
}
