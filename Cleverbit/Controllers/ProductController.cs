using Cleverbit.Data.DTO;
using Cleverbit.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cleverbit.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            this._service = service;
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            var products = this._service.GetProducts();
            return Json(new
            {
                products
            }, JsonRequestBehavior.AllowGet);
        }
    }
}