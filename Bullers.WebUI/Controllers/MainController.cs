using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bullers.BLL.Caches;
using Bullers.BLL.Manager;
using Bullers.DAL;
using Bullers.DAL.Concrete.EF;
using Bullers.Entity.Concrete;
using Bullers.Entity.Concrete.Models;
using Bullers.WebUI.Logs;

namespace Bullers.WebUI.Controllers
{
    public class MainController : Controller
    {

        ProductManager pm = new ProductManager(new EFProductDAL());
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        UserFavoritesManager ufm = new UserFavoritesManager(new EFUserFavoritesDAL());
        LogsManager lm = new LogsManager(new EFLogsDAL());
        // GET: Main
        [HttpGet]
        public ActionResult Index(string catName)
        {
            var list = Cache.GetCategoriesFromCache(catName);
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult AddItem() {
           
            return View();
        }


        [HttpPost]
        public ActionResult AddItem(string CategoryID, Total te,IEnumerable<HttpPostedFileBase> imagePath) {
            string[] imgArr = new string[6];
             int count = 0;
            ModelState.Remove("ProductID");
            if (ModelState.IsValid)
            {
                foreach (var x in imagePath)
                {
                    try
                    {
                        if (x.ContentLength > 0)
                        {

                            string fileName = Path.GetFileName(x.FileName);
                            string extFile = Path.GetExtension(x.FileName);
                            string pathOfFile = "/Content/Sources/" + fileName;
                            x.SaveAs(Server.MapPath(pathOfFile));

                            if (pathOfFile != null)
                            {
                                imgArr[count] = pathOfFile;

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("You have to upload photos", ex.Message);
                    }


                    count++;
                }
                te.OwnerID = (int?)Session["UserID"];
                try
                {
                    pm.addTotal(CategoryID, te, imgArr);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Please choose category types", ex.Message);
                }
               Cache.RemoveCacheCategory();
                return RedirectToAction("Index");
            }
            else {
                return View();
            }

        }


     

        [ProductVIewerLogs]
        public ActionResult PersonelView(int id) {
            int viewerNum = lm.CountProductViews(id);
            ViewBag.viewNum = viewerNum;
            return View("PersonelView", pm.getPersonelByCategory(id));
        }


        [ProductVIewerLogs]
        public ActionResult ElectronicsView(int id) {
            int viewerNum = lm.CountProductViews(id);
            ViewBag.viewNum = viewerNum;
            return View("ElectronicsView", pm.getElectronicByCategory(id));
        }

        [ProductVIewerLogs]
        public ActionResult EstateView(int id) {
            int viewerNum = lm.CountProductViews(id);
            ViewBag.viewNum = viewerNum;
            return View("EstateView", pm.getEstateByCategory(id));
        }


        [ProductVIewerLogs]
        public ActionResult VehicleView(int id)
        {
            int viewerNum = lm.CountProductViews(id);
            ViewBag.viewNum = viewerNum;
            return View("VehicleView", pm.getVehicleByCategory(id));
        }

        public ActionResult UserAds() {
            int id = (int)Session["UserID"];
            var userProducts = pm.listUserProducts(id);
            return View(userProducts);
        }

        public ActionResult DeleteProduct(int id) {
            int userID =(int) Session["UserID"];
            
                pm.DeleteProduct(userID, id);
                return RedirectToAction("Index", "Main");
            
           // return View();
        }

        public ActionResult Error404() {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
           Cache.RemoveCacheCategory();
            return View();
        }
    }
}