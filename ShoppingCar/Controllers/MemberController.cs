using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCar.Models;

namespace ShoppingCar.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {
        ShoppingCarDBContext db = new ShoppingCarDBContext();
        // GET: Member
        public ActionResult Index()
        {
            var products = db.Product.OrderBy(x => x.Name).ToList();
            return View("../Home/Index","_LayoutMember",products);
        }

        public ActionResult ShoppingCar()
        {
            
            string Userid = User.Identity.Name;
            var orderDetail = db.tOrderDetail.Where(m => m.UserId == Userid && m.flsQpproved =="否").ToList();
           
            return View(orderDetail);
            
        }

        public ActionResult AddCar(string Pid)
        {
            string Userid = User.Identity.Name;
            var CurrentCar = db.tOrderDetail.Where(m => m.Pid == Pid && m.flsQpproved == "否" && m.UserId == Userid)
                .FirstOrDefault(); 
            if (CurrentCar == null)
            {
                var product = db.Product.Where(m => m.PId == Pid).FirstOrDefault();
                tOrderDetail od = new tOrderDetail();  
                od.UserId= Userid;
                od.Pid = product.PId;
                od.Name= product.Name;
                od.Price = product.Price;
                od.Qty = 1;
                od.flsQpproved = "否";
                db.tOrderDetail.Add(od);
            }
            else
            {
                CurrentCar.Qty += 1;
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar"); 
        }

        public ActionResult DeleteCar(int Id)
        {
            var od = db.tOrderDetail.Where(m => m.Id == Id).FirstOrDefault();
            db.tOrderDetail.Remove(od);
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        [HttpPost,ActionName("ShoppingCar")]
        public ActionResult ShoppingCar(string Receiver,string Email,string Address)
        {
            string UserId = User.Identity.Name;
            string guid = Guid.NewGuid().ToString();
            tOrder od = new tOrder();
            od.OrderGuid = guid;
            od.UserId = UserId;
            od.Receiver= Receiver; 
            od.Email = Email;
            od.Address= Address;
            od.Date = DateTime.Now;
            db.tOrder.Add(od);
            var carList = db.tOrderDetail.Where(m => m.flsQpproved == "否" && m.UserId == UserId).ToList();
          

            foreach (var car in carList)
            {
                car.OrderGuid = guid;
                car.flsQpproved = "是";
            }
            db.SaveChanges();
            return RedirectToAction("OrderList");
        }

        public ActionResult OrderList()
        {
            string UserId = User.Identity.Name;
            var od = db.tOrder.Where(m => m.UserId== UserId).OrderByDescending(m => m.Date).ToList();
            return View(od);

        }

      
        public ActionResult OrderDetail(string OrderGuid)
        {
            var odDtail = db.tOrderDetail.Where(m => m.OrderGuid == OrderGuid).ToList();
            
            return View(odDtail);

        }

    }

    
}