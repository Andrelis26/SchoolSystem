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
        public ActionResult CreateTarea([Bind(Include = "ID_Tarea")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea)
        {
            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

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
