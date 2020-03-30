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
    public class Subir_TareaController : Controller
    {
        private SistemaEscolarEntities db = new SistemaEscolarEntities();

        // GET: Subir_Tarea
        public ActionResult Index()
        {
            return View(db.Subir_Tarea.ToList());
        }

        // GET: Subir_Tarea/Create
        public ActionResult CreateTarea()
        {
            return View();
        }

        // POST: Subir_Tarea/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaEspañol([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 1;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaMatematica([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 2;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaNaturales([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 3;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaSociales([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 4;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaReligion([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 5;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaDeporte([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 6;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaArte([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 7;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaOptativa([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.ID_Registro = ' ';
                subir_Tarea.ID_Materia = 8;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }

            return View(subir_Tarea);
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
