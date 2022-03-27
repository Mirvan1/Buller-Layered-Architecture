using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;
using Bullers.Entity;
using Bullers.Entity.Concrete;

namespace Bullers.DAL.Concrete.EF
{
    public partial class EFCategoryDAL : ICategoryDAL
    {
        Context c = new Context();
        public Category getCategory(int id)
        {
            return c.Category.SingleOrDefault(x => x.CategoryID == id);
        }

        public List<Category> ListCategory()
        {
            return c.Category.ToList();
        }

        public List<Category> ListCategoryByName(string catName)
        {
            return c.Category.Where(x => x.CategoryName == catName).ToList();
        }
    }
}
