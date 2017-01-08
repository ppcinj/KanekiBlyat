using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParelloZmorge.Models;
using Kendo.Mvc.Extensions;
using Microsoft.AspNet.Identity.EntityFramework;
using ParelloZmorge.BusinessEntities;

namespace ParelloZmorge.Controllers
{
	[Authorize(Roles = "Admin")]
    public class UserController : Controller
	{
		ApplicationDbContext _context = new ApplicationDbContext();
		// GET: User
		public ActionResult Index()
		{
			ViewBag.Message = "Hier können sie Ihren Benutzern Rollen und somit Rechte zuweisen.";
			//this class created because we can not use the original IdentityRole cause of its complexity. Thats why i copy the original IdentityRoles into a DataTranserObject
			List<IdentityRoleModel> roles = _context.Roles.Select(x => new IdentityRoleModel() { Id = x.Id, Name = x.Name }).ToList();
			if (roles.Count > 0)
			{
				ViewData["defaultRole"] = roles.First();
			}
			else
			{
				throw new Exception("No user roles defined. Please use the provided  sql install scripts!");
			}

			
			return View();
        }

		public JsonResult GetUsers([DataSourceRequest]DataSourceRequest request)
		{
			var users = _context.Users.Select(u => new ApplicationUserModel
			{
				Id = u.Id,
				Prename = u.Prename,
				Surname = u.Surname,
				Email = u.Email,
				WorkPlaceHint = u.WorkPlaceHint,
				Role = new IdentityRoleModel() { Id = u.Roles.FirstOrDefault().RoleId, Name = _context.Roles.FirstOrDefault(x => x.Id == u.Roles.FirstOrDefault().RoleId).Name}
			}
				);
			return Json(users.ToDataSourceResult(request));
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public JsonResult Update([DataSourceRequest] DataSourceRequest request, ApplicationUserModel user)
		{
			if (user != null && ModelState.IsValid)
			{
				ApplicationUser userToUpdate = _context.Users.Where(u => u.Id == user.Id.ToString()).FirstOrDefault();
				userToUpdate.Prename = user.Prename;
				userToUpdate.Surname = user.Surname;
				userToUpdate.Email = user.Email;
				userToUpdate.WorkPlaceHint = user.WorkPlaceHint;
				userToUpdate.Roles.Clear();
				userToUpdate.Roles.Add(new IdentityUserRole() { RoleId = user.Role.Id.ToString(), UserId = user.Id });
			}

			_context.SaveChanges();

			return Json(ModelState.IsValid ? true : ModelState.ToDataSourceResult());
		}
	}
}