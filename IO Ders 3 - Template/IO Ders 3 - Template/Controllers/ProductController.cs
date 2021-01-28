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
    public class ProductController : Controller
    {
        // GET: Product

        NorthwindEntiti model = new NorthwindEntiti();
        
        public ActionResult Index()
        {
            List<Product> prod = model.Products.ToList();
            return View(prod);
        }

        public ActionResult AddProduct()
        {
            ViewBag.Supplier = model.Suppliers.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            model.Products.Add(p);
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            Product p = model.Products.SingleOrDefault(x => x.ProductID == id);
            return View(p);
        }

        [HttpPost]
        public ActionResult DeleteProduct(Product p)
        {
            Product prod = model.Products.FirstOrDefault(x => x.ProductID == p.ProductID);
            model.Products.Remove(prod);
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProductDetail()
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            string adi = Request.QueryString["adi"].ToString();
            Product p = model.Products.SingleOrDefault(x => x.ProductID == id);
            return View(p);
        }

        [HttpPost]
        public void AddToBasket(int id)
        {
            Basket b;
            if (Session["ActiveBasket"] == null)
            {
                b = new Basket();
            }
            else
            {
                b = (Basket)Session["ActiveBasket"];
            }
            Product p = model.Products.SingleOrDefault(x => x.ProductID == id);
            b.Product.Add(p);
            Session["ActiveBasket"] = b;
        }
    }
}