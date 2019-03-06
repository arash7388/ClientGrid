using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Serialization;
using Test.Models;
using ActionResult = System.Web.Mvc.ActionResult;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {

            //var repo = new CustomerRepository();
            var customers = new List<Customer>();
            customers.Add(new Customer()
            {
                Id = 1,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "asdasd",
                LastName = "fgjdfg",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                VisaNo = "432555"

            });

            customers.Add(new Customer()
            {
                Id = 2,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "bbbbbbbbb",
                LastName = "fgjdfg",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"

            });

            customers.Add(new Customer()
            {
                Id = 3,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "ccccccccccccc",
                LastName = "ccccccc",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"

            });

            customers.Add(new Customer()
            {
                Id = 4,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "ddddddddddd",
                LastName = "dddddddd",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });

            customers.Add(new Customer()
            {
                Id = 5,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });

            customers.Add(new Customer()
            {
                Id = 54,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 511,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 523,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 543,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 544,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 553,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 5111,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 587,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 539,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "eeeeeeeeee",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 52,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "zxczxc",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 517,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "uuu",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 5876,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "zzzzzzz",
                LastName = "xxxx",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });
            customers.Add(new Customer()
            {
                Id = 5546,
                InsertDateTime = DateTime.Now,
                BranchId = 1,
                FirstName = "zzzzzzzzzz",
                LastName = "eeeeeeeeee",
                PassportExpDate = DateTime.Today,
                PassportNo = "1233",
                
                VisaNo = "432555"
            });

            Session["GridData"] = customers;
            return View(customers);
        }

        [HttpPost]
        public JsonResult Add(string customerName)
        {
            ((List<Customer>)Session["GridData"]).Add(new Customer()
            {
                FirstName = customerName,
                LastName = customerName
            });

            var renderedView =  PartialView("_Table",(List<Customer>)Session["GridData"]).RenderToString();
            return Json(new { IsSuccess = true, Message = "", Data = renderedView }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            var all = (List<Customer>) Session["GridData"];
            return Json(new { IsSuccess = true, Message = "", Data = all }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var data = (List<Customer>) Session["GridData"];
            var tobeDeleted = data.FirstOrDefault(a => a.Id == id);
            data.Remove(tobeDeleted);

            var renderedView =  PartialView("_Table",data).RenderToString();
            return Json(new { IsSuccess = true, Message = "", Data = renderedView }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Save(List<Customer> model)
        
        {
            return Json(new {IsSuccess=true,Message="Ok"});
        }
    }

    public static class Ext
    {
        public static string RenderToString(this PartialViewResult partialView)
        {
            var httpContext = HttpContext.Current;

            if (httpContext == null)
            {
                throw new NotSupportedException("An HTTP context is required to render the partial view to a string");
            }

            var controllerName = httpContext.Request.RequestContext.RouteData.Values["controller"].ToString();

            var controller = (ControllerBase)ControllerBuilder.Current.GetControllerFactory().CreateController(httpContext.Request.RequestContext, controllerName);

            var controllerContext = new ControllerContext(httpContext.Request.RequestContext, controller);

            var view = ViewEngines.Engines.FindPartialView(controllerContext, partialView.ViewName).View;

            var sb = new StringBuilder();

            using (var sw = new StringWriter(sb))
            {
                using (var tw = new HtmlTextWriter(sw))
                {
                    view.Render(new ViewContext(controllerContext, view, partialView.ViewData, partialView.TempData, tw), tw);
                }
            }

            return sb.ToString();
        }
    }
}