using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ShoppingCar.Models;

namespace ShoppingCar.Controllers
{
    
    public class HomeController : Controller
    {
        private ShoppingCarDBContext db = new ShoppingCarDBContext();
        public ActionResult Index()
        {          
            
            return View();
        }

        public ActionResult product()
        {
            //將產品放進products
            IQueryable<Product> ListAll = from m in db.Product
                                          select m;
            return View(ListAll);
        }

        public ActionResult Login()
        {
           return View();
        }
        
        [HttpPost,ActionName("Login")]
        public ActionResult Login(string UserId, string Pwd)
        {
            var member = db.tMember.Where(m=> m.Userid == UserId && m.Pwd == Pwd).FirstOrDefault();
           
            if (member == null)
            {

                ViewBag.Message = "帳密錯誤,登入失敗";
                return View();
            }
           
            Session["Welcome"] = member.Name + "歡迎光臨";
            FormsAuthentication.RedirectFromLoginPage(UserId, true);
            return RedirectToAction("Index","Member");                                    
        }

        public ActionResult create() 
        {   

            return View(); 
        }

        [HttpPost,ActionName("create")]
        [ValidateAntiForgeryToken]
        public ActionResult create2(tMember member)
        {
            db.tMember.Add(member);
            db.SaveChanges();
            return RedirectToAction("Index", "Member");
        }

        public ActionResult register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult register(tMember member)
        {
            
            if (ModelState.IsValid == false)
            {
                return View();
            }
            var Member = db.tMember.Where(m => m.Userid== member.Userid).FirstOrDefault();
            if (Member == null)
            {
                db.tMember.Add(member);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ViewBag.Message = "此帳號已經有人使用";
            return View();
        }

    }
}