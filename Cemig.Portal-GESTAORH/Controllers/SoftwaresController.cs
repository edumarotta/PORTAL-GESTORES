using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cemig.Portal_GESTAORH.Controllers
{
    public class SoftwaresController : Controller
    {
        // GET: Softwares
        public ActionResult IndexSoftwares()
        {
            return View();
        }

        public ActionResult CIS()
        {
            return View();
        }

        public ActionResult GECIPA()
        {
            return View();
        }


        public ActionResult GESTORSST()
        {
            return View();
        }

    }


}