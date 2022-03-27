using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Bullers.Entity.Concrete;
using Bullers.Entity.Concrete.Models;

namespace Bullers.Interface
{
   public interface IProductService
    {
        List<CommonProducts> ListProduct();
        CommonProducts getProduct(int id);
        void AddElectronic(int categoryID, TotalElectronic te,string []imgArr);
        void AddEstate(int categoryID, TotalEstate tes, string[] imgArr);
        void AddPersonel(int CategoryID,TotalPersonel per, string[] imgArr);
        void AddVehicle(int categoryID, TotalVehicle veh, string[] imgArr);

        PersonelProducts getPersonel(int id);
        ElectronicsProduct getElectronic(int id);
        EstateProducts getEstate(int id);
        VehicleProduct getVehicle(int id);
        IQueryable<CommonProducts> ListProductByCategory(string catName);

        List<CommonProducts> listUserProducts(int id);
        void DeleteProduct(int OwnerID, int productID);
    }
}
