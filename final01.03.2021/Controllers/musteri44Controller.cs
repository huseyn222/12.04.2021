using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using final01._03._2021.Models;

namespace final01._03._2021.Controllers
{
    public class musteri44Controller : Controller
    {
        private Entities db = new Entities();

        // GET: musteri44
        public ActionResult Index()
        {
            return View(db.musteri4.ToList());
        }

        // GET: musteri44/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            musteri4 musteri4 = db.musteri4.Find(id);
            if (musteri4 == null)
            {
                return HttpNotFound();
            }
            return View(musteri4);
        }

        // GET: musteri44/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: musteri44/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fotourl,adsoyad,unvan,nomre,haqqinda")] musteri4 musteri4)
        {
            if (ModelState.IsValid)
            {
                db.musteri4.Add(musteri4);
                db.SaveChanges();
                return RedirectToAction("Edit");
            }

            return View(musteri4);
        }

        // GET: musteri44/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            musteri4 musteri4 = db.musteri4.Find(id);
            if (musteri4 == null)
            {
                return HttpNotFound();
            }
            return View(musteri4);
        }

        // POST: musteri44/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fotourl,adsoyad,unvan,nomre,haqqinda")] musteri4 musteri4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musteri4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musteri4);
        }

        // GET: musteri44/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            musteri4 musteri4 = db.musteri4.Find(id);
            if (musteri4 == null)
            {
                return HttpNotFound();
            }
            return View(musteri4);
        }

        // POST: musteri44/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            musteri4 musteri4 = db.musteri4.Find(id);
            db.musteri4.Remove(musteri4);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
