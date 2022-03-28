using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bullers.DAL;

namespace Bullers.WebUI.Logs
{
    public class ProductVIewerLogs : FilterAttribute, IActionFilter
    {
        Context c = new Context();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            c.ProductLogs.Add(new Entity.Concrete.ProductLogs
            {
                ActionName = filterContext.ActionDescriptor.ActionName,
                ProductID =Convert.ToInt32(filterContext.Controller.ValueProvider.GetValue("id").AttemptedValue),
                DateTime = filterContext.HttpContext.Timestamp,
                Info = "OnActionExecuted",
                ViewerMail =filterContext.HttpContext.User.Identity.Name

            }) ;
            c.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                c.ProductLogs.Add(new Entity.Concrete.ProductLogs
                {
                    ActionName = filterContext.ActionDescriptor.ActionName,
                    ProductID = Convert.ToInt32(filterContext.Controller.ValueProvider.GetValue("id").AttemptedValue),
                    DateTime = filterContext.HttpContext.Timestamp,
                    Info = "OnActionExecuting",
                    ViewerMail = filterContext.HttpContext.User.Identity.Name

                });
                c.SaveChanges();
            }
            catch (DbEntityValidationException ex) {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
            
            }
    }
}