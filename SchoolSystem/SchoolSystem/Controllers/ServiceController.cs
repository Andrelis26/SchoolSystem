using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;
using Rotativa.Options;

namespace SchoolSystem.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RecordNotas()
        {
            return View();
        }

        public ActionResult Print()
        {
            var report = new ActionAsPdf("RecordNotas");
            report.FileName = "RecordNotas.pdf";
            report.PageOrientation = Orientation.Landscape;
            report.PageSize = Size.A4;
            report.PageMargins = new Margins(10, 5, 10, 5);
            return report;
        }
    }
}