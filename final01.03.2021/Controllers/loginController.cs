

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final01._03._2021.Models;

namespace final01._03._2021.Areas.admin1.Controllers
{


    public class loginController : Controller
    {
        Entities db = new Entities();
        // GET: admin1/admin
        public ActionResult Login2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login2(login adm1)
        {

            login admi1 = db.logins.FirstOrDefault(x => x.email == adm1.email);
            if (admi1 != null)
            {
                if (admi1.parol == adm1.parol)
                {
                    Session["add"] = admi1;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}