using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;
using Rotativa.Options;
using Model;
using System.Web.Services.Description;

namespace SchoolSystem.Controllers
{

    public class ServiceController : Controller
    {
        SistemaEscolarEntities db = new SistemaEscolarEntities();

        // GET: Service
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        public ActionResult RecordNotas(string PrimerNombre, string PrimerApellido, string SegundoApellido, string NombrePadres, string Year)
        {
            var Id =  db.Calificaciones.FirstOrDefault();

            var Student = db.Calificaciones.ToList().Where(x => x.Estudiante.Primer_Nombre == PrimerNombre && x.Estudiante.Primer_Apellido == PrimerApellido && x.Estudiante.Segundo_Apelido == SegundoApellido && x.Id_Estudiante == x.Estudiante.ID_Estudiante);
            var Calification = db.Calificaciones.FirstOrDefault(x => x.Id_Estudiante.ToString() == Id.Id_Estudiante.ToString());
            var Nombre = Calification.Estudiante.Primer_Nombre + " " + Calification.Estudiante.Primer_Apellido + " " + Calification.Estudiante.Segundo_Apelido;

            ViewBag.Nombre = Nombre;
            ViewBag.Student = Student;

            if (Calification == null)
            {
                return RedirectToAction("Index", new { message = "No Existe este registro, favor ingrese valores validos" });
            }
            else
            {
                return View();
            }


        }



        public ActionResult Print()
        {
            return new ActionAsPdf("RecordNotas") { FileName = "RecordNotas.pdf" };
        }


    }

}