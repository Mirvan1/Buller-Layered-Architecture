using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Concrete;
using Bullers.Entity.Concrete;

namespace Bullers.DAL.Abstract
{
    public interface ICategoryDAL
    {
        List<Category> ListCategory();
        Category getCategory(int id);
        List<Category> ListCategoryByName(string catName);
    }
}
