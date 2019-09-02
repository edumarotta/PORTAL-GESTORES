using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cemig.Portal_GESTAORH.Controllers
{
    public class InfosSegurancaTrabalhoController : Controller
    {
        // GET: InfosSegurancaTrabalho
        public ActionResult CIPA()
        {
            return View();
        }

        public ActionResult PPRA()
        {
            return View();
        }


        public ActionResult PCMSO()
        {
            return View();
        }
        
        public ActionResult SegurancaDoTrabalho()
        {
            return View();
        }
    }
}