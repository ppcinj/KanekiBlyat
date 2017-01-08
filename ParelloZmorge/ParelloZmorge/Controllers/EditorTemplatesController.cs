using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParelloZmorge.Controllers
{
    public class EditorTemplatesController : Controller
    {
        // GET: EditorTemplates
        public ActionResult Index()
        {
            return View("Shared/EditorTemplates/RoleView");
        }
    }
}