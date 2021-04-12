﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final01._03._2021.Models;

namespace final01._03._2021.Controllers
{

    public class HomeController : Controller
    {

        Entities db = new Entities();

        public ActionResult Index()
        {

            ViewBag.header2 = db.slide1.First();
            ViewBag.satis2 = db.sati1.ToList();

            return View("Index");


        }
        public ActionResult huseyn1()
        {
            return View(db.sati1.ToList());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();


        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}