using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Bullers.Entity.Concrete;
using Bullers.Entity.Concrete.Models;

namespace Bullers.DAL.Abstract
{
    public interface IProductDAL
    {
        List<CommonProducts> ListProduct();
        CommonProducts getProduct(int id);

        void AddElectronics(int categoryID, TotalElectronic te,string[]imgArr);
        void AddPersonel(int categoryID,TotalPersonel pp, string[] imgArr);
        void AddEstate(int categoryID, TotalEstate ep, string[] imgArr);
        void AddVehicle(int categoryID, TotalVehicle ev, string[] imgArr);

        PersonelProducts getPersonel(int id);
        ElectronicsProduct getElectronic(int id);
        EstateProducts getEstate(int id);
        VehicleProduct getVehicle(int id);

        IQueryable<CommonProducts> ListProductByCategory(string catName);

        List<CommonProducts> listUserProducts(int id);

        void DeleteProduct(int OwnerID, int productID);
        bool FindProductOwner(int OwnerID,int ProductID);

    }
}
