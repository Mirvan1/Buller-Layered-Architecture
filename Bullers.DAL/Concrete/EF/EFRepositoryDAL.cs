using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;
using Bullers.Entity;

namespace Bullers.DAL.Concrete.EF
{
   public class EFRepositoryDAL<T> : IRepositoryDAL<T>
    {
        Context c = new Context();

        public void AddData(T t)
        {
            var addedEntity = c.Entry(t);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();

        }

        public void DeleteData(T t)
        {
            var deletedEntity = c.Entry(t);
            deletedEntity.State = EntityState.Deleted;
          
            c.SaveChanges();
        }

      

        public void RemoveData(T t)
        {
            var status = c.Entry(t).Property("Status").IsModified = false;
            c.SaveChanges();
        }

        public void UpdateData(T t)
        {
            var updatedEntity = c.Entry(t);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
