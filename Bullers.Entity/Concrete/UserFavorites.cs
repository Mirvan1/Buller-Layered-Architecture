using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullers.Entity.Concrete
{
   public class UserFavorites
    {
        [Key]
        public int FavoriteID { get; set; }

        public int UserID { get; set; }
        public virtual User user { get; set; } 

        public int ProductID { get; set; }
        public virtual CommonProducts commonProducts { get; set; }
    }
}
