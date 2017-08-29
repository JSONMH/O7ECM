using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using O7ECM.Code;

namespace O7ECM.Controllers
{
    public class BandejasControlador : Controller
    {
        private ECMEntities db = new ECMEntities();

        // GET: BandejasControlador
        public ActionResult Index()
        {
            return View(db.Bandejas.ToList());
        }

        // GET: BandejasControlador/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bandeja bandeja = db.Bandejas.Find(id);
            if (bandeja == null)
            {
                return HttpNotFound();
            }
            return View(bandeja);
        }

        // GET: BandejasControlador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BandejasControlador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoBandeja,NombreBandeja")] Bandeja bandeja)
        {
            if (ModelState.IsValid)
            {
                db.Bandejas.Add(bandeja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bandeja);
        }

        // GET: BandejasControlador/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bandeja bandeja = db.Bandejas.Find(id);
            if (bandeja == null)
            {
                return HttpNotFound();
            }
            return View(bandeja);
        }

        // POST: BandejasControlador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoBandeja,NombreBandeja")] Bandeja bandeja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bandeja).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bandeja);
        }

        // GET: BandejasControlador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bandeja bandeja = db.Bandejas.Find(id);
            if (bandeja == null)
            {
                return HttpNotFound();
            }
            return View(bandeja);
        }

        // POST: BandejasControlador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Bandeja bandeja = db.Bandejas.Find(id);
            db.Bandejas.Remove(bandeja);
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
