using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SchoolSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Account(string message ="")
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Account(string usuario, string contraseña)
        {
            if(!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {
                SistemaEscolarEntities db = new SistemaEscolarEntities();
                var user = db.Registro.FirstOrDefault(e => e.Usuario == usuario && e.Contraseña == contraseña);
                //si el usuario es diferente a null
                if(user!=null)
                {
                    //usuario con datos
                    FormsAuthentication.SetAuthCookie(user.Usuario, true);
                    Session["Usuario"] = user.Usuario;
                    return RedirectToAction("InternalHome", "Home");
                    
                }
                else
                {
                    return RedirectToAction("Account", new { message = "Datos no encontrados" });
                }
            }
            else
            {
                return Account("Llena todos los campos para iniciar sesion");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Account");
        }
    }
}