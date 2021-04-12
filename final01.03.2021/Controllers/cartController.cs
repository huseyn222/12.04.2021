using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final01._03._2021.Models;

namespace final01._03._2021.Controllers
{
    public class cartController : Controller
    {
        Entities db = new Entities();

        // GET: cart
        public ActionResult cart()
        {

            return View(db.sati1.ToList());
        }
    }
}