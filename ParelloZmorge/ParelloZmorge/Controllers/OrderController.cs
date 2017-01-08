using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using ParelloZmorge.BusinessEntities;
using ParelloZmorge.DataTransferObjects;
using ParelloZmorge.Enums;
using ParelloZmorge.Models;
using WebGrease.Css.Ast.Selectors;

namespace ParelloZmorge.Controllers
{
	[Authorize]
	public class OrderController: Controller
	{
		ApplicationDbContext _context = new ApplicationDbContext();
		[HttpPost]
		public ActionResult Create(IEnumerable<OrderProductDTO> orderedProducts)
		{
			if (orderedProducts != null)
			{
				var order = new Order();
				order.OrderProductLinkifications = new List<ProductOrderLinkification>();
				order.Date = DateTime.Now;
				order.State = OrderState.Waiting;
				order.User = _context.Users.FirstOrDefault(user => user.UserName == User.Identity.Name);

				foreach (OrderProductDTO productDTO in orderedProducts)
				{
					var orderedProduct = _context.Products.SingleOrDefault(p => p.Id == productDTO.ProductId);
					order.OrderProductLinkifications.Add(new ProductOrderLinkification
					{
						Order = order,
						Product = orderedProduct,
						Amount = productDTO.Amount
					});
				}

				_context.Orders.Add(order);
				_context.SaveChanges();

				return Content(order.DataId.ToString());
			}
			throw new Exception("Fehler bei übermittlung von Bestellung.");
		}

		[HttpGet]
		public ActionResult List()
		{
			var orderList = _context.Orders.Where(o => o.State == OrderState.Waiting).Select(dbo => new OrderModel
				{
						Id = dbo.DataId,
						User = new ApplicationUserModel
						{
							Id = dbo.User.Id,
							Surname = dbo.User.Surname,
							Prename = dbo.User.Prename,
							WorkPlaceHint = dbo.User.WorkPlaceHint
						},
						OrderedProducts = dbo.OrderProductLinkifications.Select(op => new OrderProductModel()
						{
							Id = op.Product.Id,
							Amount = op.Amount,
							Name = op.Product.Name,
							Price = op.Product.Price
						}).ToList(),
                        OrderState = dbo.State
				}).OrderBy(x => x.Id).ToList();
			    return this.View("List", new OrderListViewModel() { Orders = orderList});
        }

        [HttpGet]
        public ActionResult ListOld()
        {
            var orderList = _context.Orders.Where(o => o.State != (OrderState)OrderState.Waiting).Select(dbo => new OrderModel
            {
                Id = dbo.DataId,
                User = new ApplicationUserModel
                {
                    Id = dbo.User.Id,
                    Surname = dbo.User.Surname,
                    Prename = dbo.User.Prename,
                    WorkPlaceHint = dbo.User.WorkPlaceHint
                },
                OrderedProducts = dbo.OrderProductLinkifications.Select(op => new OrderProductModel()
                {
                    Id = op.Product.Id,
                    Amount = op.Amount,
                    Name = op.Product.Name,
                    Price = op.Product.Price
                }).ToList(),
                OrderState = dbo.State
            }).OrderBy(x => x.Id).ToList();
            return this.View("ListOld", new OrderListViewModel() { Orders = orderList });
        }

        [HttpGet]
	    public JsonResult MarkOrderAs(int orderId, int setValue)
	    {
	        try
	        {
                var order = _context.Orders.FirstOrDefault(o => o.DataId == orderId);

                //trigger lazy loading because of microsoft fail template loading --> please microsoft learn how to code fakin noobs
	            var user = order.User;

                order.State = (OrderState)setValue;
                _context.SaveChanges();
                return Json("OK", JsonRequestBehavior.AllowGet);
            }
	        catch (Exception ex)
	        {
	            return Json(ex.Message, JsonRequestBehavior.AllowGet);
	        }
	    }
    }
}