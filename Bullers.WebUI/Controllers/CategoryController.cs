using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bullers.BLL.Manager;
using Bullers.DAL.Abstract;
using Bullers.DAL.Concrete.EF;
using Bullers.Entity;
using Bullers.Entity.Concrete;
using Bullers.Entity.Concrete.Models;

namespace Bullers.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager cm = new CategoryManager(new EFRepositoryDAL<Category>());
        private CategoryManager cc = new CategoryManager(new EFCategoryDAL());
        private ProductManager pm = new ProductManager(new EFProductDAL());

        // GET: Category
        public ActionResult Index()
        {
          var  listCategory = cc.ListCategory();
            return View(listCategory);
        } 
        [HttpGet]
        public ActionResult AddData() {
            return View();
        }

        [HttpPost]
        public ActionResult AddData(Category c) {
            cm.AddData(c);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTotal() {
            return View();
        }

        [HttpPost]
        public ActionResult AddTotal(string id,Total te) {
            // pm.AddElectronic(te);
          //  pm.addTotal(id, te);
            return RedirectToAction("Index");
        }
    }
}