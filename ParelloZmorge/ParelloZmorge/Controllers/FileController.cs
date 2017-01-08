using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParelloZmorge.Controllers
{
	public class FileController : Controller
	{
		[HttpPost]
		public ActionResult FileUpload(IEnumerable<HttpPostedFileBase> files, int id)
		{
			if (files != null && files.Any())
			{
				string nameAndLocation = "~/images/" + id + ".jpg";
				files.First().SaveAs(Server.MapPath(nameAndLocation));
			}
			return Content("");
		}

		private IEnumerable<string> GetFileInfo(IEnumerable<HttpPostedFileBase> files)
		{
			return
				from a in files
				where a != null
				select string.Format("{0} ({1} bytes)", Path.GetFileName(a.FileName), a.ContentLength);
		}
	}
}