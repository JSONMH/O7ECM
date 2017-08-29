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
    public class ReglasControlador : Controller
    {
        private ECMEntities db = new ECMEntities();

        // GET: ReglasControlador
        public ActionResult Index()
        {
            var reglas = db.Reglas.Include(r => r.Actividades).Include(r => r.Bandeja).Include(r => r.Tramite);
            return View(reglas.ToList());
        }

        // GET: ReglasControlador/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regla regla = db.Reglas.Find(id);
            if (regla == null)
            {
                return HttpNotFound();
            }
            return View(regla);
        }

        // GET: ReglasControlador/Create
        public ActionResult Create()
        {
            ViewBag.CodigoCompania = new SelectList(db.Actividades, "CodigoCompania", "DescripcionActividad");
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja");
            ViewBag.CodigoCompania = new SelectList(db.Tramites, "CodigoCompania", "DescripcionTramite");
            return View();
        }

        // POST: ReglasControlador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoActividad,CodigoTramite,CodigoBandeja,Tiempo_Dia,Tiempo_Hora,Tiempo_Minuto")] Regla regla)
        {
            if (ModelState.IsValid)
            {
                db.Reglas.Add(regla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodigoCompania = new SelectList(db.Actividades, "CodigoCompania", "DescripcionActividad", regla.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja", regla.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.Tramites, "CodigoCompania", "DescripcionTramite", regla.CodigoCompania);
            return View(regla);
        }

        // GET: ReglasControlador/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regla regla = db.Reglas.Find(id);
            if (regla == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodigoCompania = new SelectList(db.Actividades, "CodigoCompania", "DescripcionActividad", regla.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja", regla.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.Tramites, "CodigoCompania", "DescripcionTramite", regla.CodigoCompania);
            return View(regla);
        }

        // POST: ReglasControlador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoActividad,CodigoTramite,CodigoBandeja,Tiempo_Dia,Tiempo_Hora,Tiempo_Minuto")] Regla regla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodigoCompania = new SelectList(db.Actividades, "CodigoCompania", "DescripcionActividad", regla.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.Bandejas, "CodigoCompania", "NombreBandeja", regla.CodigoCompania);
            ViewBag.CodigoCompania = new SelectList(db.Tramites, "CodigoCompania", "DescripcionTramite", regla.CodigoCompania);
            return View(regla);
        }

        // GET: ReglasControlador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regla regla = db.Reglas.Find(id);
            if (regla == null)
            {
                return HttpNotFound();
            }
            return View(regla);
        }

        // POST: ReglasControlador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Regla regla = db.Reglas.Find(id);
            db.Reglas.Remove(regla);
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
