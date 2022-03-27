using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;
using Bullers.Entity;
using Bullers.Entity.Concrete;
using Bullers.Interface;

namespace Bullers.BLL.Manager
{
   public class CategoryManager : ICategoryService,IGenericService<Category>
    {
        ICategoryDAL _cat;
        IRepositoryDAL<Category> _repo;

        public CategoryManager(IRepositoryDAL<Category> repo)
        {
            _repo = repo;
        }

        public CategoryManager(ICategoryDAL cat)
        {
            _cat = cat;
        }


        public void AddData(Category t)
        {
            _repo.AddData(t);
        }

        public void DeleteData(Category t)
        {
            _repo.DeleteData(t);
        }

        public Category getCategory(int id)
        {
           return _cat.getCategory(id);
        }

        public List<Category> ListCategory()
        {
            return _cat.ListCategory();
        }

        public List<Category> ListCategoryByName(string catName)
        {
            return _cat.ListCategoryByName(catName);
        }

        public void RemoveData(Category t)
        {
            _repo.RemoveData(t);
        }

        public void UpdateData(Category t)
        {
            _repo.UpdateData(t);
        }
    }
}
