using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Bullers.DAL.Abstract;
using Bullers.Entity.Concrete;
using Bullers.Entity.Concrete.Models;
using Bullers.Interface;
using Bullers.BLL.Caches;

namespace Bullers.BLL.Manager
{
    public class ProductManager : IProductService
    {
        IProductDAL _pro;

        public ProductManager(IProductDAL pro)
        {
            _pro = pro;
        }

        public void AddElectronic(int categoryID, TotalElectronic te,string [] imgArr)
        {
            _pro.AddElectronics( categoryID, te,imgArr);
        }

        public void AddEstate(int categoryID, TotalEstate tes, string[] imgArr)
        {
            _pro.AddEstate( categoryID, tes, imgArr);
        }

        public CommonProducts getProduct(int id)
        {
            return _pro.getProduct(id);
        }

        public List<CommonProducts> ListProduct()
        {
            return _pro.ListProduct();
        }

        public void addTotal(string adType,Total te, string[] imgArr)
        {
            int categoryID = Int32.Parse(adType);
           

            if (adType == "2")
            {
                List<TotalElectronic> tel = new List<TotalElectronic>();
                tel.Add(new TotalElectronic(te.ProductID, te.ProductGuid, te.City,te.ProductHeader,
                te.Price, te.Description, te.OwnerName, te.OwnerEmail, te.OwnerPhone, te.OwnerID, categoryID, te.ElectronicsName));
                AddElectronic(categoryID, tel[0],imgArr);
            }
            else if (adType == "4")
            {
                List<TotalEstate> ep = new List<TotalEstate>();
                ep.Add(new TotalEstate(te.ProductID, te.ProductGuid, te.City,te.ProductHeader,
                te.Price, te.Description, te.OwnerName, te.OwnerEmail, te.OwnerPhone, te.OwnerID, categoryID,
                te.AdType, te.Area, te.totalRoom));
                AddEstate(categoryID, ep[0],imgArr);

            }
            else if (adType == "1")
            {
                List<TotalPersonel> tp = new List<TotalPersonel>();
                tp.Add(new TotalPersonel(te.ProductID, te.ProductGuid, te.City,te.ProductHeader, te.Price, te.Description, te.OwnerName,
                    te.OwnerEmail, te.OwnerPhone, te.OwnerID, categoryID, te.ProductSex, te.ProductName));
                AddPersonel(categoryID,tp[0],imgArr);
               
            }
            else if (adType == "3") {
                List<TotalVehicle> tv = new List<TotalVehicle>();
                tv.Add(new TotalVehicle(te.ProductID, te.ProductGuid, te.City,te.ProductHeader, te.Price, te.Description, te.OwnerName,
                    te.OwnerEmail, te.OwnerPhone, te.OwnerID, categoryID, te.VehicleID, te.VehicleName, te.VehicleColor, te.VehicleMotor, te.VehicleYear));
                AddVehicle(categoryID, tv[0],imgArr);
            }
        }

        public IQueryable<CommonProducts> ListProductByCategory(string catName)
        {
            return _pro.ListProductByCategory(catName);
        }

        public void AddPersonel(int categoryID, TotalPersonel per, string[] imgArr)
        {
            _pro.AddPersonel(categoryID, per, imgArr);
        }

        public void AddVehicle(int categoryID, TotalVehicle veh, string[] imgArr)
        {
            _pro.AddVehicle( categoryID, veh,imgArr);
        }

        public PersonelProducts getPersonelByCategory(int id) {
            var product = getProduct(id);
            var per = getPersonel(product.ProductID);
            return per;

        }


        public ElectronicsProduct getElectronicByCategory(int id)
        {
            var product = getProduct(id);
            var elect = getElectronic(product.ProductID);
            return elect;

        }

        public EstateProducts getEstateByCategory(int id)
        {
            var product = getProduct(id);
            var est = getEstate(product.ProductID);
            return est;

        }

        public VehicleProduct getVehicleByCategory(int id)
        {
            var product = getProduct(id);
            var veh = getVehicle(product.ProductID);
            return veh;

        }

       


        public PersonelProducts getPersonel(int id)
        {
          return  _pro.getPersonel(id);
        }

        public ElectronicsProduct getElectronic(int id)
        {
          return  _pro.getElectronic(id);
        }

        public EstateProducts getEstate(int id)
        {
            return _pro.getEstate(id);
        }

        public VehicleProduct getVehicle(int id)
        {
            return _pro.getVehicle(id);
        }

        public List<CommonProducts> listUserProducts(int id)
        {
            return _pro.listUserProducts(id);
        }

        public void DeleteProduct(int OwnerID, int productID)
        {
            _pro.DeleteProduct(OwnerID,productID);
        }
    }
}
