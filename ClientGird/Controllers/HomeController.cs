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
            var customers = new List<Customer>();
            
            var rnd = new Random(1);

            for (int i = 0; i < 15; i++)
            {
                customers.Add(new Customer()
                {
                    Id = i+1,
                    InsertDateTime = DateTime.Now.AddDays(rnd.Next(10,50)),
                    BranchId = rnd.Next(1000),
                    FirstName = "Fname " + (i+1),
                    LastName = "Lname " + (i+1),
                    PassportExpDate = DateTime.Now.AddDays(rnd.Next(2000)),
                    PassportNo = rnd.Next(1000).ToString()
                }); 
            }
            
            TempData["GridData"] = customers;
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