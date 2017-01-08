using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParelloZmorge.Models
{
	public class ApplicationUserModel
	{
		[Editable(false)]
		[ScaffoldColumn(false)]
		public string Id { get; set; }
		[Editable(false)]
		[Required]
		public string Prename { get; set; }
		[Editable(false)]
		[Required]
		public string Surname { get; set; }
		[Editable(false)]
		[Required]
		public string Email { get; set; }
		[Editable(false)]
		[Required]
		public string WorkPlaceHint { get; set; }
		[Editable(true)]
		[UIHint("RoleEditor")]
		public IdentityRoleModel Role { get; set; }
	}
}