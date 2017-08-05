﻿using System;
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
            // Some comments
            return View(Information.Context.Accounts);
        }

        public ActionResult Add()
        {
           
            return View();
        }
        public ActionResult Save(Account acc)
        {
            var selected = Information.Context.Accounts.FirstOrDefault(x => x.Id == acc.Id);
            if (selected != null)
            {
                //Edit
                selected.Name = acc.Name;
                selected.Age = acc.Age;
            }
            else
            {
                //Add
                acc.Id = Information.Context.TagaiKoUgSunodNaId();
                Information.Context.Accounts.Add(acc);

            }


            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            
            return View(Information.Context.Accounts.FirstOrDefault(x => x.Id == id));
        }
        public ActionResult Delete(int id)
        {
            var selected = Information.Context.Accounts.FirstOrDefault(x => x.Id == id);
            if (selected != null)
            {
                //Remove
                Information.Context.Accounts.Remove(selected);

            }
            return RedirectToAction("Index");
        }
    }
}
