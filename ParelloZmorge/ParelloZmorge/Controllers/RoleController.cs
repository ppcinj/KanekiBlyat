using Microsoft.AspNet.Identity.EntityFramework;
using ParelloZmorge.BusinessEntities;
using ParelloZmorge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParelloZmorge.Controllers
{
	[Authorize(Roles = "Admin")]
    public class RoleController : Controller
	{
		ApplicationDbContext _context = new ApplicationDbContext();
		// GET: Roles
		public JsonResult Index()
        {
			var roles = _context.Roles.Select(r => new IdentityRoleModel { Id = r.Id, Name = r.Name });


			return this.Json(roles, JsonRequestBehavior.AllowGet);
        }
    }
}