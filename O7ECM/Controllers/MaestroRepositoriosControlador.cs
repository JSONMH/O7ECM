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
    public class MaestroRepositoriosControlador : Controller
    {
        private ECMEntities db = new ECMEntities();

        // GET: MaestroRepositoriosControlador
        public ActionResult Index()
        {
            return View(db.MaestroRepositorios.ToList());
        }

        // GET: MaestroRepositoriosControlador/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaestroRepositorio maestroRepositorio = db.MaestroRepositorios.Find(id);
            if (maestroRepositorio == null)
            {
                return HttpNotFound();
            }
            return View(maestroRepositorio);
        }

        // GET: MaestroRepositoriosControlador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaestroRepositoriosControlador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoRepositorio,NombreRepositorio,NombreEtiqueta,Direccion,NumeroTelofono,NumeroAnexo")] MaestroRepositorio maestroRepositorio)
        {
            if (ModelState.IsValid)
            {
                db.MaestroRepositorios.Add(maestroRepositorio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maestroRepositorio);
        }

        // GET: MaestroRepositoriosControlador/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaestroRepositorio maestroRepositorio = db.MaestroRepositorios.Find(id);
            if (maestroRepositorio == null)
            {
                return HttpNotFound();
            }
            return View(maestroRepositorio);
        }

        // POST: MaestroRepositoriosControlador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoCompania,CodigoSucursal,CodigoRepositorio,NombreRepositorio,NombreEtiqueta,Direccion,NumeroTelofono,NumeroAnexo")] MaestroRepositorio maestroRepositorio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maestroRepositorio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maestroRepositorio);
        }

        // GET: MaestroRepositoriosControlador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaestroRepositorio maestroRepositorio = db.MaestroRepositorios.Find(id);
            if (maestroRepositorio == null)
            {
                return HttpNotFound();
            }
            return View(maestroRepositorio);
        }

        // POST: MaestroRepositoriosControlador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MaestroRepositorio maestroRepositorio = db.MaestroRepositorios.Find(id);
            db.MaestroRepositorios.Remove(maestroRepositorio);
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
