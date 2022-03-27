using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.Entity;
using Bullers.Entity.Concrete;

namespace Bullers.Interface
{
   public interface ICategoryService:IGenericService<Category>
    {
        List<Category> ListCategory();
        Category getCategory(int id);
        List<Category> ListCategoryByName(string catName);
    }
}
