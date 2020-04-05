using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace SchoolSystem.Authorize
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {

        public string Perfil { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                return false;
            }

            SistemaEscolarEntities db = new SistemaEscolarEntities();
            Registro usuario = new Registro();

            using (db)
            {
                usuario = db.Registro.FirstOrDefault(a => a.Usuario == HttpContext.Current.User.Identity.Name);

            }

            if (usuario.Rol.Contains(Perfil))
                return true;

            return false;
        }
    }
}