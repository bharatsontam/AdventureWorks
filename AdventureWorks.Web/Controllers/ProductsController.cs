using AdventureWorks.BAL.Repository;
using AdventureWorks.DAL;
using AdventureWorks.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.Web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProductList()
        {
            ProductRepository repo = new ProductRepository();
            var productList = repo.GetAll;
            var result = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(productList);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}