using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using final01._03._2021.Models;

namespace final01._03._2021.Controllers
{
    public class detailController : Controller
    {
        private Entities db = new Entities();

        // GET: detail
        public async Task<ActionResult> Index()
        {
            return View(await db.sati1.ToListAsync());
        }

        // GET: detail/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sati1 sati1 = await db.sati1.FindAsync(id);
            if (sati1 == null)
            {
                return HttpNotFound();
            }
            return View(sati1);
        }

        [HttpPost]
        public  ActionResult Details ( string adsoyad,string unvan,string nomre,string haqqinda, string photourl)
        {
            musteri4 musteri4 = new musteri4();
            if (ModelState.IsValid)
            {
                musteri4.adsoyad = adsoyad;
                musteri4.unvan = unvan;
                musteri4.nomre = Convert.ToInt32(nomre);
                musteri4.haqqinda = haqqinda;
                musteri4.fotourl = photourl;
                db.musteri4.Add(musteri4);
                 db.SaveChanges();
                return RedirectToAction("details");
            }

            return RedirectToAction("details");

        }



        // GET: detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,photourl,soz1,qiymet,haqqinda8,Marka")] sati1 sati1)
        {
            if (ModelState.IsValid)
            {
                db.sati1.Add(sati1);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sati1);
        }

        // GET: detail/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sati1 sati1 = await db.sati1.FindAsync(id);
            if (sati1 == null)
            {
                return HttpNotFound();
            }
            return View(sati1);
        }

        // POST: detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,photourl,soz1,qiymet,haqqinda8,Marka")] sati1 sati1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sati1).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sati1);
        }

        // GET: detail/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sati1 sati1 = await db.sati1.FindAsync(id);
            if (sati1 == null)
            {
                return HttpNotFound();
            }
            return View(sati1);
        }

        // POST: detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            sati1 sati1 = await db.sati1.FindAsync(id);
            db.sati1.Remove(sati1);
            await db.SaveChangesAsync();
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
