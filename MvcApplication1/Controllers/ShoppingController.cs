using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ShoppingController : Controller
    {
        //
        // GET: /Shopping/

        public ActionResult Index()
        {
            return View();
        }


        //Product
        [HttpGet]
        public ActionResult Products(int ProductID)
        {

            MVCTestEntities _entity = new MVCTestEntities();
            List<Product> hh = _entity.Products.Where(x => x.CategoryID == ProductID).ToList();

          return View(hh);
        }


        [HttpGet]
        public ActionResult ProductDetails(int ProductID)
        {

            MVCTestEntities _entity = new MVCTestEntities();
            Product hh = _entity.Products.Where(x => x.ProductID == ProductID).First();

            return View(hh);
        }



    }
}
