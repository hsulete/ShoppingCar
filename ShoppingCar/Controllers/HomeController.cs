using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCar.Models;

namespace ShoppingCar.Controllers
{
    
    public class HomeController : Controller
    {
        private ShoppingCarDBContext db = new ShoppingCarDBContext();
        public ActionResult Index()
        {
            //將產品放進products
            IQueryable<Product> ListAll = from m in db.Product
                                          select m;
            return View(ListAll);
        }

        public ActionResult About()
        {
            IQueryable<Product> ListAll = from m in db.Product
                                          select m;
            return View(ListAll);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}