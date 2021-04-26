using Cleverbit.Data.DTO;
using Cleverbit.Data.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Cleverbit.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _service;

        public OrderController(IOrderService service)
        {
            this._service = service;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        // Save order
        /// <summary>
        /// Save an order
        /// </summary>
        /// <param name="productId">Product Id</param>
        /// <returns>BaseOperationResponse</returns>
        public ActionResult SaveOrder(Guid productId)
        {
            //TODO: Order could be added to a cart. Will raise this error if anonymous
            var response = new BaseOperationResponse { IsSuccess = false, Message = "You need to login to purchase."};
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.Identity.GetUserId();
                response = this._service.SaveOrder(productId, new Guid(userId));
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}