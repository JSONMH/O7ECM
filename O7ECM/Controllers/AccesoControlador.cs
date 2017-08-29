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
    public class AccesoControlador : Controller
    {
        private ECMEntities db = new ECMEntities();

        // GET: AccesoControlador
        public ActionResult Index()
        {
            var accesos = db.Accesos.Include(a => a.Bandeja).Include(a => a.MestroRepositorio);
            return View(accesos.ToList());
        }

        // GET: AccesoControlador/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acceso acceso = db.Accesos.Find(id);
            if (acceso == null)
            {
                return HttpNotFound();
            }
            return View(acceso);
        }

        // GET: AccesoControlador/Create
        public ActionResult Create()
        {
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja");
            ViewBag.CodigoCompania = new SelectList(db.MaestroRepositorios, "CodigoCompania", "NombreRepositorio");
            return View();
        }

        // POST: AccesoControlador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoUsuario,Codigorepositorio,Codigobandeja,NivelAcceso")] Acceso acceso)
        {
            if (ModelState.IsValid)
            {
                db.Accesos.Add(acceso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja", acceso.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.MaestroRepositorios, "CodigoCompania", "NombreRepositorio", acceso.CodigoCompania);
            return View(acceso);
        }

        // GET: AccesoControlador/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acceso acceso = db.Accesos.Find(id);
            if (acceso == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja", acceso.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.MaestroRepositorios, "CodigoCompania", "NombreRepositorio", acceso.CodigoCompania);
            return View(acceso);
        }

        // POST: AccesoControlador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoUsuario,Codigorepositorio,Codigobandeja,NivelAcceso")] Acceso acceso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acceso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja", acceso.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.MaestroRepositorios, "CodigoCompania", "NombreRepositorio", acceso.CodigoCompania);
            return View(acceso);
        }

        // GET: AccesoControlador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acceso acceso = db.Accesos.Find(id);
            if (acceso == null)
            {
                return HttpNotFound();
            }
            return View(acceso);
        }

        // POST: AccesoControlador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Acceso acceso = db.Accesos.Find(id);
            db.Accesos.Remove(acceso);
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
