using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Model;

namespace SchoolSystem.Controllers
{
    public class AdmisionesController : Controller
    {
        private SistemaEscolarEntities db = new SistemaEscolarEntities();

        public ActionResult InfoAdmi()
        {
            return View();
        }

        // GET: Admisiones/Create
        public ActionResult Create()
        {
            ViewBag.ID_Grado = new SelectList(db.Grado, "ID_Grado", "Descripcion");
            return View();
        }

        // POST: Admisiones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Estudiante,Primer_Nombre,Segundo_Nombre,Primer_Apellido," +
            "Segundo_Apelido,FechaNacimiento,Edad,Nacionalidad,Sexo,ID_Grado,CentroEducativo," +
            "GradoSolicita,DistritoEducativo")] Estudiante estudiante, [Bind(Include = "Calle,Provincia,Municipio," +
            "Sector,No_Casa")] Direccion direccion, [Bind(Include = "Nombres,Apellidos," +
            "Parentesco,Cedula,Profesion,Telefono,Celular")] Padre_Tutor padre, [Bind(Include = "ID_Estudiante")]
            Documentos_Estudiantes documentos, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                documentos.Foto = new byte[imagen.ContentLength];
                imagen.InputStream.Read(documentos.Foto, 0, imagen.ContentLength);
                documentos.ActaNacimiento = new byte[imagen.ContentLength];
                imagen.InputStream.Read(documentos.ActaNacimiento, 1, imagen.ContentLength);
                documentos.CertificadoMedico = new byte[imagen.ContentLength];
                imagen.InputStream.Read(documentos.CertificadoMedico, 2, imagen.ContentLength);
                documentos.CopiaCedula = new byte[imagen.ContentLength];
                imagen.InputStream.Read(documentos.CopiaCedula, 3, imagen.ContentLength);
                documentos.CertificadoEscorlar = new byte[imagen.ContentLength];
                imagen.InputStream.Read(documentos.CertificadoEscorlar, 4, imagen.ContentLength);
                documentos.RecordNotas = new byte[imagen.ContentLength];
                imagen.InputStream.Read(documentos.RecordNotas, 5, imagen.ContentLength);

                direccion.ID_Estudiante = estudiante.ID_Estudiante;
                padre.ID_Estudiante = estudiante.ID_Estudiante;
                documentos.ID_Estudiante = estudiante.ID_Estudiante;
                db.Estudiante.Add(estudiante);
                db.Direccion.Add(direccion);
                db.Padre_Tutor.Add(padre);
                db.Documentos_Estudiantes.Add(documentos);
                db.SaveChanges();
                return RedirectToAction("InfoAdmi");
            }

            ViewBag.ID_Grado = new SelectList(db.Grado, "ID_Grado", "Descripcion", estudiante.ID_Grado);
            return View();
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
