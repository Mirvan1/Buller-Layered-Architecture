using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Bullers.DAL.Abstract;
using Bullers.Entity.Concrete;
using Bullers.Entity.Concrete.Models;

namespace Bullers.DAL.Concrete.EF
{
    public class EFProductDAL : IProductDAL
    {
        Context c = new Context();
            
        public void AddElectronics(int categoryID, TotalElectronic te,string[] imgArr)
        {
            te.ProductGuid = Guid.NewGuid();
            List<CommonProducts> lcp = new List<CommonProducts>();
            lcp.Add(new CommonProducts(te.ProductID, te.ProductGuid, te.City,te.ProductHeader,
                te.Price, te.Description, te.OwnerName, te.OwnerEmail, te.OwnerPhone, te.OwnerID, categoryID,imgArr[0], imgArr[1], imgArr[2], imgArr[3], imgArr[4], imgArr[5]));
               
          
            List<ElectronicsProduct> lep = new List<ElectronicsProduct>();
            lep.Add(new ElectronicsProduct(te.ElectronicsID, te.ElectronicsName
                , te.ProductID
                ));
                
             c.CommonProducts.Add(lcp[0]);
            c.ElectronicsProduct.Add(lep[0]);
            c.SaveChanges();
        }

        public void AddEstate(int categoryID, TotalEstate ep, string[] imgArr)
        {
            ep.ProductGuid = Guid.NewGuid();
            List<CommonProducts> lcp = new List<CommonProducts>();
            lcp.Add(new CommonProducts(ep.ProductID, ep.ProductGuid, ep.City,ep.ProductHeader,
                ep.Price, ep.Description, ep.OwnerName, ep.OwnerEmail, ep.OwnerPhone,ep.OwnerID, categoryID, imgArr[0], imgArr[1], imgArr[2], imgArr[3], imgArr[4], imgArr[5]));

            List<EstateProducts> lep = new List<EstateProducts>();
            lep.Add(new EstateProducts(ep.EstateID,ep.AdType,ep.Area,ep.totalRoom
                ,ep.ProductID
                ));

            c.CommonProducts.Add(lcp[0]);
            c.EstateProducts.Add(lep[0]);
            c.SaveChanges();
        }

        public void AddPersonel( int categoryID,TotalPersonel ep, string[] imgArr)
        {
            ep.ProductGuid = Guid.NewGuid();
            List<CommonProducts> lcp = new List<CommonProducts>();
            lcp.Add(new CommonProducts(ep.ProductID, ep.ProductGuid, ep.City,ep.ProductHeader,
                ep.Price, ep.Description, ep.OwnerName, ep.OwnerEmail, ep.OwnerPhone,ep.OwnerID, categoryID, imgArr[0], imgArr[1], imgArr[2], imgArr[3], imgArr[4], imgArr[5]));

            List<PersonelProducts> lep = new List<PersonelProducts>();
            lep.Add(new PersonelProducts(ep.PersonelID, ep.ProductSex, ep.ProductName,ep.ProductID));

            c.CommonProducts.Add(lcp[0]);
            c.PersonelProducts.Add(lep[0]);
            c.SaveChanges();
        }

        public void AddVehicle(int categoryID, TotalVehicle ev, string[] imgArr)
        {
            ev.ProductGuid = Guid.NewGuid();
            List<CommonProducts> lcp = new List<CommonProducts>();
            lcp.Add(new CommonProducts(ev.ProductID, ev.ProductGuid, ev.City,ev.ProductHeader,
                ev.Price, ev.Description, ev.OwnerName, ev.OwnerEmail, ev.OwnerPhone, ev.OwnerID, categoryID, imgArr[0], imgArr[1], imgArr[2], imgArr[3], imgArr[4], imgArr[5]));

            List<VehicleProduct> lep = new List<VehicleProduct>();
            lep.Add(new VehicleProduct(ev.VehicleID,ev.VehicleName,ev.VehicleColor,ev.VehicleMotor,ev.VehicleYear
               ,ev.ProductID
                ));

            c.CommonProducts.Add(lcp[0]);
            c.VehicleProduct.Add(lep[0]);
            c.SaveChanges();
        }

        public void DeleteProduct(int OwnerID, int productID)
        {
            var deletedProduct = c.CommonProducts.Find(productID);
            if (deletedProduct != null)
            {
                if (c.CommonProducts.SingleOrDefault(x => x.OwnerID == OwnerID && x.ProductID == productID) != null)
                {
                    c.CommonProducts.Remove(deletedProduct);
                    c.SaveChanges();
                }
            }
        }

        public bool FindProductOwner(int OwnerID,int productID)
        {
            if (c.CommonProducts.Where(x => x.OwnerID == OwnerID && x.ProductID==productID)!=null) {
                return true;
            }
            return false;
        }

        public ElectronicsProduct getElectronic(int id)
        {
            var elect = c.ElectronicsProduct.SingleOrDefault(x => x.ProductID == id);
            return elect;
        }

        public EstateProducts getEstate(int id)
        {
            var est = c.EstateProducts.SingleOrDefault(x => x.ProductID == id);
            return est;
        }

        public PersonelProducts getPersonel(int id)
        {
            var per = c.PersonelProducts.SingleOrDefault(x => x.ProductID == id);
            return per;
        }

        public CommonProducts getProduct(int id)
        {
            return c.CommonProducts.SingleOrDefault(x => x.ProductID == id);
        }

        public VehicleProduct getVehicle(int id)
        {
            var veh = c.VehicleProduct.SingleOrDefault(x => x.ProductID == id);
            return veh;
        }

        public List<CommonProducts> ListProduct()
        {
            return c.CommonProducts.ToList();
        }

        public IQueryable<CommonProducts> ListProductByCategory(string catName)
        {
            var allProducts = from x in c.CommonProducts select x;
            if (!string.IsNullOrEmpty(catName))
            {
                allProducts = allProducts.Where(x => x.Category.CategoryName.Contains(catName));
            }
            return allProducts;
        }

        public List<CommonProducts> listUserProducts(int id)
        {
            return c.CommonProducts.Where(x => x.OwnerID == id).ToList();

        }
    }
}
