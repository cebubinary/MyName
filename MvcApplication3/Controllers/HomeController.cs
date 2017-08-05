using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            return View(Information.Context.Accounts);
        }

        public ActionResult Add()
        {
           
            return View();
        }
        public ActionResult Save(Account acc)
        {
            Information.Context.Accounts.Add(acc);
            return RedirectToAction("Index");
        }
    }
}
