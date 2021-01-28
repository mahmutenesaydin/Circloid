using IO_Ders_3___Template.App_Classes;
using IO_Ders_3___Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IO_Ders_3___Template.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ActiveMember = HttpContext.Application["ActiveMember"];
            ViewBag.TotalVisitors = HttpContext.Application["TotalVisitors"];
            return View();
        }

        public ActionResult AssignCookie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AssignCookie(string CookieName, string Description)
        {
            HttpCookie cookie = new HttpCookie(CookieName);
            cookie.Value = Description;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            return View();
        }

        public ActionResult MyCart()
        {
            List<Product> product = new List<Product>();
            if (Session["ActiveBasket"] != null)
            {
                Basket b = (Basket)Session["ActiveBasket"];
                product = b.Product;
            }
            return View();
        }

        public ActionResult MyBasket()
        {
            List<Product> p = new List<Product>();
            if (Session["ActiveBasket"]!=null)
            {
                Basket b = (Basket)Session["ActiveBasket"];
                p = b.Product;
            }
            return View(p);
        }
    }
}