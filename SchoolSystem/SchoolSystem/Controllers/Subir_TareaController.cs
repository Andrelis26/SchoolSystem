using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
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
            var items = GetFiles();
            var subir_Tarea = db.Subir_Tarea.Include(s => s.Materias).Include(s => s.Registro);
            return View(subir_Tarea.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.ID_Materia = new SelectList(db.Materias, "ID_Materia", "Descripcion");
            ViewBag.ID_Registro = new SelectList(db.Registro, "ID_Estudiante", "Usuario");
            return View();
        }


        // POST: Subir_Tarea/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaEspañol([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
            Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);
                subir_Tarea.Id_TareaAsignada = ID; 
                subir_Tarea.ID_Materia = 1;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaMatematica([Bind(Include = "ID_Tarea,ID_Materia,ID_Registro")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                                   Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);
                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 2;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaNaturales([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                                   Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);
                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 3;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaSociales([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                                   Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);
                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 4;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaReligion([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                       Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 5;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaDeporte([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                                   Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);
                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 6;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaArte([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                                   Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);
                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 7;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }

        public FileContentResult Descarga(int id)
        {
            byte[] Tarea;
            var Documento = db.Subir_Tarea.Find(id);
            Tarea = (byte[])Documento.Tarea.ToArray();
            return File(Tarea, "Text", "Tarea.pdf");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TareaOptativa([Bind(Include = "ID_Tarea,ID_Materia,ID_Estudiante")] Subir_Tarea subir_Tarea, HttpPostedFileBase tarea, int ID)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"),
                          Path.GetFileName(tarea.FileName));

            if (ModelState.IsValid)
            {
                subir_Tarea.Tarea = new byte[tarea.ContentLength];
                tarea.InputStream.Read(subir_Tarea.Tarea, 0, tarea.ContentLength);

                subir_Tarea.Id_TareaAsignada = ID;
                subir_Tarea.ID_Estudiante = Convert.ToInt32(Session["ID_Estudiante"]);
                subir_Tarea.ID_Materia = 8;
                db.Subir_Tarea.Add(subir_Tarea);
                db.SaveChanges();
                tarea.SaveAs(path);
                TempData["SuccessMessage"] = "Su tarea ha sido enviada";
                return View("~/Views/Asignar_Tarea/Index.cshtml");
            }
            return View(subir_Tarea);
        }



        private List<string> GetFiles()
        {
            var dir = new System.IO.DirectoryInfo(Server.MapPath("~/Archivos"));
            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*");

            List<string> items = new List<string>();
            foreach (var file in fileNames)
            {
                items.Add(file.Name);
            }

            return items;
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
