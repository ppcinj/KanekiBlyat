using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using ParelloZmorge.BusinessEntities;
using ParelloZmorge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParelloZmorge.Controllers
{
	public class ProductController : Controller
	{
		ApplicationDbContext _context = new ApplicationDbContext();


		[Authorize(Roles = "Lieferant,Admin")]
		public ActionResult Index()
		{
			ViewBag.Message = "Hier können sie Produkte hinzufügen, entfernen oder bearbeiten.";

			return View();
		}

		[Authorize(Roles = "Lieferant,Admin,Mitarbeiter")]
		public JsonResult GetProducts([DataSourceRequest]DataSourceRequest request)
		{
			var products = _context.Products.Select(p => new ProductModel
			{
				Id = p.Id,
				Name = p.Name,
				Description = p.Description,
				Weight = p.Weight,
				Price = p.Price,
				ImageUploadModel = new ImageUploadModel() { Id = p.Id}
			}
				);
			return Json(products.ToDataSourceResult(request));
		}


		[Authorize(Roles = "Lieferant,Admin")]
		[AcceptVerbs(HttpVerbs.Post)]
		public JsonResult Update([DataSourceRequest] DataSourceRequest request, ProductModel product)
		{
			if (product != null && ModelState.IsValid)
			{
				var productToUpdate = _context.Products.Where(p => p.Id == product.Id).FirstOrDefault();
				productToUpdate.Name = product.Name;
				productToUpdate.Price = product.Price ?? 0;
				productToUpdate.Weight = product.Weight;
				productToUpdate.Description = product.Description;
			}

			_context.SaveChanges();

			return Json(ModelState.IsValid ? true : ModelState.ToDataSourceResult());
		}


		[Authorize(Roles = "Lieferant,Admin")]
		[AcceptVerbs(HttpVerbs.Post)]
		public JsonResult Create([DataSourceRequest] DataSourceRequest request, ProductModel product)
		{

			if (product != null && ModelState.IsValid)
			{
				var productToCreate = new Product
				{
					Name = product.Name,
					Price = product.Price??0,
					Weight = product.Weight,
					Description = product.Description
				};

				_context.Products.Add(productToCreate);
				_context.SaveChanges();

			}

			return Json(ModelState.IsValid ? true : ModelState.ToDataSourceResult());

		}


		[Authorize(Roles = "Lieferant,Admin")]
		[AcceptVerbs(HttpVerbs.Post)]
		public JsonResult Delete([DataSourceRequest] DataSourceRequest request, ProductModel product)
		{

			if (product != null && ModelState.IsValid)
			{
				var productToDelete = _context.Products.Where(p => p.Id == product.Id).FirstOrDefault();

				_context.Products.Remove(productToDelete);
				_context.SaveChanges();
			}

			return Json(ModelState.IsValid ? true : ModelState.ToDataSourceResult());
		}

		[Authorize(Roles = "Lieferant,Admin,Mitarbeiter")]
		[HttpGet]
		public ActionResult GetProduct(int productId)
		{
			var product = _context.Products.FirstOrDefault(p => p.Id == productId);
			var productModel = new ProductModel() {Id = product.Id, Description = product.Description, Name = product.Name, Price = product.Price};
			return Json(productModel, JsonRequestBehavior.AllowGet);
		}
	}
}