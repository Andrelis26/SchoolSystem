using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;

namespace SchoolSystem.Controllers
{
    public class CalificacionesController : Controller
    {
        private SistemaEscolarEntities db = new SistemaEscolarEntities();

        // GET: Calificaciones
        public ActionResult Index()
        {
            var calificaciones = db.Calificaciones.Include(c => c.Materias).Include(c => c.Profesor).Include(c => c.Estudiante);
            var Student = db.Calificaciones.ToList().Where(x => x.Id_Estudiante == Convert.ToInt32(Session["ID_Estudiante"]));
            ViewBag.Student = Student;
            return View(calificaciones.ToList());
        }

        // GET: Calificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        // GET: Calificaciones/Create
        public ActionResult Create()
        {
            ViewBag.Id_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion");
            ViewBag.Id_Profesor = new SelectList(db.Profesor, "ID_Profesor", "Nombres");
            ViewBag.Id_Estudiante = new SelectList(db.Estudiante, "ID_Estudiante", "Primer_Nombre");
            return View();
        }

        // POST: Calificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_Estudiante,Id_Materia,Id_Profesor,Nota")] Calificaciones calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Calificaciones.Add(calificaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion", calificaciones.Id_Materia);
            ViewBag.Id_Profesor = new SelectList(db.Profesor, "ID_Profesor", "Nombres", calificaciones.Id_Profesor);
            ViewBag.Id_Estudiante = new SelectList(db.Estudiante, "ID_Estudiante", "Primer_Nombre", calificaciones.Id_Estudiante);
            return View(calificaciones);
        }

        // GET: Calificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion", calificaciones.Id_Materia);
            ViewBag.Id_Profesor = new SelectList(db.Profesor, "ID_Profesor", "Nombres", calificaciones.Id_Profesor);
            ViewBag.Id_Estudiante = new SelectList(db.Estudiante, "ID_Estudiante", "Primer_Nombre", calificaciones.Id_Estudiante);
            return View(calificaciones);
        }

        // POST: Calificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id_Estudiante,Id_Materia,Id_Profesor,Nota")] Calificaciones calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion", calificaciones.Id_Materia);
            ViewBag.Id_Profesor = new SelectList(db.Profesor, "ID_Profesor", "Nombres", calificaciones.Id_Profesor);
            ViewBag.Id_Estudiante = new SelectList(db.Estudiante, "ID_Estudiante", "Primer_Nombre", calificaciones.Id_Estudiante);
            return View(calificaciones);
        }

        // GET: Calificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        // POST: Calificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            db.Calificaciones.Remove(calificaciones);
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
