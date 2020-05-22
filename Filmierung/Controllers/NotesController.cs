using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmierung.Controllers
{
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Notes()
        {
            return View();
        }
    }
}