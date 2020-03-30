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
    public class Asignar_TareaController : Controller
    {
        private SistemaEscolarEntities db = new SistemaEscolarEntities();

        // GET: Asignar_Tarea
        public ActionResult Index()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            return View(asignar_Tarea.ToList());
        }

        public ActionResult Español()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 1 select x;
            return View(consulta.ToList());
        }

        public ActionResult Matematica()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 2 select x;
            return View(consulta.ToList());
        }

        public ActionResult Sociales()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 3 select x;
            return View(consulta.ToList());
        }

        public ActionResult Naturales()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 4 select x;
            return View(consulta.ToList());
        }

        public ActionResult Religion()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 5 select x;
            return View(consulta.ToList());
        }

        public ActionResult Deporte()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 6 select x;
            return View(consulta.ToList());
        }

        public ActionResult Arte()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 7 select x;
            return View(consulta.ToList());
        }

        public ActionResult Optativa()
        {
            var asignar_Tarea = db.Asignar_Tarea.Include(a => a.Materias);
            var consulta = from x in db.Asignar_Tarea where x.ID_Materia == 8 select x;
            return View(consulta.ToList());
        }

        // GET: Asignar_Tarea/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignar_Tarea asignar_Tarea = db.Asignar_Tarea.Find(id);
            if (asignar_Tarea == null)
            {
                return HttpNotFound();
            }
            return View(asignar_Tarea);
        }

        // GET: Asignar_Tarea/Create
        public ActionResult Create()
        {
            ViewBag.ID_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion");
            return View();
        }

        // POST: Asignar_Tarea/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_AsignarTarea,ID_Materia,Titulo,Contenido")] Asignar_Tarea asignar_Tarea)
        {
            if (ModelState.IsValid)
            {
                db.Asignar_Tarea.Add(asignar_Tarea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion", asignar_Tarea.ID_Materia);
            return View(asignar_Tarea);
        }

        // GET: Asignar_Tarea/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignar_Tarea asignar_Tarea = db.Asignar_Tarea.Find(id);
            if (asignar_Tarea == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion", asignar_Tarea.ID_Materia);
            return View(asignar_Tarea);
        }

        // POST: Asignar_Tarea/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_AsignarTarea,ID_Materia,Titulo,Contenido")] Asignar_Tarea asignar_Tarea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asignar_Tarea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion", asignar_Tarea.ID_Materia);
            return View(asignar_Tarea);
        }

        // GET: Asignar_Tarea/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignar_Tarea asignar_Tarea = db.Asignar_Tarea.Find(id);
            if (asignar_Tarea == null)
            {
                return HttpNotFound();
            }
            return View(asignar_Tarea);
        }

        // POST: Asignar_Tarea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Asignar_Tarea asignar_Tarea = db.Asignar_Tarea.Find(id);
            db.Asignar_Tarea.Remove(asignar_Tarea);
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
