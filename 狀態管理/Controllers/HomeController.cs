using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 狀態管理.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["name"] = "Test data";
            return RedirectToAction("TempDataDemo");
        }

        public ActionResult TempDataDemo()
        {
            TempData["name"] =
                TempData["name"] + DateTime.Now.ToString();

            return View();
        }
        public ActionResult SessionDemo()
        {
          if (Session["count"] == null)
                Session["count"] = 0;
            else
                //注意轉型，因為還原時本來是obj型別
                Session["count"] = (int)Session["count"] + 1;
            return View();
        }
    }
}