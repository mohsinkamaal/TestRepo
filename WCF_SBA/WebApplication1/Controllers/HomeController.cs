using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ServiceReference1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        IsupliermanagerClient proxy = new IsupliermanagerClient();
        public ActionResult Index()
        {
            
           var da= proxy.GetSUPPLIERs();

            return View(da);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost,ValidateInput(true),ValidateAntiForgeryToken]
        public ActionResult Create(SUPPLIER obj) {
            proxy.add(obj);
            return RedirectToAction("Index", "Home");
         }
        public ActionResult Edit(int? id)
        {
            var data = proxy.GetUPPLIER(id.Value);
            return View(data);
        }
        [HttpPost, ValidateInput(true), ValidateAntiForgeryToken]
        public ActionResult Edit(int? id,SUPPLIER obj)
        {
            proxy.update(obj);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Details(int? id)
        {
            var data = proxy.GetUPPLIER(id.Value);
            return View(data);
        }
        public ActionResult delete(int? id)
        {
            var data = proxy.GetUPPLIER(id.Value);
            return View(data);
        }
        [HttpPost, ValidateInput(true), ValidateAntiForgeryToken]
        public ActionResult Delete(int? id, SUPPLIER obj)
        {
            proxy.delete(obj.SUPLNO);
            return RedirectToAction("Index", "Home");
        }





    }
}